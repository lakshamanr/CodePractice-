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
    public class FluentAuthorConfig :IEntityTypeConfiguration<Fluent_Author>
    {
        public void Configure(EntityTypeBuilder<Fluent_Author> modelBuilder)
        {
            modelBuilder.Ignore(x => x.FullName);
            modelBuilder.HasKey(x => x.Author_id);
            modelBuilder.Property(x => x.FirstName)
                        .IsRequired()
                        .HasMaxLength(50);
        }
    }
}
