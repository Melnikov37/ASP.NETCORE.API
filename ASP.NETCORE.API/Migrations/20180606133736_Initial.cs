using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessSer",
                columns: table => new
                {
                    BusinessSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessSer", x => x.BusinessSerId);
                });

            migrationBuilder.CreateTable(
                name: "CleaningSer",
                columns: table => new
                {
                    CleaningSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CleaningSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningSer", x => x.CleaningSerId);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    ConditionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConditionName = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "EntertaimentSer",
                columns: table => new
                {
                    EntertaimentSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntertaimentSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntertaimentSer", x => x.EntertaimentSerId);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    FoodTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodTypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.FoodTypeId);
                });

            migrationBuilder.CreateTable(
                name: "HealthAndBeautySer",
                columns: table => new
                {
                    HealthAndBeautySerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HealthAndBeautySerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthAndBeautySer", x => x.HealthAndBeautySerId);
                });

            migrationBuilder.CreateTable(
                name: "InternetSer",
                columns: table => new
                {
                    InternetSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InternetSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetSer", x => x.InternetSerId);
                });

            migrationBuilder.CreateTable(
                name: "ParkingSer",
                columns: table => new
                {
                    ParkingSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParkingSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSer", x => x.ParkingSerId);
                });

            migrationBuilder.CreateTable(
                name: "PlaceDestinations",
                columns: table => new
                {
                    PlaceDestinationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Country = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceDestinations", x => x.PlaceDestinationId);
                });

            migrationBuilder.CreateTable(
                name: "RestOnWaterSer",
                columns: table => new
                {
                    RestOnWaterSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RestOnWaterSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestOnWaterSer", x => x.RestOnWaterSerId);
                });

            migrationBuilder.CreateTable(
                name: "RoomFacilities",
                columns: table => new
                {
                    RoomFacilitiesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomFacilitiesName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFacilities", x => x.RoomFacilitiesId);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomTypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SmokingSer",
                columns: table => new
                {
                    SmokingSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmokingSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmokingSer", x => x.SmokingSerId);
                });

            migrationBuilder.CreateTable(
                name: "SportSer",
                columns: table => new
                {
                    SportSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportSer", x => x.SportSerId);
                });

            migrationBuilder.CreateTable(
                name: "TourOperators",
                columns: table => new
                {
                    TourOperatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Commission = table.Column<float>(nullable: false),
                    TourOperatorName = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourOperators", x => x.TourOperatorId);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    TransportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TransportName = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.TransportId);
                });

            migrationBuilder.CreateTable(
                name: "TransportSer",
                columns: table => new
                {
                    TransportSerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TransportSerName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportSer", x => x.TransportSerId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "BusinessSerAtTour",
                columns: table => new
                {
                    BusinessSerArTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessSerId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessSerAtTour", x => x.BusinessSerArTourId);
                    table.ForeignKey(
                        name: "FK_BusinessSerAtTour_BusinessSer",
                        column: x => x.BusinessSerId,
                        principalTable: "BusinessSer",
                        principalColumn: "BusinessSerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleaningSerAtTour",
                columns: table => new
                {
                    CleaningSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CleaningSerId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningSerAtTour", x => x.CleaningSerAtTourId);
                    table.ForeignKey(
                        name: "FK_CleaningSerAtTour_CleaningSer",
                        column: x => x.CleaningSerId,
                        principalTable: "CleaningSer",
                        principalColumn: "CleaningSerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    DealId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    ConditionId = table.Column<int>(nullable: false),
                    DealConclusionDate = table.Column<DateTime>(type: "date", nullable: false),
                    DealDiscountRate = table.Column<float>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.DealId);
                    table.ForeignKey(
                        name: "FK_Deals_Conditions",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "ConditionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntertaimentSerAtTour",
                columns: table => new
                {
                    EntertaimentSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntertaimentSerId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntertaimentSerAtTour", x => x.EntertaimentSerAtTourId);
                    table.ForeignKey(
                        name: "FK_EntertaimentSerAtTour_EntertaimentSer",
                        column: x => x.EntertaimentSerId,
                        principalTable: "EntertaimentSer",
                        principalColumn: "EntertaimentSerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypeAtTour",
                columns: table => new
                {
                    FoodTypeAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodTypeId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypeAtTour", x => x.FoodTypeAtTourId);
                    table.ForeignKey(
                        name: "FK_FoodTypeAtTour_FoodType",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "FoodTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodTypeId = table.Column<int>(nullable: true),
                    PointDeparture = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    RoomTypeId = table.Column<int>(nullable: true),
                    TourArrivalDate = table.Column<DateTime>(type: "date", nullable: false),
                    TourCost = table.Column<float>(nullable: false),
                    TourDepartureDate = table.Column<DateTime>(type: "date", nullable: false),
                    TourNumberPerson = table.Column<int>(nullable: false),
                    TourNumberPersons = table.Column<int>(nullable: true),
                    TourNumberTransactions = table.Column<int>(nullable: true),
                    TourOperatorId = table.Column<int>(nullable: true),
                    TouristDestinationId = table.Column<int>(nullable: true),
                    TransportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_FoodType",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "FoodTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tours_RoomType",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tour_Tour_operator",
                        column: x => x.TourOperatorId,
                        principalTable: "TourOperators",
                        principalColumn: "TourOperatorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tour_Transport",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "TransportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealthAndBeautySerAtTour",
                columns: table => new
                {
                    HealthAndBeautySerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HealthAndBeautySerId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthAndBeautySerAtTour", x => x.HealthAndBeautySerAtTourId);
                    table.ForeignKey(
                        name: "FK_HealthAndBeautySerAtTour_HealthAndBeautySer",
                        column: x => x.HealthAndBeautySerId,
                        principalTable: "HealthAndBeautySer",
                        principalColumn: "HealthAndBeautySerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InternetSerAtTour",
                columns: table => new
                {
                    InternetSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InternetSerId = table.Column<int>(nullable: false),
                    TouristDestinationsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetSerAtTour", x => x.InternetSerAtTourId);
                    table.ForeignKey(
                        name: "FK_InternetSerAtTour_InternetSer",
                        column: x => x.InternetSerId,
                        principalTable: "InternetSer",
                        principalColumn: "InternetSerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkingSerAtTour",
                columns: table => new
                {
                    ParkingSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParkingSerId = table.Column<int>(nullable: false),
                    TouristDestinationsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSerAtTour", x => x.ParkingSerAtTourId);
                    table.ForeignKey(
                        name: "FK_ParkingSerAtTour_ParkingSer",
                        column: x => x.ParkingSerId,
                        principalTable: "ParkingSer",
                        principalColumn: "ParkingSerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TouristDestinations",
                columns: table => new
                {
                    TouristDestinationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescriptionHotel = table.Column<string>(unicode: false, maxLength: 2000, nullable: true),
                    DistanceToAirport = table.Column<int>(nullable: true),
                    HotelEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HotelFax = table.Column<string>(unicode: false, maxLength: 17, nullable: true),
                    HotelName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    HotelPhone = table.Column<string>(unicode: false, maxLength: 17, nullable: true),
                    HotelSite = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NumberOfRooms = table.Column<int>(nullable: true),
                    NumberStars = table.Column<int>(nullable: true),
                    PhotoId = table.Column<int>(nullable: true),
                    PlaceDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristDestinations", x => x.TouristDestinationId);
                    table.ForeignKey(
                        name: "FK_Tourist_destination_Place_destination",
                        column: x => x.PlaceDestinationId,
                        principalTable: "PlaceDestinations",
                        principalColumn: "PlaceDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false),
                    UrlLLink = table.Column<string>(unicode: false, maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_TouristDestinations",
                        column: x => x.TouristDestinationId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RatingValue = table.Column<int>(nullable: false),
                    TouristDestinationsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Rating_TouristDestinations",
                        column: x => x.TouristDestinationsId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestOnWaterSerAtTour",
                columns: table => new
                {
                    RestOnWaterSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RestOnWaterSerId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestOnWaterSerAtTour", x => x.RestOnWaterSerAtTourId);
                    table.ForeignKey(
                        name: "FK_RestOnWaterSerAtTour_RestOnWaterSer",
                        column: x => x.RestOnWaterSerId,
                        principalTable: "RestOnWaterSer",
                        principalColumn: "RestOnWaterSerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestOnWaterSerAtTour_TouristDestinations",
                        column: x => x.TouristDestinationId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomFacilitiesAtTour",
                columns: table => new
                {
                    RoomFacilitiesAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomFacilitiesId = table.Column<int>(nullable: false),
                    TouristDestinationsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFacilitiesAtTour", x => x.RoomFacilitiesAtTourId);
                    table.ForeignKey(
                        name: "FK_RoomFacilitiesAtTour_RoomFacilities",
                        column: x => x.RoomFacilitiesId,
                        principalTable: "RoomFacilities",
                        principalColumn: "RoomFacilitiesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomFacilitiesAtTour_TouristDestinations",
                        column: x => x.TouristDestinationsId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypeAtTour",
                columns: table => new
                {
                    RoomTypeAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomTypeId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypeAtTour", x => x.RoomTypeAtTourId);
                    table.ForeignKey(
                        name: "FK_RoomTypeAtTour_RoomType",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomTypeAtTour_TouristDestinations",
                        column: x => x.TouristDestinationId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SmokingSerAtTour",
                columns: table => new
                {
                    SmokingSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SmokingSerId = table.Column<int>(nullable: false),
                    TouristDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmokingSerAtTour", x => x.SmokingSerAtTourId);
                    table.ForeignKey(
                        name: "FK_SmokingSerAtTour_SmokingSer",
                        column: x => x.SmokingSerId,
                        principalTable: "SmokingSer",
                        principalColumn: "SmokingSerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SmokingSerAtTour_TouristDestinations",
                        column: x => x.TouristDestinationId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SportSerAtTour",
                columns: table => new
                {
                    SportSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportSerId = table.Column<int>(nullable: false),
                    TouristDestinationsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportSerAtTour", x => x.SportSerAtTourId);
                    table.ForeignKey(
                        name: "FK_SportSerAtTour_SportSer",
                        column: x => x.SportSerId,
                        principalTable: "SportSer",
                        principalColumn: "SportSerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SportSerAtTour_TouristDestinations",
                        column: x => x.TouristDestinationsId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportSerAtTour",
                columns: table => new
                {
                    TransportSerAtTourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TouristDestinationsId = table.Column<int>(nullable: false),
                    TransportSerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportSerAtTour", x => x.TransportSerAtTourId);
                    table.ForeignKey(
                        name: "FK_TransportSerAtTour_TouristDestinations",
                        column: x => x.TouristDestinationsId,
                        principalTable: "TouristDestinations",
                        principalColumn: "TouristDestinationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportSerAtTour_TransportSer",
                        column: x => x.TransportSerId,
                        principalTable: "TransportSer",
                        principalColumn: "TransportSerId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSerAtTour_BusinessSerId",
                table: "BusinessSerAtTour",
                column: "BusinessSerId");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningSerAtTour_CleaningSerId",
                table: "CleaningSerAtTour",
                column: "CleaningSerId");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningSerAtTour_TouristDestinationId",
                table: "CleaningSerAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_ConditionId",
                table: "Deals",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_TourId",
                table: "Deals",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_EntertaimentSerAtTour_EntertaimentSerId",
                table: "EntertaimentSerAtTour",
                column: "EntertaimentSerId");

            migrationBuilder.CreateIndex(
                name: "IX_EntertaimentSerAtTour_TouristDestinationId",
                table: "EntertaimentSerAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypeAtTour_FoodTypeId",
                table: "FoodTypeAtTour",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypeAtTour_TouristDestinationId",
                table: "FoodTypeAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthAndBeautySerAtTour_HealthAndBeautySerId",
                table: "HealthAndBeautySerAtTour",
                column: "HealthAndBeautySerId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthAndBeautySerAtTour_TouristDestinationId",
                table: "HealthAndBeautySerAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetSerAtTour_InternetSerId",
                table: "InternetSerAtTour",
                column: "InternetSerId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetSerAtTour_TouristDestinationsId",
                table: "InternetSerAtTour",
                column: "TouristDestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSerAtTour_ParkingSerId",
                table: "ParkingSerAtTour",
                column: "ParkingSerId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSerAtTour_TouristDestinationsId",
                table: "ParkingSerAtTour",
                column: "TouristDestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TouristDestinationId",
                table: "Photos",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_TouristDestinationsId",
                table: "Rating",
                column: "TouristDestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_RestOnWaterSerAtTour_RestOnWaterSerId",
                table: "RestOnWaterSerAtTour",
                column: "RestOnWaterSerId");

            migrationBuilder.CreateIndex(
                name: "IX_RestOnWaterSerAtTour_TouristDestinationId",
                table: "RestOnWaterSerAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomFacilitiesAtTour_RoomFacilitiesId",
                table: "RoomFacilitiesAtTour",
                column: "RoomFacilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomFacilitiesAtTour_TouristDestinationsId",
                table: "RoomFacilitiesAtTour",
                column: "TouristDestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeAtTour_RoomTypeId",
                table: "RoomTypeAtTour",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeAtTour_TouristDestinationId",
                table: "RoomTypeAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_SmokingSerAtTour_SmokingSerId",
                table: "SmokingSerAtTour",
                column: "SmokingSerId");

            migrationBuilder.CreateIndex(
                name: "IX_SmokingSerAtTour_TouristDestinationId",
                table: "SmokingSerAtTour",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_SportSerAtTour_SportSerId",
                table: "SportSerAtTour",
                column: "SportSerId");

            migrationBuilder.CreateIndex(
                name: "IX_SportSerAtTour_TouristDestinationsId",
                table: "SportSerAtTour",
                column: "TouristDestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_TouristDestinations_PhotoId",
                table: "TouristDestinations",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_TouristDestinations_PlaceDestinationId",
                table: "TouristDestinations",
                column: "PlaceDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_FoodTypeId",
                table: "Tours",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_RoomTypeId",
                table: "Tours",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourOperatorId",
                table: "Tours",
                column: "TourOperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TouristDestinationId",
                table: "Tours",
                column: "TouristDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TransportId",
                table: "Tours",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportSerAtTour_TouristDestinationsId",
                table: "TransportSerAtTour",
                column: "TouristDestinationsId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportSerAtTour_TransportSerId",
                table: "TransportSerAtTour",
                column: "TransportSerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningSerAtTour_CleaningSerAtTour",
                table: "CleaningSerAtTour",
                column: "TouristDestinationId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Tours",
                table: "Deals",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "TourId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntertaimentSerAtTour_TouristDestinations",
                table: "EntertaimentSerAtTour",
                column: "TouristDestinationId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodTypeAtTour_TouristDestinations",
                table: "FoodTypeAtTour",
                column: "TouristDestinationId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Tourist_destination",
                table: "Tours",
                column: "TouristDestinationId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthAndBeautySerAtTour_TouristDestinations",
                table: "HealthAndBeautySerAtTour",
                column: "TouristDestinationId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InternetSerAtTour_TouristDestinations",
                table: "InternetSerAtTour",
                column: "TouristDestinationsId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParkingSerAtTour_TouristDestinations",
                table: "ParkingSerAtTour",
                column: "TouristDestinationsId",
                principalTable: "TouristDestinations",
                principalColumn: "TouristDestinationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_destination_Photo",
                table: "TouristDestinations",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_TouristDestinations",
                table: "Photos");

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
                name: "BusinessSerAtTour");

            migrationBuilder.DropTable(
                name: "CleaningSerAtTour");

            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "EntertaimentSerAtTour");

            migrationBuilder.DropTable(
                name: "FoodTypeAtTour");

            migrationBuilder.DropTable(
                name: "HealthAndBeautySerAtTour");

            migrationBuilder.DropTable(
                name: "InternetSerAtTour");

            migrationBuilder.DropTable(
                name: "ParkingSerAtTour");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "RestOnWaterSerAtTour");

            migrationBuilder.DropTable(
                name: "RoomFacilitiesAtTour");

            migrationBuilder.DropTable(
                name: "RoomTypeAtTour");

            migrationBuilder.DropTable(
                name: "SmokingSerAtTour");

            migrationBuilder.DropTable(
                name: "SportSerAtTour");

            migrationBuilder.DropTable(
                name: "TransportSerAtTour");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BusinessSer");

            migrationBuilder.DropTable(
                name: "CleaningSer");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "EntertaimentSer");

            migrationBuilder.DropTable(
                name: "HealthAndBeautySer");

            migrationBuilder.DropTable(
                name: "InternetSer");

            migrationBuilder.DropTable(
                name: "ParkingSer");

            migrationBuilder.DropTable(
                name: "RestOnWaterSer");

            migrationBuilder.DropTable(
                name: "RoomFacilities");

            migrationBuilder.DropTable(
                name: "SmokingSer");

            migrationBuilder.DropTable(
                name: "SportSer");

            migrationBuilder.DropTable(
                name: "TransportSer");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "TourOperators");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "TouristDestinations");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PlaceDestinations");
        }
    }
}
