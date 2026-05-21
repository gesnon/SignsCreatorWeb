using LogicProject;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Primitives;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Worker
{
    public class QueueChecker : BackgroundService
    {
        private Dictionary<string, IService> _logics = new Dictionary<string, IService>();
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\user\source\repos\SignsCreatorWeb\Logics");

            List<FileDTO> result = dirInfo.GetFiles().Where(_ => _.Extension == ".dll").Select(_ => new FileDTO { Name = _.Name, Path = _.FullName }).ToList();

            foreach (FileDTO f in result)
            {
                var project = Assembly.LoadFrom(f.Path);
                var logics = project.GetTypes().Where(t => typeof(IService).IsAssignableFrom(t));
                foreach(var l in logics)
                {
                    IService log = (IService)Activator.CreateInstance(l);

                    _logics.Add(log.Type, log);
                }
            }

            var factory = new ConnectionFactory { HostName = "localhost", Port = 5672, Password = "guest", UserName = "guest" };

            using var connection = await factory.CreateConnectionAsync();

            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: "signsCreaterWebQueue", durable: true, exclusive: false, autoDelete: false, arguments: null);

            await channel.BasicQosAsync(0, 1, false, stoppingToken);

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (sender, @event) =>
            {
                await Consumer_ReceivedAsync(sender, @event, channel, stoppingToken);
            };

            await channel.BasicConsumeAsync("signsCreaterWebQueue", false, consumer, stoppingToken);

            await Task.Delay(Timeout.Infinite);

        }

        private async Task Consumer_ReceivedAsync(object sender, BasicDeliverEventArgs @event, IChannel channel, CancellationToken stoppingToken)
        {
            string message = Encoding.UTF8.GetString(@event.Body.ToArray());

            _logics["FirstProject"].Execute();


            await channel.BasicAckAsync(@event.DeliveryTag, false, stoppingToken);
        }
    }
}
