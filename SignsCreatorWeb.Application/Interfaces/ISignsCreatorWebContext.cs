using Microsoft.EntityFrameworkCore;
using SignsCreatorWeb.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Application.Interfaces
{
    public interface ISignsCreatorWebContext
    {
        public DbSet<Models.Task> Tasks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
