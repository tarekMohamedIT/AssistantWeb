using AssistantWeb.Models.Money;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssistantWeb.DatabaseContext
{
    public class AssistantDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}