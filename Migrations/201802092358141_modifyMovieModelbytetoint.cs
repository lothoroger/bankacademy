namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyMovieModelbytetoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Moviemodels", "GenreId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Moviemodels", "GenreId", c => c.Byte(nullable: false));
        }
    }
}
