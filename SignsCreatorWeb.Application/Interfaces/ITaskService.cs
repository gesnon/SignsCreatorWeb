using SignsCreatorWeb.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Application.Interfaces
{
    public interface ITaskService
    {

        public Task<int> CreateAsync(Models.Task dto);

    }
}
