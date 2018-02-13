namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applyAnnotationtoCustomerModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customermodels", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customermodels", "Name", c => c.String());
        }
    }
}
