using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.ModelClass;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Author>  Authors  { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAGITEC-0099\\SQLEXPRESS;Database=CodingPractice;TrustServerCertificate=True;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(10, 5);
             
            List<Book> listOfBooks = new List<Book>(); 
            listOfBooks.Add(new Book(){BookID = 1,BookTitle = "Automic Habits", ISBN = "1234", Price = 10.10M}); 
            listOfBooks.Add(new Book() { BookID = 2, BookTitle = "How To Write Journal", ISBN = "1234", Price = 20.10M });  
            modelBuilder.Entity<Book>().HasData(listOfBooks);
        }
    }
}
