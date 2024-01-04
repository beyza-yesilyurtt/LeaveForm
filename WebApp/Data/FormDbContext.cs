using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Data
{
    public class FormDbContext : DbContext
    {
        public FormDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Form> Forms { get; set; }
    }
}
