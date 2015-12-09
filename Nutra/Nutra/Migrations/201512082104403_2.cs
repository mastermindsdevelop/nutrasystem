namespace Nutra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.iletisims", "goruldu", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.iletisims", "goruldu");
        }
    }
}
