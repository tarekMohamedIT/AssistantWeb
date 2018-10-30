namespace AssistantWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeItemsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        quantity = c.Single(nullable: false),
                        PricePerUnit = c.Single(nullable: false),
                        DateAdded = c.DateTime(),
                        WalletId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Wallets", t => t.WalletId, cascadeDelete: true)
                .Index(t => t.WalletId);
            
            CreateTable(
                "dbo.Wallets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        TotalMoney = c.Single(nullable: false),
                        RemainingMoney = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "WalletId", "dbo.Wallets");
            DropIndex("dbo.Items", new[] { "WalletId" });
            DropTable("dbo.Wallets");
            DropTable("dbo.Items");
        }
    }
}
