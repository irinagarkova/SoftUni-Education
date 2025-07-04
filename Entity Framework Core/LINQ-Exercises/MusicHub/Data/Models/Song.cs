﻿using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public TimeSpan Duration { get; set; }

        public DateTime CreatedOn { get; set; }

        public Genre Genre { get; set; }

        public decimal Price { get; set; }
        public int? AlbumId { get; set; }
        public virtual Album? Album { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; } = null!;

        public virtual ICollection<SongPerformer> SongPerformers { get; set; } 
            = new HashSet<SongPerformer>();
    }

}
