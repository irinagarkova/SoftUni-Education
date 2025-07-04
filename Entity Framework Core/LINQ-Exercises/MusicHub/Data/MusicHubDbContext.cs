namespace MusicHub.Data
{
    using Microsoft.EntityFrameworkCore;
    using global::MusicHub.Data.Configuration;
    using global::MusicHub.Data.Models;
    using static Configuration.ConnectionConfiguration;
   // using Microsoft.EntityFrameworkCore.Infrastructure;
   //  using System;

    public class MusicHubDbContext : DbContext
    {
        public MusicHubDbContext()
        {
        }

        public MusicHubDbContext(DbContextOptions options)
            : base(options)
        { }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<SongPerformer> SongPerformers { get; set; }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Song>(e => e.HasKey(s => s.Id));
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Data.Configuration.SongEntityConfiguration).Assembly);
        }
    }
}
