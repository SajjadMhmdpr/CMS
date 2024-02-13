using Domain.News;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DB : IdentityDbContext
    {

        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        public DB()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Data Source=DESKTOP-5U7BLGI\SQL2019;Initial Catalog=CMS;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Page>().Property(p => p.Text)
                .HasColumnType("nvarchar(MAX)");

            modelBuilder.Entity<Comment>().Property(p => p.Text)
                .HasColumnType("nvarchar(MAX)");
        }


        public DbSet<Page> Pages { get; set; }
        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
