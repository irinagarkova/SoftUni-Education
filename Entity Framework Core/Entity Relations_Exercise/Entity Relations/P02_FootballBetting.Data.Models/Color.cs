using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P02_FootballBetting.Common.EntityValidationConstants.Color;

namespace P02_FootballBetting.Data.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [Required]
        [MaxLength(ColorNameMaxLength)]
        public string Name { get; set; }

        [InverseProperty(nameof(Team.PrimaryKitColor))] // слага се като е many to many 
        public virtual ICollection<Team> PrimaryKitTeams { get; set; }
        = new HashSet<Team>();


        [InverseProperty(nameof(Team.SecondaryKitColor))] // слага се като е many to many 
        public virtual ICollection<Team> SecondaryKitTeams { get; set; }
        = new HashSet<Team>();
    }
}
