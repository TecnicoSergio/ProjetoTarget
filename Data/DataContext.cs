using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoTarget.Models;
using Microsoft.Extensions;
using ProjetoTarget.Controllers;
using ProjetoTarget.Utils;
using Microsoft.EntityFrameworkCore;

namespace ProjetoTarget.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
       
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
        
}