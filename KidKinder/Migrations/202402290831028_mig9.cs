namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Students", "ParentId");
            AddForeignKey("dbo.Students", "ParentId", "dbo.Parents", "ParentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ParentId", "dbo.Parents");
            DropIndex("dbo.Students", new[] { "ParentId" });
        }
    }
}
