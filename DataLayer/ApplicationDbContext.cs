using Microsoft.EntityFrameworkCore;
using TS_Tool.Models;

namespace TS_Tool.DataLayer
{
    public class FirstDbContext : DbContext
    {
        public FirstDbContext(DbContextOptions<FirstDbContext> options) : base(options)
        {
        }

        public DbSet<Betdetail> BetInformation { get; set; }
        // Add other DbSet properties for tables in the first database

    }
    public class SecondDbContext : DbContext
    {
        public SecondDbContext(DbContextOptions<SecondDbContext> options) : base(options)
        {
        }
        public DbSet<SeamlessWalletError> SWErrorInfo { get; set; }

    }
    public class ThirdDbContext : DbContext
    {
        public ThirdDbContext(DbContextOptions<ThirdDbContext> options) : base(options)
        {
        }
        public DbSet<Betdetail> OSBetInformation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Betdetail>().HasNoKey();
        }

        // Add other DbSet properties for tables in the second database
    }
    public class YY2GameProviderDbContext : DbContext
    {
        public YY2GameProviderDbContext(DbContextOptions<YY2GameProviderDbContext> options) : base(options)
        {
        }

        public DbSet<Betdetail> BetInformation { get; set; }
        // Add other DbSet properties for tables in the first database

    }
    public class YY2RecordDbContext : DbContext
    {
        public YY2RecordDbContext(DbContextOptions<YY2RecordDbContext> options) : base(options)
        {
        }
        public DbSet<SeamlessWalletError> SWErrorInfo { get; set; }

    }
    public class YY3GameProviderDbContext : DbContext
    {
        public YY3GameProviderDbContext(DbContextOptions<YY3GameProviderDbContext> options) : base(options)
        {
        }

        public DbSet<Betdetail> BetInformation { get; set; }
        // Add other DbSet properties for tables in the first database

    }
    public class YY3RecordDbContext : DbContext
    {
        public YY3RecordDbContext(DbContextOptions<YY3RecordDbContext> options) : base(options)
        {
        }
        public DbSet<SeamlessWalletError> SWErrorInfo { get; set; }

    }
    public class YY4GameProviderDbContext : DbContext
    {
        public YY4GameProviderDbContext(DbContextOptions<YY4GameProviderDbContext> options) : base(options)
        {
        }

        public DbSet<Betdetail> BetInformation { get; set; }
        // Add other DbSet properties for tables in the first database

    }
    public class YY4RecordDbContext : DbContext
    {
        public YY4RecordDbContext(DbContextOptions<YY4RecordDbContext> options) : base(options)
        {
        }
        public DbSet<SeamlessWalletError> SWErrorInfo { get; set; }

    }
    public class YY5GameProviderDbContext : DbContext
    {
        public YY5GameProviderDbContext(DbContextOptions<YY5GameProviderDbContext> options) : base(options)
        {
        }

        public DbSet<Betdetail> BetInformation { get; set; }
        // Add other DbSet properties for tables in the first database

    }
    public class YY5RecordDbContext : DbContext
    {
        public YY5RecordDbContext(DbContextOptions<YY5RecordDbContext> options) : base(options)
        {
        }
        public DbSet<SeamlessWalletError> SWErrorInfo { get; set; }

    }

}
