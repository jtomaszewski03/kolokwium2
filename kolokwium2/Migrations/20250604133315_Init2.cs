using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Purchase_History_CustomerId",
                table: "Purchase_History",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_History_Customer_CustomerId",
                table: "Purchase_History",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_History_Program_AvailableProgramId",
                table: "Purchase_History",
                column: "AvailableProgramId",
                principalTable: "Program",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_History_Customer_CustomerId",
                table: "Purchase_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_History_Program_AvailableProgramId",
                table: "Purchase_History");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_History_CustomerId",
                table: "Purchase_History");
        }
    }
}
