using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.ModelClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Data.FluentConfig
{
     public class FluentBookDetailsConfig:IEntityTypeConfiguration<Fluent_BookDetail>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookDetail> modelBuilder)
        { 
            modelBuilder.ToTable("FluentBookDetails");
            modelBuilder.Property(p => p.NumberOfChaoer).HasColumnName("Chapter");
            modelBuilder.HasKey(x => x.BookDetail_ID);

            modelBuilder
                  .HasOne(x => x.FluentBook)
                  .WithOne(x => x.BookDetail)
                  .HasForeignKey<Fluent_BookDetail>(x => x.BookID);

        }
    }
}
