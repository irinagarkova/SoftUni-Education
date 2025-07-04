using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicHub.Data.Models;
using static MusicHub.Data.EntityValidationConstants.Song;

namespace MusicHub.Data.Configuration
{
    public class SongEntityConfiguration : IEntityTypeConfiguration<Song>

    {
        public void Configure(EntityTypeBuilder<Song> entity)
        {
            entity.HasKey(s => s.Id);
            entity.Property(s =>s.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(SongNameMaxLength);

            //Relations
            //One to Many -> HasOne() -> WithMany() -> HasForeignKey()
            //One to One -> HasOne() -> WithOne() -> HasForeignKey()
            //Many to Many -> 2x [HasOne() -> WithMany() -> HasForeignKey()]

            //----------------------------------------------------------------------------------------
            //ONE TO MANY !
            //Describe them from the ONE side, is not needed to describe the relations form both sides


            entity.HasOne(s => s.Album)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.AlbumId);


            entity.HasOne(s => s.Writer)
                .WithMany(w => w.Songs)
                .HasForeignKey(s => s.WriterId);


        }


       
    }
}
