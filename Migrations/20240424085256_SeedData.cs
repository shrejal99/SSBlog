using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SSBlogs.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorName", "Content", "Description", "PublishedOn", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn the basics of ASP.NET Core framework", new DateTime(2024, 4, 14, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7016), "Introduction to ASP.NET Core" },
                    { 2, "Jane Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "A beginner's guide to Entity Framework Core", new DateTime(2024, 4, 15, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7047), "Getting Started with Entity Framework Core" },
                    { 3, "Mike Johnson", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn how to create RESTful APIs using ASP.NET Core", new DateTime(2024, 4, 16, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7050), "Building RESTful APIs with ASP.NET Core" },
                    { 4, "John Doe", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn the basics of ASP.NET Core framework", new DateTime(2024, 4, 14, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7052), "Introduction to ASP.NET Core" },
                    { 5, "Jane Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "A beginner's guide to Entity Framework Core", new DateTime(2024, 4, 15, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7054), "Getting Started with Entity Framework Core" },
                    { 6, "Mike Johnson", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn how to create RESTful APIs using ASP.NET Core", new DateTime(2024, 4, 16, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7056), "Building RESTful APIs with ASP.NET Core" },
                    { 7, "John Doe", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn the basics of ASP.NET Core framework", new DateTime(2024, 4, 14, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7058), "Introduction to ASP.NET Core" },
                    { 8, "Jane Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "A beginner's guide to Entity Framework Core", new DateTime(2024, 4, 15, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7060), "Getting Started with Entity Framework Core" },
                    { 9, "Mike Johnson", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn how to create RESTful APIs using ASP.NET Core", new DateTime(2024, 4, 16, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7062), "Building RESTful APIs with ASP.NET Core" },
                    { 10, "John Doe", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn the basics of ASP.NET Core framework", new DateTime(2024, 4, 14, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7063), "Introduction to ASP.NET Core" },
                    { 11, "Jane Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "A beginner's guide to Entity Framework Core", new DateTime(2024, 4, 15, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7065), "Getting Started with Entity Framework Core" },
                    { 12, "Mike Johnson", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn how to create RESTful APIs using ASP.NET Core", new DateTime(2024, 4, 16, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7067), "Building RESTful APIs with ASP.NET Core" },
                    { 13, "Mike Johnson", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn how to create RESTful APIs using ASP.NET Core", new DateTime(2024, 4, 16, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7069), "Building RESTful APIs with ASP.NET Core" },
                    { 14, "John Doe", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Learn the basics of ASP.NET Core framework", new DateTime(2024, 4, 14, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7071), "Introduction to ASP.NET Core" },
                    { 15, "Jane Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "A beginner's guide to Entity Framework Core", new DateTime(2024, 4, 15, 4, 52, 56, 277, DateTimeKind.Local).AddTicks(7073), "Getting Started with Entity Framework Core" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
