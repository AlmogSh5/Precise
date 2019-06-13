using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2bPrecise.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeesDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportItemsDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    ReportText = table.Column<string>(nullable: true),
                    IssuedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportItemsDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskItemsDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    TaskText = table.Column<string>(nullable: true),
                    AssignedDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItemsDb", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EmployeesDb",
                columns: new[] { "Id", "FirstName", "ImgUrl", "LastName", "ManagerId", "Position" },
                values: new object[,]
                {
                    { 1, "The", "https://4.bp.blogspot.com/-tWGJ-aN1PxE/WNoH4DOOYNI/AAAAAAAAVcc/7B9s7OCcDRoSI5xugYKdz2sbxKFZQRCvQCPcB/s1600/Season%2B4%2Bpromo%2B5a.jpg", "Doctor", 0, 1 },
                    { 2, "Sherlock", "https://www.fjackets.com/product_images/a/723/Benedict_Cumberbatch_Sherlock_Coat__78001_zoom.jpg", "Holmes", 1, 1 },
                    { 3, "John", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/John_Oliver_November_2016.jpg/220px-John_Oliver_November_2016.jpg", "Oliver", 1, 1 },
                    { 4, "Matt", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGX06TZQG/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", "Damon", 2, 0 },
                    { 5, "Chris", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlLhjtiYwT4jd3tWyuFS6Rfp7u0rTKEw8s10VXNq7gXYkxkG_s", "Pratt", 3, 0 },
                    { 6, "Will", "http://cdn01.cdn.justjared.com/wp-content/uploads/headlines/2011/12/men-in-black-3.jpg", "Smith", 3, 0 },
                    { 7, "Forrest", "https://ksassets.timeincuk.net/wp/uploads/sites/55/2019/03/forrest-920x584.png", "Gump", 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "ReportItemsDb",
                columns: new[] { "Id", "EmployeeId", "IssuedDate", "ManagerId", "ReportText" },
                values: new object[,]
                {
                    { 13, 2, new DateTime(2019, 6, 2, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 1, "Report 6 text" },
                    { 12, 3, new DateTime(2019, 5, 29, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 1, "Report 5 text" },
                    { 11, 4, new DateTime(2019, 5, 16, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 2, "Report 4 text" },
                    { 9, 7, new DateTime(2019, 5, 1, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 3, "Report 2 text" },
                    { 8, 7, new DateTime(2019, 4, 24, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 3, "Report 1 text" },
                    { 10, 6, new DateTime(2019, 5, 7, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 3, "Report 3 text" }
                });

            migrationBuilder.InsertData(
                table: "TaskItemsDb",
                columns: new[] { "Id", "AssignedDate", "DueDate", "EmployeeId", "ManagerId", "TaskText" },
                values: new object[,]
                {
                    { 20, new DateTime(2019, 6, 10, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 6, 18, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 2, 1, "Task 7 text" },
                    { 14, new DateTime(2019, 5, 24, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 5, 29, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 7, 3, "Task 1 text" },
                    { 15, new DateTime(2019, 5, 25, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 6, 2, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 3, 2, "Task 2 text, changed Manager" },
                    { 16, new DateTime(2019, 5, 25, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 5, 29, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 6, 3, "Task 3 text" },
                    { 17, new DateTime(2019, 5, 27, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 6, 1, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 5, 3, "Task 4 text" },
                    { 18, new DateTime(2019, 5, 30, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 6, 5, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 4, 2, "Task 5 text" },
                    { 19, new DateTime(2019, 6, 6, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 6, 10, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 4, 2, "Task 6 text" },
                    { 21, new DateTime(2019, 6, 11, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), new DateTime(2019, 6, 16, 5, 0, 4, 332, DateTimeKind.Unspecified).AddTicks(3305), 3, 1, "Task 8 text" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesDb");

            migrationBuilder.DropTable(
                name: "ReportItemsDb");

            migrationBuilder.DropTable(
                name: "TaskItemsDb");
        }
    }
}
