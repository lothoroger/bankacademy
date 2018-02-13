namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WithdrawnDate = c.DateTime(),
                        WithdrawnAmt = c.Decimal(precision: 18, scale: 2),
                        DepositDate = c.DateTime(),
                        DepositAmt = c.Decimal(precision: 18, scale: 2),
                        TransactionDesc = c.String(),
                        ClientTypeId = c.Byte(nullable: false),
                        ClientType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientTypes", t => t.ClientType_Id)
                .Index(t => t.ClientType_Id);
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MemberExpire = c.Boolean(),
                        SetupDate = c.DateTime(),
                        InitialAmt = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "ClientType_Id", "dbo.ClientTypes");
            DropIndex("dbo.Clients", new[] { "ClientType_Id" });
            DropTable("dbo.ClientTypes");
            DropTable("dbo.Clients");
        }
    }
}
