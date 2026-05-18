using SignsCreatorWeb.Application.Interfaces;
using SignsCreatorWeb.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ISignsCreatorWebContext _context;

        public TaskService(ISignsCreatorWebContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(Models.Task dto)
        {
            _context.Tasks.Add(dto);

            await _context.SaveChangesAsync(CancellationToken.None);

            return dto.Id;
        }
    }
}
