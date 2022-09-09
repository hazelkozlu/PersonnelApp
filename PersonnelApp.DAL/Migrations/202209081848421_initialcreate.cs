namespace PersonnelApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedTime = c.DateTime(),
                        UpdatedTime = c.DateTime(),
                        DeletedTime = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DepartmantId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        UpdatedTime = c.DateTime(),
                        DeletedTime = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnels", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Personnels", new[] { "Department_Id" });
            DropTable("dbo.Personnels");
            DropTable("dbo.Departments");
        }
    }
}
