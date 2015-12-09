namespace Nutra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.iletisims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        adsoyad = c.String(),
                        eposta = c.String(),
                        konu = c.String(),
                        tel = c.String(),
                        mesaj = c.String(),
                        nereden_Id = c.Int(),
                        sube_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.neredens", t => t.nereden_Id)
                .ForeignKey("dbo.subes", t => t.sube_Id)
                .Index(t => t.nereden_Id)
                .Index(t => t.sube_Id);
            
            CreateTable(
                "dbo.neredens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        alan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.subes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.iletisims", "sube_Id", "dbo.subes");
            DropForeignKey("dbo.iletisims", "nereden_Id", "dbo.neredens");
            DropIndex("dbo.iletisims", new[] { "sube_Id" });
            DropIndex("dbo.iletisims", new[] { "nereden_Id" });
            DropTable("dbo.logins");
            DropTable("dbo.subes");
            DropTable("dbo.neredens");
            DropTable("dbo.iletisims");
        }
    }
}
