namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig14 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ParentId", "dbo.Parents");
            DropIndex("dbo.Students", new[] { "ParentId" });
            AddColumn("dbo.Students", "Veli1", c => c.String());
            AddColumn("dbo.Students", "Veli2", c => c.String());
            AddColumn("dbo.Students", "Veli3", c => c.String());
            DropColumn("dbo.Students", "ParentId");
            DropTable("dbo.Parents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.ParentId);
            
            AddColumn("dbo.Students", "ParentId", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Veli3");
            DropColumn("dbo.Students", "Veli2");
            DropColumn("dbo.Students", "Veli1");
            CreateIndex("dbo.Students", "ParentId");
            AddForeignKey("dbo.Students", "ParentId", "dbo.Parents", "ParentId", cascadeDelete: true);
        }
    }
}
