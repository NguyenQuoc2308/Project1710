namespace LoginSecure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdbagain : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        GioitinhNV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        MaSP = c.String(nullable: false, maxLength: 128),
                        TenSP = c.String(),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSP);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
            DropTable("dbo.NhanViens");
        }
    }
}
