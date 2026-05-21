using RabbitMQ.Client;
using SignsCreatorWeb.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SignsCreatorWeb.Application.Services
{
    public class RabbitMQService : IRabbitMQService
    {
        public async void SendMessageAsync(string message, string queueName)
        {
            var factory = new ConnectionFactory { HostName = "localhost", Port=5672, Password="guest", UserName="guest" };            

            using var connection = await factory.CreateConnectionAsync();

            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);            

            var body = Encoding.UTF8.GetBytes(message);

            await channel.BasicPublishAsync(exchange: "", routingKey: queueName, body: body);            
        }
    }
}
