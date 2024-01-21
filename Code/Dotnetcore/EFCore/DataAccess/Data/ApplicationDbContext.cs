using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data.FluentConfig;
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

        public DbSet<Category> Categories { get; set; }

        public DbSet<Fluent_Book> FluentBooks{ get; set; }
        public DbSet<Fluent_BookDetail> FluentDetailsBooks { get; set; }  
        public DbSet<Fluent_Author> FluentAuthor { get; set; }

        public DbSet<Fluent_Publisher> FluentPublishers{ get; set; }

        public DbSet<Fluent_AuthorBookMap> FluentAuthorBookMap { get; set; }
        public DbSet<BookView> lBookView{ get; set; }
 

        // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        //{

        //}
        public ApplicationDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAGITEC-0099\\SQLEXPRESS;Database=CodingPractice;TrustServerCertificate=True;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasKey(x => x.CategoryId);
            modelBuilder.Entity<BookView>().HasNoKey();
            modelBuilder.Entity<BookView>().ToView("GetBooks");

            List<Category> lstCategories = new List<Category>();

            if (lstCategories != null)
            {
                lstCategories.Add(new Category { CategoryId = 1, Name = "category 1" });
                lstCategories.Add(new Category { CategoryId = 2, Name = "category 2" });
                lstCategories.Add(new Category { CategoryId = 3, Name = "category 3" });

                modelBuilder.Entity<Category>().HasData(lstCategories);
            }

            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailsConfig());



            modelBuilder.Entity<Fluent_Publisher>().HasKey(x => x.Publisher_ID); 

            modelBuilder.Entity<Fluent_AuthorBookMap>().HasKey(x => new { x.BookID, x.Author_id });
            modelBuilder.Entity<Fluent_AuthorBookMap>()
                .HasOne(x => x.Author)
                .WithMany(x => x.BookAuthorMap)
                .HasForeignKey(x => x.Author_id);

            modelBuilder.Entity<Fluent_AuthorBookMap>()
                .HasOne(x => x.Book)
                .WithMany(x => x.BookAuthorMap)
                .HasForeignKey(x => x.BookID);


            modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(10, 5);
            modelBuilder.Entity<AuthorBookMap>().HasKey(x => new { x.Author_id, x.BookID });

            List<Book> listOfBooks = new List<Book>();
            listOfBooks.Add(new Book() { BookID = 1, BookTitle = "Automic Habits", ISBN = "1234", Price = 10.10M, Publisher_ID = 1 });
            if (listOfBooks != null)
            {
                listOfBooks.Add(new Book()
                {
                    BookID = 2, BookTitle = "How To Write Journal", ISBN = "1234", Price = 20.10M, Publisher_ID = 2
                });
                modelBuilder.Entity<Book>().HasData(listOfBooks);
            }

            List<Publisher> lstPublisher = new List<Publisher>();
            if (lstPublisher != null)
            {
                lstPublisher.Add(new Publisher() { Publisher_ID = 1, Location = "Pune", Name = "ABC" });
                lstPublisher.Add(new Publisher() { Publisher_ID = 2, Location = "Ambe", Name = "MNO" });
                modelBuilder.Entity<Publisher>().HasData(lstPublisher);
            }
        }
    }
}
