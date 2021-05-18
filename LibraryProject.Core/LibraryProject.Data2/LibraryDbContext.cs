namespace LibraryProject.Data
{
    using System.Configuration;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.SqlServer;

    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            : base()
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ReturnsLog> Returns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = LibraryProjectDbo; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnsLog>()
                .HasKey(t => t.LogId);

            modelBuilder.Entity<ReturnsLog>()
            .HasOne(p => p.Book)
            .WithMany(b => b.ReturnsLogs)
            .HasForeignKey(p => p.BookBarcode)
            .HasPrincipalKey(b => b.Barcode);

            modelBuilder.Entity<ReturnsLog>()
            .HasOne(p => p.User)
            .WithMany(b => b.ReturnsLogs)
            .HasForeignKey(p => p.UserEmail)
            .HasPrincipalKey(b => b.Email)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReturnsLog>()
            .Property(b => b.LogId)
            .ValueGeneratedOnAdd();
        }
    }
}