namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserAndComputer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cpu_Id = c.Int(),
                        GraphicCard_Id = c.Int(),
                        Memory_Id = c.Int(),
                        Motherboard_Id = c.Int(),
                        PowerSupply_Id = c.Int(),
                        RAM_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CPUs", t => t.Cpu_Id)
                .ForeignKey("dbo.GraphicCards", t => t.GraphicCard_Id)
                .ForeignKey("dbo.Memories", t => t.Memory_Id)
                .ForeignKey("dbo.Motherboards", t => t.Motherboard_Id)
                .ForeignKey("dbo.PowerSupplies", t => t.PowerSupply_Id)
                .ForeignKey("dbo.RAMs", t => t.RAM_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Cpu_Id)
                .Index(t => t.GraphicCard_Id)
                .Index(t => t.Memory_Id)
                .Index(t => t.Motherboard_Id)
                .Index(t => t.PowerSupply_Id)
                .Index(t => t.RAM_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Computers", "RAM_Id", "dbo.RAMs");
            DropForeignKey("dbo.Computers", "PowerSupply_Id", "dbo.PowerSupplies");
            DropForeignKey("dbo.Computers", "Motherboard_Id", "dbo.Motherboards");
            DropForeignKey("dbo.Computers", "Memory_Id", "dbo.Memories");
            DropForeignKey("dbo.Computers", "GraphicCard_Id", "dbo.GraphicCards");
            DropForeignKey("dbo.Computers", "Cpu_Id", "dbo.CPUs");
            DropIndex("dbo.Computers", new[] { "User_Id" });
            DropIndex("dbo.Computers", new[] { "RAM_Id" });
            DropIndex("dbo.Computers", new[] { "PowerSupply_Id" });
            DropIndex("dbo.Computers", new[] { "Motherboard_Id" });
            DropIndex("dbo.Computers", new[] { "Memory_Id" });
            DropIndex("dbo.Computers", new[] { "GraphicCard_Id" });
            DropIndex("dbo.Computers", new[] { "Cpu_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Computers");
        }
    }
}
