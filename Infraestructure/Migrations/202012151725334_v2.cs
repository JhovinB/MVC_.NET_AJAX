namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentCode", c => c.String(nullable: false));
            AddColumn("dbo.Students", "startDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "EnrollmentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "EnrollmentDate");
            DropColumn("dbo.Students", "startDate");
            DropColumn("dbo.Students", "studentCode");
            DropColumn("dbo.Students", "studentLastName");
        }
    }
}
