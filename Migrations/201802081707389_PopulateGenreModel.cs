namespace bankacademy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreModel : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genremodels (Name) Values ('COMEDY')");
            Sql("INSERT INTO Genremodels (Name) Values ('DRAMA')");
            Sql("INSERT INTO Genremodels (Name) Values ('SCI-FI')");
            Sql("INSERT INTO Genremodels (Name) Values ('ADVENTURE')");
            Sql("INSERT INTO Genremodels (Name) Values ('DOCUMENTARY')");

        }
        
        public override void Down()
        {
        }
    }
}
