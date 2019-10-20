﻿using System;
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
                optionsBuilder.UseSqlServer("Data Source=bggplusplus.cmfbfjhabcjs.us-east-1.rds.amazonaws.com,1433;Database=BGGPlusPlus;User Id=admin; Password=8cMLbYfOVtGFSVrVn9wb");
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

                entity.Property(e => e.Category1).HasColumnName("Category");
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

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.GameArtist)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__GAME_ARTI__Artis__46E78A0C");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameArtist)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__GAME_ARTI__GameI__45F365D3");
            });

            modelBuilder.Entity<GameCategory>(entity =>
            {
                entity.ToTable("GAME_CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.GameCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__GAME_CATE__Categ__5070F446");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameCategory)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__GAME_CATE__GameI__49C3F6B7");
            });

            modelBuilder.Entity<GameDesigner>(entity =>
            {
                entity.ToTable("GAME_DESIGNER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesignerId).HasColumnName("DesignerID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.HasOne(d => d.Designer)
                    .WithMany(p => p.GameDesigner)
                    .HasForeignKey(d => d.DesignerId)
                    .HasConstraintName("FK__GAME_DESI__Desig__52593CB8");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameDesigner)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__GAME_DESI__GameI__5165187F");
            });

            modelBuilder.Entity<GamePublisher>(entity =>
            {
                entity.ToTable("GAME_PUBLISHER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GamePublisher)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__GAME_PUBL__GameI__534D60F1");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.GamePublisher)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK__GAME_PUBL__Publi__5441852A");
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
