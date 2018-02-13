namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Moviemodels", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Moviemodels", "Name", c => c.String());
        }
    }
}
