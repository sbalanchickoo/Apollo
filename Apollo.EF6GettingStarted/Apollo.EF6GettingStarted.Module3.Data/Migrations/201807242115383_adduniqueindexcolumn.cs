namespace Apollo.EF6GettingStarted.Module3.Intro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduniqueindexcolumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clans", "ClanName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ninjas", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Equipments", "Name", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipments", "Name", c => c.String());
            AlterColumn("dbo.Ninjas", "Name", c => c.String());
            AlterColumn("dbo.Clans", "ClanName", c => c.String());
        }
    }
}
