namespace DoYourChores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenericChores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DueDate = c.DateTime(nullable: false),
                        LastCompleted = c.DateTime(nullable: false),
                        CompletedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chores");
        }
    }
}
