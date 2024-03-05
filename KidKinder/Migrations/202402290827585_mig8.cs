namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parents", "Parent_ParentId", "dbo.Parents");
            DropForeignKey("dbo.Students", "ParentId", "dbo.Parents");
            DropIndex("dbo.Parents", new[] { "Parent_ParentId" });
            DropIndex("dbo.Students", new[] { "ParentId" });
            DropColumn("dbo.Parents", "Parent_ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Parents", "Parent_ParentId", c => c.Int());
            CreateIndex("dbo.Students", "ParentId");
            CreateIndex("dbo.Parents", "Parent_ParentId");
            AddForeignKey("dbo.Students", "ParentId", "dbo.Parents", "ParentId", cascadeDelete: true);
            AddForeignKey("dbo.Parents", "Parent_ParentId", "dbo.Parents", "ParentId");
        }
    }
}
