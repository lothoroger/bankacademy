namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Moviemodels", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Moviemodels", "Description");
        }
    }
}
