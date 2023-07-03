using Microsoft.EntityFrameworkCore;
using MovieTicketsApp.Data.Enums;
using MovieTicketsApp.Models;

namespace MovieTicketsApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var cinema1 = new Cinema()
            {
                Id = 1,
                Name = "Cinema 1",
                Logo = "~/Images/Cinemas/img1.jpg",
                Description = "Description for Cinema 1"
            };
            var cinema2 = new Cinema()
            {
                Id= 2,
                Name = "Cinema 2",
                Logo = "~/Images/Cinemas/img2.jpg",
                Description = "Description for Cinema 1"
            };
            var cinema3 = new Cinema()
            {
                Id = 3,
                Name = "Cinema 3",
                Logo = "~/Images/Cinemas/img3.jpg",
                Description = "Description for Cinema 1"
            };
            var cinema4 = new Cinema()
            {
                Id = 4, 
                Name = "Cinema 4",
                Logo = "~/Images/Cinemas/img4.jpg",
                Description = "Description for Cinema 1"
            };
            var cinema5 = new Cinema()
            {
                Id = 5,
                Name = "Cinema 5",
                Logo = "~/Images/Cinemas/img5.jpg",
                Description = "Description for Cinema 1"
            };
            var cinema6 = new Cinema()
            {
                Id = 6,
                Name = "Cinema 6",
                Logo = "~/Images/Cinemas/img5.jpg",
                Description = "Description for Cinema 1"
            };

            modelBuilder.Entity<Cinema>().HasData(cinema1, cinema2, cinema3, cinema4, cinema5, cinema6);


            //Actors

            var actor1 = new Actor()
            {
                Id = 1,
                FullName = "Actor 1",
                Bio = "Bio for Actor 1",
                ProfilePictureURL = "~/Images/Actors/actor1.jpg"
            };
            var actor2 = new Actor()
            {
                Id = 2,
                FullName = "Actor 2",
                Bio = "Bio for Actor 2",
                ProfilePictureURL = "~/Images/Actors/actor2.jpg"
            };
            var actor3 = new Actor()
            {
                Id = 3,
                FullName = "Actor 3",
                Bio = "Bio for Actor 3",
                ProfilePictureURL = "~/Images/Actors/actor3.jpg"
            };
            var actor4 = new Actor()
            {
                Id = 4,
                FullName = "Actor 4",
                Bio = "Bio for Actor 4",
                ProfilePictureURL = "~/Images/Actors/actor4.jpg"
            };
            var actor5 = new Actor()
            {
                Id = 5,
                FullName = "Actor 5",
                Bio = "Bio for Actor 5",
                ProfilePictureURL = "~/Images/Actors/actor5.jpg"
            };
            var actor6 = new Actor()
            {
                Id=6,
                FullName = "Actor 6",
                Bio = "Bio for Actor 6",
                ProfilePictureURL = "~/Images/Actors/actor5.jpg"
            };

            modelBuilder.Entity<Actor>().HasData(actor1, actor2, actor3, actor4, actor5, actor6);

            //Producers

            var producer1 = new Producer()
            {
                Id = 1,
                FullName = "Producer 1",
                Bio = "Bio for Producer 1",
                ProfilePictureURL = "~/Images/Producers/producer1.jpeg"
            };
            var producer2 = new Producer()
            {
                Id = 2,
                FullName = "Producer 2",
                Bio = "Bio for Producer 2",
                ProfilePictureURL = "~/Images/Producers/producer2.jpeg"
            };
            var producer3 = new Producer()
            {
                Id = 3,
                FullName = "Producer 3",
                Bio = "Bio for Producer 3",
                ProfilePictureURL = "~/Images/Producers/producer3.jpeg"
            };
            var producer4 = new Producer()
            {
                Id = 4,
                FullName = "Producer 4",
                Bio = "Bio for Producer 4",
                ProfilePictureURL = "~/Images/Producers/producer4.jpeg"
            };
            var producer5 = new Producer()
            {
                Id = 5,
                FullName = "Producer 5",
                Bio = "Bio for Producer 5",
                ProfilePictureURL = "~/Images/Producers/producer5.jpeg"
            };

            var producer6 = new Producer()
            {
                Id = 6,
                FullName = "Producer 6",
                Bio = "Bio for Producer 6",
                ProfilePictureURL = "~/Images/Producers/producer5.jpeg"
            };
            modelBuilder.Entity<Producer>().HasData(producer1, producer2, producer3, producer4, producer5, producer6);

            //Movies
            var movie1 = new Movie()
            {
                Id = 1,
                Name = "Movie 1",
                Description = "Description for movie 1",
                Price = 36.70,
                ImageURL = "~/Images/Movies/movie1.jpeg",
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(-2),
                CinemaId = 1,
                ProducerId = 5,
                MovieCategory = MovieCategory.Drama
            };
            var movie2 = new Movie()
            {
                Id = 2,
                Name = "Movie 2",
                Description = "Description for movie 2",
                Price = 39.50,
                ImageURL = "~/Images/Movies/movie2.jpg",
                StartDate = DateTime.Now.AddDays(-25),
                EndDate = DateTime.Now.AddDays(12),
                CinemaId = 1,
                ProducerId = 3,
                MovieCategory = MovieCategory.Cartoon
            };
            var movie3 = new Movie()
            {
                Id = 3,
                Name = "Movie 3",
                Description = "Description for movie 3",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie3.jpg",
                StartDate = DateTime.Now.AddDays(3),
                EndDate = DateTime.Now.AddDays(20),
                CinemaId = 3,
                ProducerId = 4,
                MovieCategory = MovieCategory.Action
            };
            var movie4 = new Movie()
            {
                Id=4,
                Name = "Movie 4",
                Description = "Description for movie 4",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie4.jpg",
                StartDate = DateTime.Now.AddDays(-15),
                EndDate = DateTime.Now.AddDays(20),
                CinemaId = 2,
                ProducerId = 1,
                MovieCategory = MovieCategory.Action
            };
            var movie5 = new Movie()
            {
                Id=5,
                Name = "Movie 5",
                Description = "Description for movie 5",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie5.jpg",
                StartDate = DateTime.Now.AddDays(-25),
                EndDate = DateTime.Now.AddDays(22),
                CinemaId = 4,
                ProducerId = 5,
                MovieCategory = MovieCategory.Documentary
            };
            var movie6 = new Movie()
            {
                Id=6,
                Name = "Movie 6",
                Description = "Description for movie 6",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie6.jpg",
                StartDate = DateTime.Now.AddDays(3),
                EndDate = DateTime.Now.AddDays(20),
                CinemaId = 5,
                ProducerId = 2,
                MovieCategory = MovieCategory.Action
            };
            var movie7 = new Movie()
            {
                Id=7,
                Name = "Movie 7",
                Description = "Description for movie 7",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie7.jpg",
                StartDate = DateTime.Now.AddDays(15),
                EndDate = DateTime.Now.AddDays(-10),
                CinemaId = 2,
                ProducerId = 4,
                MovieCategory = MovieCategory.Drama
            };
            var movie8 = new Movie()
            {
                Id=8,
                Name = "Movie 8",
                Description = "Description for movie 8",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie8.jpg",
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(12),
                CinemaId = 1,
                ProducerId = 4,
                MovieCategory = MovieCategory.Comedy
            };

            var movie9 = new Movie()
            {
                Id=9,
                Name = "Movie 9",
                Description = "Description for movie 8",
                Price = 35.90,
                ImageURL = "~/Images/Movies/movie8.jpg",
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(12),
                CinemaId = 1,
                ProducerId = 6,
                MovieCategory = MovieCategory.Comedy
            };

            modelBuilder.Entity<Movie>().HasData(movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9);

            //Actors & Movies

            var act1mov3 = new Actor_Movie()
            {
                ActorId = 1,
                MovieId = 3
            };
            var act2mov4 = new Actor_Movie()
            {
                ActorId = 2,
                MovieId = 4
            };
            var act3mov1 = new Actor_Movie()
            {
                ActorId = 3,
                MovieId = 1
            };
            var act4mov2 = new Actor_Movie()
            {
                ActorId = 4,
                MovieId = 2
            };
            var act5mov7 = new Actor_Movie()
            {
                ActorId = 5,
                MovieId = 7
            };
            var act4mov8 = new Actor_Movie()
            {
                ActorId = 4,
                MovieId = 8
            };
            var act2mov7 = new Actor_Movie()
            {
                ActorId = 2,
                MovieId = 7
            };
            var act5mov8 = new Actor_Movie()
            {
                ActorId = 5,
                MovieId = 8
            };
            var act1mov6 = new Actor_Movie()
            {
                ActorId = 1,
                MovieId = 6
            };

            var act3mov8 = new Actor_Movie()
            {
                ActorId = 3,
                MovieId = 8
            };
            var act4mov7 = new Actor_Movie()
            {
                ActorId = 4,
                MovieId = 7
            };

            var act2mov6 = new Actor_Movie()
            {
                ActorId = 2,
                MovieId = 6
            };
            var act5mov1 = new Actor_Movie()
            {
                ActorId = 5,
                MovieId = 1
            };

            var act2mov3 = new Actor_Movie()
            {
                ActorId = 2,
                MovieId = 3
            };
            var act5mov4 = new Actor_Movie()
            {
                ActorId = 5,
                MovieId = 4
            };
            var act4mov5 = new Actor_Movie()
            {
                ActorId = 4,
                MovieId = 5
            };
            var act1mov5 = new Actor_Movie()
            {
                ActorId = 1,
                MovieId = 5
            };

            var act6mov6 = new Actor_Movie()
            {
                ActorId = 6,
                MovieId = 6
            };

            modelBuilder.Entity<Actor_Movie>().HasData(act1mov3, act2mov4, act3mov1, act4mov2, 
                act5mov7, act4mov8, act2mov7, act5mov8, act1mov6, act3mov8, act4mov7, act2mov6, 
                act5mov1, act2mov3, act5mov4, act4mov5, act1mov5, act6mov6);

        }
    }
}

