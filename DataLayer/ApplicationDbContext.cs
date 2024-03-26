using Microsoft.EntityFrameworkCore;
using TS_Tool.Models;

namespace TS_Tool.DataLayer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Betdetail>BetInformation { get; set; }
        public DbSet<SeamlessWalletError> SWErrorInfo { get; set; }

    }
}
