namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClientTypes : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO ClientTypes (Name,MemberExpire,SetupDate,InitialAmt ) VALUES ('INVESTOR', 1,'02/14/2000',2521792.12)");
            Sql("INSERT INTO ClientTypes (Name,MemberExpire,SetupDate,InitialAmt ) VALUES ('LOANER', 0,'11/11/2011',5212432.19)");
            Sql("INSERT INTO ClientTypes (Name,MemberExpire,SetupDate,InitialAmt ) VALUES ('BUSINESS', 0,'04/24/2001',97521312.64)");
            Sql("INSERT INTO ClientTypes (Name,MemberExpire,SetupDate,InitialAmt ) VALUES ('VETERAN', 1,'09/18/2007',89141792.21)");
            Sql("INSERT INTO ClientTypes (Name,MemberExpire,SetupDate,InitialAmt ) VALUES ('ENTERTAINMENT', 1,'06/11/2008',769198.74)");
            Sql("INSERT INTO ClientTypes (Name,MemberExpire,SetupDate,InitialAmt ) VALUES ('EDUCATION', 0,'01/01/2002',78792.42)");












        }

        public override void Down()
        {
        }
    }
}
