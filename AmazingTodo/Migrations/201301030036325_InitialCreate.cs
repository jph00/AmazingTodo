namespace AmazingTodo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        TodoItemId = c.Int(nullable: false, identity: true),
                        Todo = c.String(),
                        Priority = c.Byte(nullable: false),
                        DueDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.TodoItemId);
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoItems");
        }
    }
}
