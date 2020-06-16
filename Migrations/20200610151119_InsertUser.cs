using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InsertUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("userdetails", new string[] { "id", "name", "email", "password" }, new object[,]
            {
                {1, "Luu Danh", "luudanh@gmail.com", "123456" },
                {2, "Luu Van Danh", "abc1234@gmail.com", "123456" },
                {3, "Danh Van Luu", "luuvandanh123@gmail.com", "123456" }
            });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
