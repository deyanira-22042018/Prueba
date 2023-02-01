using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Fibrofoto.Models;

public partial class FibrofotoContext : DbContext
{
    public FibrofotoContext()
    {
    }

    public FibrofotoContext(DbContextOptions<FibrofotoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Retablo> Retablos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Deyanira;Initial Catalog=Fibrofoto;Integrated Security=True; Encrypt = false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__D59466428E37E492");

            entity.ToTable("Cliente");

            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NameCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Retablo>(entity =>
        {
            entity.HasKey(e => e.IdRetablos).HasName("PK__Retablos__F9F67BDE5E596217");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("price");
            entity.Property(e => e.Tamaño)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tamaño");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
