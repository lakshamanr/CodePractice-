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
        public DbSet<AuthorBookMap> AuthorBookMap { get; set; }


        public DbSet<Fluent_Book> FluentBooks{ get; set; }
        public DbSet<Fluent_BookDetail> FluentDetailsBooks { get; set; }  
        public DbSet<Fluent_Author> FluentAuthor { get; set; }

        public DbSet<Fluent_Publisher> FluentPublishers{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAGITEC-0099\\SQLEXPRESS;Database=CodingPractice;TrustServerCertificate=True;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fluent_Author>().Ignore(x => x.FullName);
            modelBuilder.Entity<Fluent_Author>().HasKey(x => x.Author_id);
            modelBuilder.Entity<Fluent_Author>().Property(x => x.FirstName)
                                                .IsRequired()
                                                .HasMaxLength(50);


            modelBuilder.Entity<Fluent_BookDetail>().ToTable("Fluent_BookDetails");
            modelBuilder.Entity<Fluent_BookDetail>().Property(p => p.NumberOfChaoer).HasColumnName("Chapter");
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(x => x.BookDetail_ID);

            modelBuilder.Entity<Fluent_Book>().HasKey(x => x.BookID);
            modelBuilder.Entity<Fluent_Book>().Ignore(x => x.PriceRange);
            modelBuilder.Entity<Fluent_Book>().Property(x => x.BookTitle).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Fluent_Book>()
                .HasOne(publisher => publisher.FluentPublisher)
                .WithMany(books=>books.FluentBooks)
                .HasForeignKey(FK=>FK.Publisher_ID);

            modelBuilder.Entity<Fluent_Publisher>().HasKey(x => x.Publisher_ID);

            modelBuilder.Entity<Fluent_BookDetail>()
                    .HasOne(x => x.FluentBook)
                    .WithOne(x => x.BookDetail)
                    .HasForeignKey<Fluent_BookDetail>(x => x.BookID);


            modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(10, 5);
            modelBuilder.Entity<AuthorBookMap>().HasKey(x => new { x.Author_id,x.BookID});

            List<Book> listOfBooks = new List<Book>(); 
            listOfBooks.Add(new Book(){BookID = 1,BookTitle = "Automic Habits", ISBN = "1234", Price = 10.10M,Publisher_ID = 1}); 
            listOfBooks.Add(new Book() { BookID = 2, BookTitle = "How To Write Journal", ISBN = "1234", Price = 20.10M, Publisher_ID = 2});  
            modelBuilder.Entity<Book>().HasData(listOfBooks);

            List<Publisher> lstPublisher = new List<Publisher>();
            lstPublisher.Add(new Publisher() {Publisher_ID = 1,Location = "Pune",Name = "ABC"});
            lstPublisher.Add(new Publisher(){Publisher_ID = 2, Location = "Ambe",Name = "MNO"});
            modelBuilder.Entity<Publisher>().HasData(lstPublisher);

        }
    }
}
