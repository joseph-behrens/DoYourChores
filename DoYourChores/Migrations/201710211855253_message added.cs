namespace DoYourChores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messageadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CatBoxes", "Message", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CatBoxes", "Message");
        }
    }
}
