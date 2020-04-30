namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        PowerConsumption = c.Int(nullable: false),
                        CoresCount = c.Int(nullable: false),
                        Frequency = c.Int(nullable: false),
                        Chipset = c.String(),
                        RamAge = c.String(),
                        RamFrequency = c.Int(nullable: false),
                        RamStrings = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GraphicCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        PowerConsumption = c.Int(nullable: false),
                        GRAMCount = c.Int(nullable: false),
                        GRAMAge = c.String(),
                        GPU = c.String(),
                        Interfaces = c.String(),
                        PowerType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Memories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        Amount = c.String(),
                        Type = c.String(),
                        ConnectionInterface = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        Chipset = c.String(),
                        Socket = c.String(),
                        RAMAge = c.String(),
                        RAMStrings = c.Int(nullable: false),
                        RAMSockets = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PowerSupplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        ProtectionLevel = c.String(),
                        Power = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        Frequency = c.Int(nullable: false),
                        Age = c.String(),
                        Amount = c.Int(nullable: false),
                        Pieces = c.Int(nullable: false),
                        Timings = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RAMs");
            DropTable("dbo.PowerSupplies");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Memories");
            DropTable("dbo.GraphicCards");
            DropTable("dbo.CPUs");
        }
    }
}
