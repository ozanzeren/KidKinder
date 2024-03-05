namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Parent_ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.ParentId)
                .ForeignKey("dbo.Parents", t => t.Parent_ParentId)
                .Index(t => t.Parent_ParentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        ImageUrl = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Parents", t => t.ParentId, cascadeDelete: true)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ParentId", "dbo.Parents");
            DropForeignKey("dbo.Parents", "Parent_ParentId", "dbo.Parents");
            DropIndex("dbo.Students", new[] { "ParentId" });
            DropIndex("dbo.Parents", new[] { "Parent_ParentId" });
            DropTable("dbo.Students");
            DropTable("dbo.Parents");
        }
    }
}
