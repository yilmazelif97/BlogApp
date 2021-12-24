using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Migrations
{
    public partial class djdfsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_postid",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "postid",
                table: "Comments",
                newName: "postId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_postid",
                table: "Comments",
                newName: "IX_Comments_postId");

            migrationBuilder.AlterColumn<int>(
                name: "postId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_postId",
                table: "Comments",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_postId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "postId",
                table: "Comments",
                newName: "postid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_postId",
                table: "Comments",
                newName: "IX_Comments_postid");

            migrationBuilder.AlterColumn<int>(
                name: "postid",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_postid",
                table: "Comments",
                column: "postid",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
