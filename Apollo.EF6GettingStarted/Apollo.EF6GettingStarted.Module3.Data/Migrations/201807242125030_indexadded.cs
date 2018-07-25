namespace Apollo.EF6GettingStarted.Module3.Intro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class indexadded : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Clans", "ClanName", unique: true);
            CreateIndex("dbo.Ninjas", "Name", unique: true, name: "IX_ClanName");
            CreateIndex("dbo.Equipments", "Name", unique: true, name: "IX_EquipmentName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Equipments", "IX_EquipmentName");
            DropIndex("dbo.Ninjas", "IX_ClanName");
            DropIndex("dbo.Clans", new[] { "ClanName" });
        }
    }
}
