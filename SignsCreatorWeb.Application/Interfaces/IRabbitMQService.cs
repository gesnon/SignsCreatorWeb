using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Application.Interfaces
{
    public interface IRabbitMQService
    {
        public void SendMessageAsync(string message, string queueName);
    }
}
