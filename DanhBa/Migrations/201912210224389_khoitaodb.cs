namespace DanhBa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitaodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhBaQLs",
                c => new
                    {
                        maDB = c.String(nullable: false, maxLength: 128),
                        tenDB = c.String(),
                        diachi = c.String(),
                        email = c.String(),
                        sdt = c.String(),
                        manhomDB = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maDB)
                .ForeignKey("dbo.NhomDBs", t => t.manhomDB)
                .Index(t => t.manhomDB);
            
            CreateTable(
                "dbo.NhomDBs",
                c => new
                    {
                        manhomDB = c.String(nullable: false, maxLength: 128),
                        tennhomDB = c.String(),
                    })
                .PrimaryKey(t => t.manhomDB);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhBaQLs", "manhomDB", "dbo.NhomDBs");
            DropIndex("dbo.DanhBaQLs", new[] { "manhomDB" });
            DropTable("dbo.NhomDBs");
            DropTable("dbo.DanhBaQLs");
        }
    }
}
