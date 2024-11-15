using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldProject.Models
{
    public partial class GameDatabaseContext : DbContext
    {
        public GameDatabaseContext()
        {
        }

        public GameDatabaseContext(DbContextOptions<GameDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; } = null!;
        public virtual DbSet<Equipment> Equipments { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Monster> Monsters { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GameDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.HasMany(d => d.Players)
                    .WithMany(p => p.Abilities)
                    .UsingEntity<Dictionary<string, object>>(
                        "PlayerAbility",
                        l => l.HasOne<Player>().WithMany().HasForeignKey("PlayersId"),
                        r => r.HasOne<Ability>().WithMany().HasForeignKey("AbilitiesId"),
                        j =>
                        {
                            j.HasKey("AbilitiesId", "PlayersId");

                            j.ToTable("PlayerAbilities");

                            j.HasIndex(new[] { "PlayersId" }, "IX_PlayerAbilities_PlayersId");
                        });
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasIndex(e => e.ArmorId, "IX_Equipments_ArmorId");

                entity.HasIndex(e => e.WeaponId, "IX_Equipments_WeaponId");

                entity.HasOne(d => d.Armor)
                    .WithMany(p => p.EquipmentArmors)
                    .HasForeignKey(d => d.ArmorId);

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.EquipmentWeapons)
                    .HasForeignKey(d => d.WeaponId);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.EquipmentId, "IX_Players_EquipmentId");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.EquipmentId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
