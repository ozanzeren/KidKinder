namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClassRooms", "Branch_BranchId", "dbo.Branches");
            DropIndex("dbo.ClassRooms", new[] { "Branch_BranchId" });
            DropColumn("dbo.ClassRooms", "Branch_BranchId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClassRooms", "Branch_BranchId", c => c.Int());
            CreateIndex("dbo.ClassRooms", "Branch_BranchId");
            AddForeignKey("dbo.ClassRooms", "Branch_BranchId", "dbo.Branches", "BranchId");
        }
    }
}
