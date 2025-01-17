using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDUX_Camed_02.Migrations
{
    /// <inheritdoc />
    public partial class Alterar_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Users",
                newName: "DataNascimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Users",
                newName: "MyProperty");
        }
    }
}
