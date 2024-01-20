﻿// <auto-generated />
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthor_id")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookID")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthor_id", "BooksBookID");

                    b.HasIndex("BooksBookID");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("DataModel.ModelClass.Author", b =>
                {
                    b.Property<int>("Author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_id"), 1L, 1);

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DataModel.ModelClass.AuthorBookMap", b =>
                {
                    b.Property<int>("Author_id")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.HasKey("Author_id", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("AuthorBookMap");
                });

            modelBuilder.Entity("DataModel.ModelClass.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"), 1L, 1);

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<int>("Publisher_ID")
                        .HasColumnType("int");

                    b.HasKey("BookID");

                    b.HasIndex("Publisher_ID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookID = 1,
                            BookTitle = "Automic Habits",
                            ISBN = "1234",
                            Price = 10.10m,
                            Publisher_ID = 1
                        },
                        new
                        {
                            BookID = 2,
                            BookTitle = "How To Write Journal",
                            ISBN = "1234",
                            Price = 20.10m,
                            Publisher_ID = 2
                        });
                });

            modelBuilder.Entity("DataModel.ModelClass.BookDetail", b =>
                {
                    b.Property<int>("BookDetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<string>("NumberOfChaoer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfPager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookDetail_ID");

                    b.HasIndex("BookID")
                        .IsUnique();

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("DataModel.ModelClass.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "category 1"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "category 2"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "category 3"
                        });
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Author", b =>
                {
                    b.Property<int>("Author_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_id"), 1L, 1);

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_id");

                    b.ToTable("FluentAuthor");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_AuthorBookMap", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("Author_id")
                        .HasColumnType("int");

                    b.HasKey("BookID", "Author_id");

                    b.HasIndex("Author_id");

                    b.ToTable("FluentAuthorBookMap");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"), 1L, 1);

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Publisher_ID")
                        .HasColumnType("int");

                    b.HasKey("BookID");

                    b.HasIndex("Publisher_ID");

                    b.ToTable("FluentBooks");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_BookDetail", b =>
                {
                    b.Property<int>("BookDetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<string>("NumberOfChaoer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Chapter");

                    b.Property<string>("NumberOfPager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookDetail_ID");

                    b.HasIndex("BookID")
                        .IsUnique();

                    b.ToTable("FluentBookDetails", (string)null);
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_ID"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_ID");

                    b.ToTable("FluentPublishers");
                });

            modelBuilder.Entity("DataModel.ModelClass.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"), 1L, 1);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("DataModel.ModelClass.Publisher", b =>
                {
                    b.Property<int>("Publisher_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_ID"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_ID");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Publisher_ID = 1,
                            Location = "Pune",
                            Name = "ABC"
                        },
                        new
                        {
                            Publisher_ID = 2,
                            Location = "Ambe",
                            Name = "MNO"
                        });
                });

            modelBuilder.Entity("DataModel.ModelClass.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryI_D")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryI_D"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubCategoryI_D");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("DataModel.ModelClass.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.ModelClass.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.ModelClass.AuthorBookMap", b =>
                {
                    b.HasOne("DataModel.ModelClass.Author", "Author")
                        .WithMany()
                        .HasForeignKey("Author_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.ModelClass.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DataModel.ModelClass.Book", b =>
                {
                    b.HasOne("DataModel.ModelClass.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("DataModel.ModelClass.BookDetail", b =>
                {
                    b.HasOne("DataModel.ModelClass.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("DataModel.ModelClass.BookDetail", "BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_AuthorBookMap", b =>
                {
                    b.HasOne("DataModel.ModelClass.Fluent_Author", "Author")
                        .WithMany("BookAuthorMap")
                        .HasForeignKey("Author_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModel.ModelClass.Fluent_Book", "Book")
                        .WithMany("BookAuthorMap")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Book", b =>
                {
                    b.HasOne("DataModel.ModelClass.Fluent_Publisher", "FluentPublisher")
                        .WithMany("FluentBooks")
                        .HasForeignKey("Publisher_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FluentPublisher");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_BookDetail", b =>
                {
                    b.HasOne("DataModel.ModelClass.Fluent_Book", "FluentBook")
                        .WithOne("BookDetail")
                        .HasForeignKey("DataModel.ModelClass.Fluent_BookDetail", "BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FluentBook");
                });

            modelBuilder.Entity("DataModel.ModelClass.Book", b =>
                {
                    b.Navigation("BookDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Author", b =>
                {
                    b.Navigation("BookAuthorMap");
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Book", b =>
                {
                    b.Navigation("BookAuthorMap");

                    b.Navigation("BookDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("DataModel.ModelClass.Fluent_Publisher", b =>
                {
                    b.Navigation("FluentBooks");
                });

            modelBuilder.Entity("DataModel.ModelClass.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
