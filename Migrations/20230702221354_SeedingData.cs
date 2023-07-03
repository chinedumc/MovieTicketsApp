using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTicketsApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cinemas",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Bio for Actor 1", "Actor 1", "~/Images/Actors/actor1.jpg" },
                    { 2, "Bio for Actor 2", "Actor 2", "~/Images/Actors/actor2.jpg" },
                    { 3, "Bio for Actor 3", "Actor 3", "~/Images/Actors/actor3.jpg" },
                    { 4, "Bio for Actor 4", "Actor 4", "~/Images/Actors/actor4.jpg" },
                    { 5, "Bio for Actor 5", "Actor 5", "~/Images/Actors/actor5.jpg" },
                    { 6, "Bio for Actor 6", "Actor 6", "~/Images/Actors/actor5.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "Description for Cinema 1", "~/Images/Cinemas/img1.jpg", "Cinema 1" },
                    { 2, "Description for Cinema 1", "~/Images/Cinemas/img2.jpg", "Cinema 2" },
                    { 3, "Description for Cinema 1", "~/Images/Cinemas/img3.jpg", "Cinema 3" },
                    { 4, "Description for Cinema 1", "~/Images/Cinemas/img4.jpg", "Cinema 4" },
                    { 5, "Description for Cinema 1", "~/Images/Cinemas/img5.jpg", "Cinema 5" },
                    { 6, "Description for Cinema 1", "~/Images/Cinemas/img5.jpg", "Cinema 6" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Bio for Producer 1", "Producer 1", "~/Images/Producers/producer1.jpeg" },
                    { 2, "Bio for Producer 2", "Producer 2", "~/Images/Producers/producer2.jpeg" },
                    { 3, "Bio for Producer 3", "Producer 3", "~/Images/Producers/producer3.jpeg" },
                    { 4, "Bio for Producer 4", "Producer 4", "~/Images/Producers/producer4.jpeg" },
                    { 5, "Bio for Producer 5", "Producer 5", "~/Images/Producers/producer5.jpeg" },
                    { 6, "Bio for Producer 6", "Producer 6", "~/Images/Producers/producer5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, "Description for movie 1", new DateTime(2023, 6, 30, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3014), "~/Images/Movies/movie1.jpeg", 3, "Movie 1", 36.700000000000003, 5, new DateTime(2023, 6, 22, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(2995) },
                    { 2, 1, "Description for movie 2", new DateTime(2023, 7, 14, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3017), "~/Images/Movies/movie2.jpg", 5, "Movie 2", 39.5, 3, new DateTime(2023, 6, 7, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3016) },
                    { 3, 3, "Description for movie 3", new DateTime(2023, 7, 22, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3020), "~/Images/Movies/movie3.jpg", 1, "Movie 3", 35.899999999999999, 4, new DateTime(2023, 7, 5, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3019) },
                    { 4, 2, "Description for movie 4", new DateTime(2023, 7, 22, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3033), "~/Images/Movies/movie4.jpg", 1, "Movie 4", 35.899999999999999, 1, new DateTime(2023, 6, 17, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3031) },
                    { 5, 4, "Description for movie 5", new DateTime(2023, 7, 24, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3035), "~/Images/Movies/movie5.jpg", 4, "Movie 5", 35.899999999999999, 5, new DateTime(2023, 6, 7, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3034) },
                    { 6, 5, "Description for movie 6", new DateTime(2023, 7, 22, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3038), "~/Images/Movies/movie6.jpg", 1, "Movie 6", 35.899999999999999, 2, new DateTime(2023, 7, 5, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3037) },
                    { 7, 2, "Description for movie 7", new DateTime(2023, 6, 22, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3040), "~/Images/Movies/movie7.jpg", 3, "Movie 7", 35.899999999999999, 4, new DateTime(2023, 7, 17, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3040) },
                    { 8, 1, "Description for movie 8", new DateTime(2023, 7, 14, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3043), "~/Images/Movies/movie8.jpg", 2, "Movie 8", 35.899999999999999, 4, new DateTime(2023, 5, 30, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3042) },
                    { 9, 1, "Description for movie 8", new DateTime(2023, 7, 14, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3045), "~/Images/Movies/movie8.jpg", 2, "Movie 9", 35.899999999999999, 6, new DateTime(2023, 5, 30, 23, 13, 54, 15, DateTimeKind.Local).AddTicks(3044) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 1 },
                    { 3, 8 },
                    { 4, 2 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 7 },
                    { 5, 8 },
                    { 6, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cinemas",
                newName: "id");
        }
    }
}
