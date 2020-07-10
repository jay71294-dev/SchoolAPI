using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    AssignmentTitle = table.Column<string>(maxLength: 60, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentSubmissions",
                columns: table => new
                {
                    SectionID = table.Column<Guid>(nullable: false),
                    AssignmentID = table.Column<string>(maxLength: 60, nullable: false),
                    SubmissionText = table.Column<string>(nullable: true),
                    Score = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentSubmissions", x => x.SectionID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    CourseTitle = table.Column<string>(maxLength: 60, nullable: false),
                    CourseDesc = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "CourseSections",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<string>(maxLength: 60, nullable: false),
                    EndDate = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSections", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(nullable: false),
                    OrgName = table.Column<string>(maxLength: 60, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "SectionEnrollments",
                columns: table => new
                {
                    SectionID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<string>(maxLength: 60, nullable: false),
                    CourseDesc = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionEnrollments", x => x.SectionID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 60, nullable: false),
                    hobby = table.Column<string>(nullable: true),
                    AssignmentId = table.Column<Guid>(nullable: true),
                    AssignmentSubmissionId = table.Column<Guid>(nullable: true),
                    CourseSectionId = table.Column<Guid>(nullable: true),
                    CoursesId = table.Column<Guid>(nullable: true),
                    OrganizationId = table.Column<Guid>(nullable: true),
                    SectionEnrollmentId = table.Column<Guid>(nullable: true),
                    UserId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_AssignmentSubmissions_AssignmentSubmissionId",
                        column: x => x.AssignmentSubmissionId,
                        principalTable: "AssignmentSubmissions",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_CourseSections_CourseSectionId",
                        column: x => x.CourseSectionId,
                        principalTable: "CourseSections",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_SectionEnrollments_SectionEnrollmentId",
                        column: x => x.SectionEnrollmentId,
                        principalTable: "SectionEnrollments",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AssignmentSubmissions",
                columns: new[] { "SectionID", "AssignmentID", "CreatedDate", "Score", "SubmissionText", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "10110", "Date", "100", "bla bla bla", "Date" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "10111", "Date", "100", "bla bla bla", "Date" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "CourseId", "AssignmentTitle", "Description" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "xyz", "this is a assignment title" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "abc", "this is a assignment title" }
                });

            migrationBuilder.InsertData(
                table: "CourseSections",
                columns: new[] { "CourseId", "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Date", "Date", "Date", "Date" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Date", "Date", "Date", "Date" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseDesc", "CourseTitle", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "abc", "xyz", "Date", "Date" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "stu", "pqr", "Date", "Date" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "City", "Country", "OrgName" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Bloomfield", "Austria", "xyz org" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Lusaka", "ZM", "lmnop org" }
                });

            migrationBuilder.InsertData(
                table: "SectionEnrollments",
                columns: new[] { "SectionID", "CourseDesc", "CreatedDate", "UpdatedDate", "UserID" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Course Desc", null, null, "1000" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Course Desc1", null, null, "1001" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AssignmentId", "AssignmentSubmissionId", "CourseSectionId", "CoursesId", "OrganizationId", "SectionEnrollmentId", "UserId1", "UserName", "hobby" },
                values: new object[,]
                {
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), null, null, null, null, null, null, null, "rock007", "Clubbing" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), null, null, null, null, null, null, null, "hulk123", "Love Volleyball" },
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), null, null, null, null, null, null, null, "Dani95", "Adventure trips" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AssignmentId",
                table: "Users",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AssignmentSubmissionId",
                table: "Users",
                column: "AssignmentSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseSectionId",
                table: "Users",
                column: "CourseSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoursesId",
                table: "Users",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SectionEnrollmentId",
                table: "Users",
                column: "SectionEnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId1",
                table: "Users",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "AssignmentSubmissions");

            migrationBuilder.DropTable(
                name: "CourseSections");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "SectionEnrollments");
        }
    }
}
