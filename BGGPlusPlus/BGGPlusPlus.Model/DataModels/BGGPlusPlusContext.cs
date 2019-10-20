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
        public virtual DbSet<GameMechanic> GameMechanic { get; set; }
        public virtual DbSet<GamePublisher> GamePublisher { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Mechanic> Mechanic { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("ARTIST");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Artist1)
                    .IsRequired()
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
                    .IsRequired()
                    .HasColumnName("Category")
                    .HasMaxLength(63)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Designer>(entity =>
            {
                entity.ToTable("DESIGNER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Designer1)
                    .IsRequired()
                    .HasColumnName("Designer")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GameArtist>(entity =>
            {
                entity.ToTable("GAME_ARTIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtistId).HasColumnName("ArtistID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.GameArtist)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_ARTI__Artis__70DDC3D8");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameArtist)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_ARTI__GameI__6FE99F9F");
            });

            modelBuilder.Entity<GameCategory>(entity =>
            {
                entity.ToTable("GAME_CATEGORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.GameCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_CATE__Categ__72C60C4A");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameCategory)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_CATE__GameI__71D1E811");
            });

            modelBuilder.Entity<GameDesigner>(entity =>
            {
                entity.ToTable("GAME_DESIGNER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DesignerId).HasColumnName("DesignerID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.HasOne(d => d.Designer)
                    .WithMany(p => p.GameDesigner)
                    .HasForeignKey(d => d.DesignerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_DESI__Desig__74AE54BC");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameDesigner)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_DESI__GameI__73BA3083");
            });

            modelBuilder.Entity<GameMechanic>(entity =>
            {
                entity.ToTable("GAME_MECHANIC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.MechanicId).HasColumnName("MechanicID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameMechanic)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_MECH__GameI__778AC167");

                entity.HasOne(d => d.Mechanic)
                    .WithMany(p => p.GameMechanic)
                    .HasForeignKey(d => d.MechanicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_MECH__Mecha__787EE5A0");
            });

            modelBuilder.Entity<GamePublisher>(entity =>
            {
                entity.ToTable("GAME_PUBLISHER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GamePublisher)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_PUBL__GameI__75A278F5");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.GamePublisher)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GAME_PUBL__Publi__76969D2E");
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
                    .IsRequired()
                    .HasColumnName("Game_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaxPlayers).HasColumnName("Max_Players");

                entity.Property(e => e.MinPlayers).HasColumnName("Min_Players");

                entity.Property(e => e.NumReviews).HasColumnName("Num_Reviews");

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("Picture_URL")
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.PlaytimeMax).HasColumnName("Playtime_Max");

                entity.Property(e => e.PlaytimeMin).HasColumnName("Playtime_Min");

                entity.Property(e => e.SugPlayers).HasColumnName("Sug_Players");
            });

            modelBuilder.Entity<Mechanic>(entity =>
            {
                entity.ToTable("MECHANIC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Mechanic1)
                    .IsRequired()
                    .HasColumnName("Mechanic")
                    .HasMaxLength(63)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("PUBLISHER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Publisher1)
                    .IsRequired()
                    .HasColumnName("Publisher")
                    .HasMaxLength(127)
                    .IsUnicode(false);
            });
        }
    }
}
