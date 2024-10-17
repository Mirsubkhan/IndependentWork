using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<WalletItem> WalletItems { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<CryptoAsset> CryptoAssets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
        }

    }
}
