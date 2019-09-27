using Microsoft.EntityFrameworkCore.Migrations;

namespace RFY.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NetworkInterfaces",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    InterfaceName = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    IPAddressV6 = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InterfaceType = table.Column<string>(nullable: true),
                    OperationalStatus = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    AnyCastAddress = table.Column<string>(nullable: true),
                    DNSServerAddresses = table.Column<string>(nullable: true),
                    DHCPServerAddresses = table.Column<string>(nullable: true),
                    DNSSuffix = table.Column<string>(nullable: true),
                    GatewayAddresses = table.Column<string>(nullable: true),
                    IsDNSEnabled = table.Column<bool>(nullable: false),
                    IsDHCPEnabled = table.Column<bool>(nullable: false),
                    MulticastAddresses = table.Column<string>(nullable: true),
                    UniCastAddresses = table.Column<string>(nullable: true),
                    WinServerAddresses = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkInterfaces", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NetworkInterfaces");
        }
    }
}
