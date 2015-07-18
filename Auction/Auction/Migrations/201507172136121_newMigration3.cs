namespace Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BidAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Item_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .Index(t => t.Item_Id);
            
            DropColumn("dbo.Items", "NumberOfBids");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "NumberOfBids", c => c.Int(nullable: false));
            DropForeignKey("dbo.Bids", "Item_Id", "dbo.Items");
            DropIndex("dbo.Bids", new[] { "Item_Id" });
            DropTable("dbo.Bids");
        }
    }
}
