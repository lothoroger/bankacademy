namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customermodels", "MembershipTypeID", c => c.Byte(nullable: false));
            AddColumn("dbo.Customermodels", "MembershipType_Id", c => c.Int());
            CreateIndex("dbo.Customermodels", "MembershipType_Id");
            AddForeignKey("dbo.Customermodels", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customermodels", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customermodels", new[] { "MembershipType_Id" });
            DropColumn("dbo.Customermodels", "MembershipType_Id");
            DropColumn("dbo.Customermodels", "MembershipTypeID");
            DropTable("dbo.MembershipTypes");
        }
    }
}
