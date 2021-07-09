using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Database
{

    public class DatabaseContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }
        public  DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
           
        }
    }
}
