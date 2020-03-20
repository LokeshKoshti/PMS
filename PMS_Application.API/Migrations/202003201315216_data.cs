namespace PMS_Application.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Emp_id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailID = c.String(),
                        Contact = c.String(),
                        Experiance = c.Int(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        QualificationId = c.Byte(nullable: false),
                        Image = c.Binary(),
                        Joining_Date = c.DateTime(nullable: false),
                        Address = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        ReportingId = c.Int(),
                        DepartmentId = c.Int(),
                        TechnologyId = c.Int(),
                    })
                .PrimaryKey(t => t.Emp_id)
                .ForeignKey("dbo.Department", t => t.DepartmentId)
                .ForeignKey("dbo.Employee", t => t.ReportingId)
                .ForeignKey("dbo.Technology", t => t.TechnologyId)
                .Index(t => t.ReportingId)
                .Index(t => t.DepartmentId)
                .Index(t => t.TechnologyId);
            
            CreateTable(
                "dbo.Technology",
                c => new
                    {
                        TechnologyId = c.Int(nullable: false, identity: true),
                        TechnologyName = c.String(),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                    })
                .PrimaryKey(t => t.TechnologyId)
                .ForeignKey("dbo.Department", t => t.CreatedBy)
                .ForeignKey("dbo.Department", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        Description = c.String(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.Department", t => t.CreatedBy)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.Holiday",
                c => new
                    {
                        HolidayId = c.Int(nullable: false, identity: true),
                        HolidayDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.HolidayId)
                .ForeignKey("dbo.Department", t => t.CreatedBy)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.Leave",
                c => new
                    {
                        LeaveId = c.Int(nullable: false, identity: true),
                        LeaveType = c.String(),
                        CurrentDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Reason = c.String(),
                        Status = c.String(),
                        Comments = c.String(),
                        DepartmentId = c.Int(),
                        TechnologyId = c.Int(),
                    })
                .PrimaryKey(t => t.LeaveId)
                .ForeignKey("dbo.Department", t => t.DepartmentId)
                .ForeignKey("dbo.Technology", t => t.TechnologyId)
                .Index(t => t.DepartmentId)
                .Index(t => t.TechnologyId);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        RequestType = c.String(),
                        Reason = c.String(),
                        Status = c.String(),
                        Comments = c.String(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Requirement",
                c => new
                    {
                        RequirementId = c.Int(nullable: false, identity: true),
                        TotalRequirement = c.Int(nullable: false),
                        Description = c.String(),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                        TechnologyId = c.Int(),
                    })
                .PrimaryKey(t => t.RequirementId)
                .ForeignKey("dbo.Technology", t => t.TechnologyId)
                .ForeignKey("dbo.Department", t => t.CreatedBy)
                .ForeignKey("dbo.Department", t => t.ModifiedBy)
                .Index(t => t.CreatedBy)
                .Index(t => t.ModifiedBy)
                .Index(t => t.TechnologyId);
            
            CreateTable(
                "dbo.Resignation",
                c => new
                    {
                        ResignationId = c.Int(nullable: false, identity: true),
                        ResignDate = c.DateTime(nullable: false),
                        CurrentDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Status = c.String(),
                        CreatedBy = c.Int(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.ResignationId)
                .ForeignKey("dbo.Department", t => t.CreatedBy)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.CreatedBy)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.TimeSheet",
                c => new
                    {
                        TimesheetId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Hours = c.Int(nullable: false),
                        Description = c.String(),
                        CreatedBy = c.Int(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.TimesheetId)
                .ForeignKey("dbo.Department", t => t.CreatedBy)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.CreatedBy)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.TraineeDetails",
                c => new
                    {
                        TraineeId = c.Int(nullable: false, identity: true),
                        Documents = c.String(),
                        EmployeeId = c.Int(),
                        DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.TraineeId)
                .ForeignKey("dbo.Department", t => t.DepartmentId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TraineeDetails", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.TraineeDetails", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.TimeSheet", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.TimeSheet", "CreatedBy", "dbo.Department");
            DropForeignKey("dbo.Resignation", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Resignation", "CreatedBy", "dbo.Department");
            DropForeignKey("dbo.Requirement", "ModifiedBy", "dbo.Department");
            DropForeignKey("dbo.Requirement", "CreatedBy", "dbo.Department");
            DropForeignKey("dbo.Requirement", "TechnologyId", "dbo.Technology");
            DropForeignKey("dbo.Request", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Leave", "TechnologyId", "dbo.Technology");
            DropForeignKey("dbo.Leave", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Holiday", "CreatedBy", "dbo.Department");
            DropForeignKey("dbo.Event", "CreatedBy", "dbo.Department");
            DropForeignKey("dbo.Employee", "TechnologyId", "dbo.Technology");
            DropForeignKey("dbo.Technology", "ModifiedBy", "dbo.Department");
            DropForeignKey("dbo.Technology", "CreatedBy", "dbo.Department");
            DropForeignKey("dbo.Employee", "ReportingId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "DepartmentId", "dbo.Department");
            DropIndex("dbo.TraineeDetails", new[] { "DepartmentId" });
            DropIndex("dbo.TraineeDetails", new[] { "EmployeeId" });
            DropIndex("dbo.TimeSheet", new[] { "EmployeeId" });
            DropIndex("dbo.TimeSheet", new[] { "CreatedBy" });
            DropIndex("dbo.Resignation", new[] { "EmployeeId" });
            DropIndex("dbo.Resignation", new[] { "CreatedBy" });
            DropIndex("dbo.Requirement", new[] { "TechnologyId" });
            DropIndex("dbo.Requirement", new[] { "ModifiedBy" });
            DropIndex("dbo.Requirement", new[] { "CreatedBy" });
            DropIndex("dbo.Request", new[] { "EmployeeId" });
            DropIndex("dbo.Leave", new[] { "TechnologyId" });
            DropIndex("dbo.Leave", new[] { "DepartmentId" });
            DropIndex("dbo.Holiday", new[] { "CreatedBy" });
            DropIndex("dbo.Event", new[] { "CreatedBy" });
            DropIndex("dbo.Technology", new[] { "ModifiedBy" });
            DropIndex("dbo.Technology", new[] { "CreatedBy" });
            DropIndex("dbo.Employee", new[] { "TechnologyId" });
            DropIndex("dbo.Employee", new[] { "DepartmentId" });
            DropIndex("dbo.Employee", new[] { "ReportingId" });
            DropTable("dbo.TraineeDetails");
            DropTable("dbo.TimeSheet");
            DropTable("dbo.Resignation");
            DropTable("dbo.Requirement");
            DropTable("dbo.Request");
            DropTable("dbo.Leave");
            DropTable("dbo.Holiday");
            DropTable("dbo.Event");
            DropTable("dbo.Technology");
            DropTable("dbo.Employee");
        }
    }
}
