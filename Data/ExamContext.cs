using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kiretfinalexam.Models;

namespace kiretfinalexam.Data
{
    public class ExamContext : DbContext
    {
        public ExamContext (DbContextOptions<ExamContext> options)
            : base(options)
        {
        }

        public DbSet<kiretfinalexam.Models.Books> Books { get; set; } = default!;

        public DbSet<kiretfinalexam.Models.Author> Author { get; set; }

        public DbSet<kiretfinalexam.Models.Information> Information { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Books>().ToTable("Books");
            modelBuilder.Entity<Information>().ToTable("Information");
        }

    }
}
