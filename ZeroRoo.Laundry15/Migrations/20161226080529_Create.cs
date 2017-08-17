using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laundry.LibCore.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Text = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    ViewIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClotheCategories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Text = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClotheCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Text = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Flaws",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Text = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flaws", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vips",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    VipID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vips", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CanDiscount = table.Column<bool>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    IsDiscount = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NowDiscount = table.Column<decimal>(nullable: false),
                    PriceString = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prices_ClotheCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "ClotheCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeeRecords",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Account = table.Column<decimal>(nullable: false),
                    AfterUserBlance = table.Column<decimal>(nullable: false),
                    BeforeUserBlance = table.Column<decimal>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    FeeType = table.Column<int>(nullable: false),
                    FromCash = table.Column<decimal>(nullable: false),
                    FromVip = table.Column<decimal>(nullable: false),
                    GiftAccount = table.Column<decimal>(nullable: false),
                    IDView = table.Column<string>(nullable: true, defaultValueSql: "strftime('%Y%m%d%H%M%S','now','localtime')"),
                    Mark = table.Column<string>(nullable: true),
                    RealAccount = table.Column<decimal>(nullable: false),
                    TicketID = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    VipID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FeeRecords_Vips_VipID",
                        column: x => x.VipID,
                        principalTable: "Vips",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaundryTickets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    GetClotheWay = table.Column<int>(nullable: false),
                    HasPay = table.Column<bool>(nullable: false),
                    HasTakeOff = table.Column<bool>(nullable: false),
                    IDView = table.Column<string>(nullable: true, defaultValueSql: "strftime('%Y%m%d%H%M%S','now','localtime')"),
                    Mark = table.Column<string>(nullable: true),
                    PlanTakeAwayAt = table.Column<DateTime>(nullable: false),
                    RealTakeAwayAt = table.Column<DateTime>(nullable: false),
                    TakeOffClotheWay = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    VipID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaundryTickets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LaundryTickets_Vips_VipID",
                        column: x => x.VipID,
                        principalTable: "Vips",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketClotheRecords",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Discount = table.Column<decimal>(nullable: false),
                    IsDiscount = table.Column<bool>(nullable: false),
                    LaundryTicketID = table.Column<int>(nullable: false),
                    Loacation = table.Column<string>(nullable: true),
                    Mark = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    RealTakeOffAt = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketClotheRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TicketClotheRecords_LaundryTickets_LaundryTicketID",
                        column: x => x.LaundryTicketID,
                        principalTable: "LaundryTickets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlawRecords",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')"),
                    Text = table.Column<string>(nullable: true),
                    TicketClotheRecordID = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "datetime('now', 'localtime')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlawRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FlawRecords_TicketClotheRecords_TicketClotheRecordID",
                        column: x => x.TicketClotheRecordID,
                        principalTable: "TicketClotheRecords",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeeRecords_IDView",
                table: "FeeRecords",
                column: "IDView",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeeRecords_VipID",
                table: "FeeRecords",
                column: "VipID");

            migrationBuilder.CreateIndex(
                name: "IX_FlawRecords_TicketClotheRecordID",
                table: "FlawRecords",
                column: "TicketClotheRecordID");

            migrationBuilder.CreateIndex(
                name: "IX_LaundryTickets_VipID",
                table: "LaundryTickets",
                column: "VipID");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CategoryID",
                table: "Prices",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketClotheRecords_LaundryTicketID",
                table: "TicketClotheRecords",
                column: "LaundryTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Vips_Phone",
                table: "Vips",
                column: "Phone",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "FeeRecords");

            migrationBuilder.DropTable(
                name: "Flaws");

            migrationBuilder.DropTable(
                name: "FlawRecords");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "TicketClotheRecords");

            migrationBuilder.DropTable(
                name: "ClotheCategories");

            migrationBuilder.DropTable(
                name: "LaundryTickets");

            migrationBuilder.DropTable(
                name: "Vips");
        }
    }
}
