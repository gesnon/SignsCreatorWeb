using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignsCreatorWeb.Infrastructure.Persistence
{
    public class DbInitializer
    {

        private readonly SignsCreatorWebContext _context;

        public DbInitializer(SignsCreatorWebContext context)
        {
            _context = context;
        }
        public async Task InitializeAsync()
        {
            await _context.Database.MigrateAsync();
        }
    }
}
