using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ActivityName = table.Column<int>(type: "int", nullable: false),
                    ActivityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CommunicationTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NationalCode = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Proofs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ProofName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proofs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Communications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommunicationTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Communications_CommunicationTypes_CommunicationTypeID",
                        column: x => x.CommunicationTypeID,
                        principalTable: "CommunicationTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPicture",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPicture", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonPicture_People_ID",
                        column: x => x.ID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Biography = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Writers_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    MajorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Members_Majors_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Majors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Members_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_Proofs_ProofID",
                        column: x => x.ProofID,
                        principalTable: "Proofs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ActivityRole",
                columns: table => new
                {
                    ActivitiesID = table.Column<int>(type: "int", nullable: false),
                    RolesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityRole", x => new { x.ActivitiesID, x.RolesID });
                    table.ForeignKey(
                        name: "FK_ActivityRole_Activities_ActivitiesID",
                        column: x => x.ActivitiesID,
                        principalTable: "Activities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityRole_Roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CommunicationPerson",
                columns: table => new
                {
                    CommunicationsID = table.Column<int>(type: "int", nullable: false),
                    PeopleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationPerson", x => new { x.CommunicationsID, x.PeopleID });
                    table.ForeignKey(
                        name: "FK_CommunicationPerson_Communications_CommunicationsID",
                        column: x => x.CommunicationsID,
                        principalTable: "Communications",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommunicationPerson_People_PeopleID",
                        column: x => x.PeopleID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesID",
                        column: x => x.RolesID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookWriter",
                columns: table => new
                {
                    BooksID = table.Column<int>(type: "int", nullable: false),
                    WritersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookWriter", x => new { x.BooksID, x.WritersID });
                    table.ForeignKey(
                        name: "FK_BookWriter_Books_BooksID",
                        column: x => x.BooksID,
                        principalTable: "Books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookWriter_Writers_WritersID",
                        column: x => x.WritersID,
                        principalTable: "Writers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormBorrows",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberofDay = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormBorrows", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FormBorrows_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FormBorrows_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "ActivityDescription", "ActivityName" },
                values: new object[,]
                {
                    { 1, "دسترسی به منوی مدیریت اطلاعات", 10 },
                    { 2, "دسترسی به منوی مدیریت امانت", 20 },
                    { 3, "دسترسی به منوی گزارش گیری", 30 },
                    { 4, "دسترسی به منوی مدیریت نرم افزار ", 40 },
                    { 5, "دسترسی به منوی مدیریت امنیت", 50 }
                });

            migrationBuilder.InsertData(
                table: "CommunicationTypes",
                columns: new[] { "ID", "CommunicationTypeName" },
                values: new object[,]
                {
                    { 30, "پست الکترونیکی" },
                    { 40, "اینیستاگرام" },
                    { 10, "همراه" },
                    { 20, "تلفن" }
                });

            migrationBuilder.InsertData(
                table: "Majors",
                columns: new[] { "ID", "MajorName" },
                values: new object[] { -1, "" });

            migrationBuilder.InsertData(
                table: "Proofs",
                columns: new[] { "ID", "ProofName" },
                values: new object[,]
                {
                    { 60, "دکتری" },
                    { -1, "" },
                    { 10, "زیر دیپلم" },
                    { 20, "دیپلم" },
                    { 30, "کاردانی" },
                    { 40, "کارشناسی" },
                    { 50, "کارشناسی ارشد" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "RoleName" },
                values: new object[] { -1, "Administrator" });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ActivityName",
                table: "Activities",
                column: "ActivityName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRole_RolesID",
                table: "ActivityRole",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookName",
                table: "Books",
                column: "BookName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_SubjectId",
                table: "Books",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BookWriter_WritersID",
                table: "BookWriter",
                column: "WritersID");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationPerson_PeopleID",
                table: "CommunicationPerson",
                column: "PeopleID");

            migrationBuilder.CreateIndex(
                name: "IX_Communications_CommunicationTypeID",
                table: "Communications",
                column: "CommunicationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationTypes_CommunicationTypeName",
                table: "CommunicationTypes",
                column: "CommunicationTypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormBorrows_BookID",
                table: "FormBorrows",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_FormBorrows_MemberID",
                table: "FormBorrows",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_MajorName",
                table: "Majors",
                column: "MajorName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_MajorID",
                table: "Members",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_PersonID",
                table: "Members",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_ProofID",
                table: "Members",
                column: "ProofID");

            migrationBuilder.CreateIndex(
                name: "IX_People_NationalCode",
                table: "People",
                column: "NationalCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proofs_ProofName",
                table: "Proofs",
                column: "ProofName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleName",
                table: "Roles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersID",
                table: "RoleUser",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubjectName",
                table: "Subjects",
                column: "SubjectName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonID",
                table: "Users",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Writers_PersonID",
                table: "Writers",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityRole");

            migrationBuilder.DropTable(
                name: "BookWriter");

            migrationBuilder.DropTable(
                name: "CommunicationPerson");

            migrationBuilder.DropTable(
                name: "FormBorrows");

            migrationBuilder.DropTable(
                name: "PersonPicture");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Communications");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CommunicationTypes");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "Proofs");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
