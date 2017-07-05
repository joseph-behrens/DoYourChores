namespace MyNaggingMom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCatBox : DbMigration
    {
        public override void Up()
        {
            var query = "INSERT INTO CatBoxes (LastTimeCleaned, TimeToCleanAgain) VALUES ('" + DateTime.Now + "', '" + DateTime.Now.AddDays(1) + "')";
            Sql(query);
        }
        
        public override void Down()
        {
        }
    }
}
