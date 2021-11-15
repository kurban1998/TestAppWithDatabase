namespace CircleAreaCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trapezes", "UpperBase", c => c.Double(nullable: false));
            AddColumn("dbo.Trapezes", "LowerBase", c => c.Double(nullable: false));
            DropColumn("dbo.Trapezes", "SideA");
            DropColumn("dbo.Trapezes", "SideB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trapezes", "SideB", c => c.Double(nullable: false));
            AddColumn("dbo.Trapezes", "SideA", c => c.Double(nullable: false));
            DropColumn("dbo.Trapezes", "LowerBase");
            DropColumn("dbo.Trapezes", "UpperBase");
        }
    }
}
