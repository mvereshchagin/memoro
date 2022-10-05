using Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Providers.Repositories;

public sealed class DataContext : DbContext
{
    private readonly string _connectionString;
    public DataContext(string connectionString)
    {
        _connectionString = connectionString;
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Word> Words { get; set; } = null!;
    public DbSet<Association> Associations { get; set; } = null!;
    public DbSet<UserWord> UserWords { get; set; } = null!;
    public DbSet<WordAssociation> WordAssociations { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        // optionsBuilder.UseSqlite(_connectionString);
        
        //var version = ServerVersion.AutoDetect(_connectionString);
        //optionsBuilder.UseMySql(_connectionString, version);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Word>()
            .HasMany(c => c.Associations)
            .WithMany(s => s.Words)
            .UsingEntity<WordAssociation>(
                j => j
                    .HasOne(pt => pt.Association)
                    .WithMany(p => p.WordAssociations)
                    .HasForeignKey(pt => pt.AssociationId),
                j => j
                    .HasOne(pt => pt.Word)
                    .WithMany(t => t.WordAssociations)
                    .HasForeignKey(pt => pt.WordId),
                j =>
                {
                    j.HasOne(pt => pt.User)
                     .WithMany(t => t.WordAssociations)
                     .HasForeignKey(pt => pt.UserId);
                    j.HasKey(t => new { t.Id });
                    j.ToTable("WordAssociations");
                });

        modelBuilder
            .Entity<Word>()
            .HasMany(c => c.Users)
            .WithMany(s => s.Words)
            .UsingEntity<UserWord>(
                j => j
                    .HasOne(pt => pt.User)
                    .WithMany(p => p.UserWords)
                    .HasForeignKey(pt => pt.UserId),
                j => j
                    .HasOne(pt => pt.Word)
                    .WithMany(t => t.UserWords)
                    .HasForeignKey(pt => pt.WordId),
                j =>
                {
                    j.Property(pt => pt.Status).HasDefaultValue(WordStatus.New);
                    j.HasOne(pt => pt.WordAssociation)
                     .WithMany(t => t.UserWords)
                     .HasForeignKey(pt => pt.WordAssociationId);
                    j.HasKey(t => new { t.Id });
                    j.ToTable("UserWords");
                });
    }
}

