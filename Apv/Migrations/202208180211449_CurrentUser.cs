namespace Apv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurrentUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trans", "CreaterId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Trans", "CreaterId");
            AddForeignKey("dbo.Trans", "CreaterId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trans", "CreaterId", "dbo.AspNetUsers");
            DropIndex("dbo.Trans", new[] { "CreaterId" });
            DropColumn("dbo.Trans", "CreaterId");
        }
    }
}
