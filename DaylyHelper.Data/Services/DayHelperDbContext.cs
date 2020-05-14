using DaylyHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaylyHelper.Data.Services
{
    public class DayHelperDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
