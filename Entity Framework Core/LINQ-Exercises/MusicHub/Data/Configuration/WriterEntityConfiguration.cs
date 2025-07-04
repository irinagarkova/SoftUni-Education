using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicHub.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static MusicHub.Data.EntityValidationConstants.Writer;
namespace MusicHub.Data.Configuration
{
    public class WriterEntityConfiguration :IEntityTypeConfiguration<Writer>

    {
        public void Configure(EntityTypeBuilder<Writer> entity)
        {
            entity.HasKey(w => w.Id);
            entity.Property(w => w.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(WriterNameMaxLength);
        }
    }
}
