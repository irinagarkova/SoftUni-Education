﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static P02_FootballBetting.Common.EntityValidationConstants.Game;

namespace P02_FootballBetting.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public decimal HomeTeamBetRate { get; set; }
        public decimal AwayTeamBetRate { get; set; }
        public decimal DrawBetRate { get; set; }

       
        public DateTime DateTime { get; set; }

        [MaxLength(GameResultMaxLength)]
        public string? Result { get; set; }


        [ForeignKey(nameof(HomeTeam))]
        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; } = null!;



        [ForeignKey(nameof(AwayTeam))]
        public int AwayTeamId{ get; set; }
        public virtual Team AwayTeam { get; set; } = null!;

        public ICollection<PlayerStatistic> PlayersStatistics { get; set; }
        = new HashSet<PlayerStatistic>();

        public ICollection<Bet> Bets { get; set; }
        = new HashSet<Bet>();


    }
}
