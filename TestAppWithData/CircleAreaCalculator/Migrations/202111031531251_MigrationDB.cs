namespace CircleAreaCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Circles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Radius = c.Double(nullable: false),
                        Square = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trapezes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SideA = c.Double(nullable: false),
                        SideB = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        TrapezeSquare = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trapezes");
            DropTable("dbo.Circles");
        }
    }
}
