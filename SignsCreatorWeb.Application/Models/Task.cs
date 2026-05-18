using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Application.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public State State { get; set; }
    }
}
