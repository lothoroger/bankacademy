namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClients : DbMigration
    {
        public override void Up()
        {
           // Sql("SET INDENTITY_INSERT Clients OFF");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Apple Ltd.', '10/20/2005',45320.23, '02/14/2004','521792.18', 'Loan to Due Date',2)");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Facebook Corp.', '11/21/2015',7320.53, '01/23/2014','65195.38', 'Initial Cap',1)");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Lothor Ent.', '12/11/2017',320.78, '12/09/2011','87875412.11', 'Venture Risk',3)");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Google Inc.', '08/02/2000',7665.11, '10/11/2018','3439845.67', 'Higher Ed Program',6)");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Linked Pty.', '03/13/2006',9821.21, '06/07/2016','92494.43', 'Staple Center Venue',5)");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Uber Llc.', '05/17/2011',71253.99, '08/17/2013','58613.96', 'Military Program',4)");
            Sql("INSERT INTO Clients (Name, WithdrawnDate, WithdrawnAmt, DepositDate, DepositAmt, TransactionDesc, ClientTypeId) VALUES ('Amazon Ent.', '07/30/2012',81343.56, '07/04/2000','43256.82', 'Superbowl Ads',5)");








        }

        public override void Down()
        {
        }
    }
}
