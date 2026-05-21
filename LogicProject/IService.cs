using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProject
{
    public interface IService
    {
        public string Type { get; set; }
        public void Execute();
    }
}
