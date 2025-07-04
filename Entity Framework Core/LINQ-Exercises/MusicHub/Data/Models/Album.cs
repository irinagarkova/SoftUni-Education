using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }
        public decimal Price =>
            Songs.Sum(s => s.Price);

        public int? ProducerId { get; set; }
        public Producer? Producer { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
            = new HashSet<Song>();
    }

}
