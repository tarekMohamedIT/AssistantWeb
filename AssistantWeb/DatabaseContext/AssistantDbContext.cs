using AssistantWeb.Models.Money;
using AssistantWeb.Models.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssistantWeb.DatabaseContext
{
    public class AssistantDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

    }
}