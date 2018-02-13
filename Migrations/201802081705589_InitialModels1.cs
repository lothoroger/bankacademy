namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moviemodels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(),
                        NumberInStock = c.Byte(nullable: false),
                        GenreId = c.Byte(nullable: false),
                        Genrelist_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genremodels", t => t.Genrelist_Id)
                .Index(t => t.Genrelist_Id);
            
            CreateTable(
                "dbo.Genremodels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Moviemodels", "Genrelist_Id", "dbo.Genremodels");
            DropIndex("dbo.Moviemodels", new[] { "Genrelist_Id" });
            DropTable("dbo.Genremodels");
            DropTable("dbo.Moviemodels");
        }
    }
}
