using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DataModel.ModelClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Data.FluentConfig
{
    public class FluentBookConfig:IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
        { 
            modelBuilder.HasKey(x => x.BookID);
            modelBuilder.Ignore(x => x.PriceRange);
            modelBuilder.Property(x => x.BookTitle).IsRequired().HasMaxLength(50);
            modelBuilder
                .HasOne(publisher => publisher.FluentPublisher)
                .WithMany(books => books.FluentBooks)
                .HasForeignKey(FK => FK.Publisher_ID);

        }
    }
}
