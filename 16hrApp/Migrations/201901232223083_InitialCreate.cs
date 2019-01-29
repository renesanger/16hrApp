namespace _16hrApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ToDoListItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateBegin = c.String(),
                        DateEnd = c.String(),
                        Message = c.String(),
                        Day_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Days", t => t.Day_Id)
                .Index(t => t.Day_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ToDoListItems", new[] { "Day_Id" });
            DropForeignKey("dbo.ToDoListItems", "Day_Id", "dbo.Days");
            DropTable("dbo.ToDoListItems");
            DropTable("dbo.Days");
        }
    }
}
