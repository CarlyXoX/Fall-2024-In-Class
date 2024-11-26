protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // One-to-many: Room -> Monsters
    modelBuilder.Entity<Monster>()
        .HasOne(m => m.Room)
        .WithMany(r => r.Monsters)
        .HasForeignKey(m => m.RoomId)
        .OnDelete(DeleteBehavior.Cascade);

    // Many-to-many: Monsters <-> Items
    modelBuilder.Entity<Monster>()
        .HasMany(m => m.Items)
        .WithMany(i => i.Monsters)
        .UsingEntity(j => j.ToTable("MonsterItems"));
}
