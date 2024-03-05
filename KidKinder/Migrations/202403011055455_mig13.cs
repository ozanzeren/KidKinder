namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig13 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ClassRooms", "BranchId");
            AddForeignKey("dbo.ClassRooms", "BranchId", "dbo.Branches", "BranchId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassRooms", "BranchId", "dbo.Branches");
            DropIndex("dbo.ClassRooms", new[] { "BranchId" });
        }
    }
}
