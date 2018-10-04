using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Data
{
    public class DataContext : DbContext
    {       
        public virtual DbSet<Foo> Foos { get; set; }
        public virtual DbSet<Bar> Bars { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
