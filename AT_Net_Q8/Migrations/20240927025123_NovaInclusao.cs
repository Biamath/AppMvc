using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AT_Net_Q8.Migrations
{
    /// <inheritdoc />
    public partial class NovaInclusao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Cliente");
        }
    }
}
