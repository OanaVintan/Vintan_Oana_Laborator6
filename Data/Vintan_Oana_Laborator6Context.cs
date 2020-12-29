using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vintan_Oana_Laborator6.Models;

namespace Vintan_Oana_Laborator6.Data
{
    public class Vintan_Oana_Laborator6Context : DbContext
    {
        public Vintan_Oana_Laborator6Context (DbContextOptions<Vintan_Oana_Laborator6Context> options)
            : base(options)
        {
        }

        public DbSet<Vintan_Oana_Laborator6.Models.Book> Book { get; set; }
    }
}
