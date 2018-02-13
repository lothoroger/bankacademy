namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Moviemodels", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Moviemodels", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Moviemodels", "NumberAvailable");
            DropColumn("dbo.Moviemodels", "DateAdded");
        }
    }
}
