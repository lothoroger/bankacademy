namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customermodels", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customermodels", "Birthdate");
        }
    }
}
