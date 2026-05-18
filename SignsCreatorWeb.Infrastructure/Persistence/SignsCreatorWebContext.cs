using Microsoft.EntityFrameworkCore;
using SignsCreatorWeb.Application.Interfaces;
using SignsCreatorWeb.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Infrastructure.Persistence
{
    public class SignsCreatorWebContext : DbContext, ISignsCreatorWebContext
    {
        public SignsCreatorWebContext(DbContextOptions<SignsCreatorWebContext> options) : base(options)
        {
        }
        public DbSet<Application.Models.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SignsCreatorWebContext).Assembly);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

        }
    }
}
