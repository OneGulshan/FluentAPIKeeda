using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPIKeeda.Migrations
{
    /// <inheritdoc />
    public partial class SetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Info_Departments_DepartmentId",
                table: "User_Info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Info",
                table: "User_Info");

            migrationBuilder.RenameTable(
                name: "User_Info",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_Info_DepartmentId",
                table: "Users",
                newName: "IX_Users_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User_Info");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DepartmentId",
                table: "User_Info",
                newName: "IX_User_Info_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "User_Info",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Info",
                table: "User_Info",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Info_Departments_DepartmentId",
                table: "User_Info",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
