namespace Apollo.EFGettingStarted.EFRepo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClanName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ClanName, unique: true);
            
            CreateTable(
                "dbo.Ninja",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        ServedInWar = c.Boolean(nullable: false),
                        ClanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clan", t => t.ClanId, cascadeDelete: true)
                .Index(t => t.Name, unique: true, name: "IX_ClanName")
                .Index(t => t.ClanId);
            
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        Type = c.Int(nullable: false),
                        Ninja_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ninja", t => t.Ninja_Id, cascadeDelete: true)
                .Index(t => t.Name, unique: true, name: "IX_EquipmentName")
                .Index(t => t.Ninja_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipment", "Ninja_Id", "dbo.Ninja");
            DropForeignKey("dbo.Ninja", "ClanId", "dbo.Clan");
            DropIndex("dbo.Equipment", new[] { "Ninja_Id" });
            DropIndex("dbo.Equipment", "IX_EquipmentName");
            DropIndex("dbo.Ninja", new[] { "ClanId" });
            DropIndex("dbo.Ninja", "IX_ClanName");
            DropIndex("dbo.Clan", new[] { "ClanName" });
            DropTable("dbo.Equipment");
            DropTable("dbo.Ninja");
            DropTable("dbo.Clan");
        }
    }
}
