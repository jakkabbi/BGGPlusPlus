using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BGGPlusPlus.Model.Models
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

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<GameCategory> GameCategory { get; set; }
        public virtual DbSet<Games> Games { get; set; }

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
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category1).HasColumnName("Category");
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
