using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class BGGPlusPlusContext : DbContext
    {
        public BGGPlusPlusContext()
        {
        }

        public BGGPlusPlusContext(DbContextOptions<BGGPlusPlusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Designer> Designer { get; set; }
        public virtual DbSet<GameArtist> GameArtist { get; set; }
        public virtual DbSet<GameCategory> GameCategory { get; set; }
        public virtual DbSet<GameDesigner> GameDesigner { get; set; }
        public virtual DbSet<GamePublisher> GamePublisher { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LT-5CG5174CJK\\SQLEXPRESSBGG;Database=BGGPlusPlus;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("ARTIST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Artist1)
                    .HasColumnName("Artist")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category1)
                    .HasColumnName("Category")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Designer>(entity =>
            {
                entity.ToTable("DESIGNER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Designer1)
                    .HasColumnName("Designer")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GameArtist>(entity =>
            {
                entity.ToTable("GAME_ARTIST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

                entity.Property(e => e.GameId).HasColumnName("GameID");
            });

            modelBuilder.Entity<GameCategory>(entity =>
            {
                entity.ToTable("GAME_CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.GameId).HasColumnName("Game_ID");
            });

            modelBuilder.Entity<GameDesigner>(entity =>
            {
                entity.ToTable("GAME_DESIGNER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesignerId).HasColumnName("DesignerID");

                entity.Property(e => e.GameId).HasColumnName("GameID");
            });

            modelBuilder.Entity<GamePublisher>(entity =>
            {
                entity.ToTable("GAME_PUBLISHER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.ToTable("GAMES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeMax).HasColumnName("Age_Max");

                entity.Property(e => e.AgeMin).HasColumnName("Age_Min");

                entity.Property(e => e.GameDesc)
                    .HasColumnName("Game_Desc")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.GameName)
                    .HasColumnName("Game_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaxPlayers).HasColumnName("Max_Players");

                entity.Property(e => e.MinPlayers).HasColumnName("Min_Players");

                entity.Property(e => e.NumReviews).HasColumnName("Num_Reviews");

                entity.Property(e => e.PlaytimeMax).HasColumnName("Playtime_Max");

                entity.Property(e => e.PlaytimeMin).HasColumnName("Playtime_Min");

                entity.Property(e => e.SugPlayers).HasColumnName("Sug_Players");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("PUBLISHER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(127)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
