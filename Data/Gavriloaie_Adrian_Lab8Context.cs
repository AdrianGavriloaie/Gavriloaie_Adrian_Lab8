using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gavriloaie_Adrian_Lab8.Models;

namespace Gavriloaie_Adrian_Lab8.Data
{
    public class Gavriloaie_Adrian_Lab8Context : DbContext
    {
        public Gavriloaie_Adrian_Lab8Context (DbContextOptions<Gavriloaie_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Gavriloaie_Adrian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Gavriloaie_Adrian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Gavriloaie_Adrian_Lab8.Models.Category> Category { get; set; }
    }
}
