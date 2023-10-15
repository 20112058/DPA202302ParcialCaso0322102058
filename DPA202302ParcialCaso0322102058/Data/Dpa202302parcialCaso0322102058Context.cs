using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0322102058.Data;

public partial class Dpa202302parcialCaso0322102058Context : DbContext
{
    public Dpa202302parcialCaso0322102058Context()
    {
    }

    public Dpa202302parcialCaso0322102058Context(DbContextOptions<Dpa202302parcialCaso0322102058Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Territory> Territory { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=DPA202302ParcialCaso0322102058;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Territory>(entity =>
        {
            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
