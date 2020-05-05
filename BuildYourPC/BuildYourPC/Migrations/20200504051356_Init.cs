using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildYourPC.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PowerClass = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    PowerConsumption = table.Column<int>(nullable: false),
                    CoresCount = table.Column<int>(nullable: false),
                    Frequency = table.Column<int>(nullable: false),
                    Chipset = table.Column<string>(nullable: true),
                    RamAge = table.Column<string>(nullable: true),
                    RamFrequency = table.Column<int>(nullable: false),
                    RamStrings = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraphicCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PowerClass = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    PowerConsumption = table.Column<int>(nullable: false),
                    GRAMCount = table.Column<int>(nullable: false),
                    GRAMAge = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Interfaces = table.Column<string>(nullable: true),
                    PowerType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PowerClass = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ConnectionInterface = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PowerClass = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Chipset = table.Column<string>(nullable: true),
                    Socket = table.Column<string>(nullable: true),
                    RAMAge = table.Column<string>(nullable: true),
                    RAMStrings = table.Column<int>(nullable: false),
                    RAMSockets = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PowerClass = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    ProtectionLevel = table.Column<string>(nullable: true),
                    Power = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PowerClass = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Frequency = table.Column<int>(nullable: false),
                    Age = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Pieces = table.Column<int>(nullable: false),
                    Timings = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CpuId = table.Column<int>(nullable: true),
                    MotherboardId = table.Column<int>(nullable: true),
                    RAMId = table.Column<int>(nullable: true),
                    PowerSupplyId = table.Column<int>(nullable: true),
                    MemoryId = table.Column<int>(nullable: true),
                    GraphicCardId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_CPUs_CpuId",
                        column: x => x.CpuId,
                        principalTable: "CPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Computers_GraphicCards_GraphicCardId",
                        column: x => x.GraphicCardId,
                        principalTable: "GraphicCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Computers_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Computers_Motherboards_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Computers_PowerSupplies_PowerSupplyId",
                        column: x => x.PowerSupplyId,
                        principalTable: "PowerSupplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Computers_RAMs_RAMId",
                        column: x => x.RAMId,
                        principalTable: "RAMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Computers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_CpuId",
                table: "Computers",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_GraphicCardId",
                table: "Computers",
                column: "GraphicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_MemoryId",
                table: "Computers",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_MotherboardId",
                table: "Computers",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_PowerSupplyId",
                table: "Computers",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_RAMId",
                table: "Computers",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_UserId",
                table: "Computers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "GraphicCards");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
