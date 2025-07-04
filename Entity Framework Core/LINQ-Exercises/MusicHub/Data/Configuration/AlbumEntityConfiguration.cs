using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MusicHub.Data.EntityValidationConstants.Album;
namespace MusicHub.Data.Configuration
{
    public class AlbumEntityConfiguration
    {
        public void Configure(EntityTypeBuilder<Album> entity)
        {
            entity.HasKey(a => a.Id);

            entity.Property(a => a.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(AlbumNameMaxLength);


            entity.HasOne(a => a.Producer)
              .WithMany(p => p.Albums)
              .HasForeignKey(a => a.ProducerId);
        }
    }
}
