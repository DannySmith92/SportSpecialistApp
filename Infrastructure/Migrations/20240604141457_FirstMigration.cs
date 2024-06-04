using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentPayouts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlMedia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentPayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinOrder = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateExpires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserIdUsed = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PackagePlan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    MaxTrainingDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePayment = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Piva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaypalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Earning = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    CurrentState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthCode = table.Column<int>(type: "int", nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Born = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisciplineId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AgentPayouts_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "AgentPayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusAppointment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                    table.ForeignKey(
                        name: "FK_Appointment_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisciplineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discipline_AgentPayouts_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "AgentPayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discipline_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    CouponId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    QRCodeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Coupon_CouponId1",
                        column: x => x.CouponId1,
                        principalTable: "Coupon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Payment_PaymentId1",
                        column: x => x.PaymentId1,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PackagePlanAndUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PackagePlanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentTrainingDays = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagePlanAndUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackagePlanAndUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackagePlanAndUser_PackagePlan_PackagePlanId",
                        column: x => x.PackagePlanId,
                        principalTable: "PackagePlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateReview = table.Column<int>(type: "int", nullable: false),
                    RateTrainerAvailability = table.Column<int>(type: "int", nullable: false),
                    RateTrainerKindness = table.Column<int>(type: "int", nullable: false),
                    DateReview = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionStep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlMedia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlMedia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precautions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlan_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                });

            migrationBuilder.CreateTable(
                name: "TrainingAndWorkoutPlan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainingId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TainingId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutPlanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisciplineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Diffilcuty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Repeated = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingAndWorkoutPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingAndWorkoutPlan_AgentPayouts_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "AgentPayouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingAndWorkoutPlan_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);  // Modifica qui
                    table.ForeignKey(
                        name: "FK_TrainingAndWorkoutPlan_WorkoutPlan_WorkoutPlanId",
                        column: x => x.WorkoutPlanId,
                        principalTable: "WorkoutPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_TrainerId",
                table: "Appointment",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DisciplineId",
                table: "AspNetUsers",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_DisciplineId",
                table: "Discipline",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_TrainerId",
                table: "Discipline",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CouponId1",
                table: "Order",
                column: "CouponId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId1",
                table: "Order",
                column: "PaymentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagePlanAndUser_PackagePlanId",
                table: "PackagePlanAndUser",
                column: "PackagePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PackagePlanAndUser_UserId",
                table: "PackagePlanAndUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_TrainerId",
                table: "Training",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAndWorkoutPlan_DisciplineId",
                table: "TrainingAndWorkoutPlan",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAndWorkoutPlan_TrainingId",
                table: "TrainingAndWorkoutPlan",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAndWorkoutPlan_WorkoutPlanId",
                table: "TrainingAndWorkoutPlan",
                column: "WorkoutPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlan_TrainerId",
                table: "WorkoutPlan",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PackagePlanAndUser");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "TrainingAndWorkoutPlan");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PackagePlan");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "WorkoutPlan");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AgentPayouts");
        }
    }


}
