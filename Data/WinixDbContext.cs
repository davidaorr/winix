using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Data
{    public class WinixDbContext : DbContext
    {
        public DbSet<Winix> Winix { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=192.169.179.186,1433;Network Library=DBMSSOCN;Initial Catalog=Winix;User ID=remoteAdmin;Password=allTh3Th1ng$;");
        }
    }
}