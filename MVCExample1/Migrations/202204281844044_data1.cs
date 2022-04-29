namespace MVCExample1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        CityName = c.String(),
                        StateName = c.String(),
                        ZipCode = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeRole = c.String(),
                        EmployeeSalary = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Addresses", new[] { "EmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Addresses");
        }
    }
}
