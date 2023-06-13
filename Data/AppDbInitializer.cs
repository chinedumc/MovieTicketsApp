using MovieTicketsApp.Data.Enums;
using MovieTicketsApp.Models;

namespace MovieTicketsApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            Logo="~/Images/Cinemas/img1.jpg",
                            Description="Description for Cinema 1"
                        },
                        new Cinema()
                        {
                            Name="Cinema 2",
                            Logo="~/Images/Cinemas/img2.jpg",
                            Description="Description for Cinema 1"
                        },
                        new Cinema()
                        {
                            Name="Cinema 3",
                            Logo="~/Images/Cinemas/img3.jpg",
                            Description="Description for Cinema 1"
                        },
                        new Cinema()
                        {
                            Name="Cinema 4",
                            Logo="~/Images/Cinemas/img4.jpg",
                            Description="Description for Cinema 1"
                        },
                        new Cinema()
                        {
                            Name="Cinema 5",
                            Logo="~/Images/Cinemas/img5.jpg",
                            Description="Description for Cinema 1"
                        },

                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName="Actor 1",
                            Bio="Bio for Actor 1",
                            ProfilePictureURL="~/Images/Actors/actor1.jpg"
                        },
                         new Actor()
                        {
                            FullName="Actor 2",
                            Bio="Bio for Actor 2",
                            ProfilePictureURL="~/Images/Actors/actor2.jpg"
                        },
                          new Actor()
                        {
                            FullName="Actor 3",
                            Bio="Bio for Actor 3",
                            ProfilePictureURL="~/Images/Actors/actor3.jpg"
                        },
                           new Actor()
                        {
                            FullName="Actor 4",
                            Bio="Bio for Actor 4",
                            ProfilePictureURL="~/Images/Actors/actor4.jpg"
                        },
                            new Actor()
                        {
                            FullName="Actor 5",
                            Bio="Bio for Actor 5",
                            ProfilePictureURL="~/Images/Actors/actor5.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Producer 1",
                            Bio="Bio for Producer 1",
                            ProfilePictureURL="~/Images/Producers/producer1.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 2",
                            Bio="Bio for Producer 2",
                            ProfilePictureURL="~/Images/Producers/producer2.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 3",
                            Bio="Bio for Producer 3",
                            ProfilePictureURL="~/Images/Producers/producer3.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 4",
                            Bio="Bio for Producer 4",
                            ProfilePictureURL="~/Images/Producers/producer4.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 5",
                            Bio="Bio for Producer 5",
                            ProfilePictureURL="~/Images/Producers/producer5.jpeg"
                        },
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name="Movie 1",
                            Description="Description for movie 1",
                            Price=36.70,
                            ImageURL="~/Images/Movies/movie1.jpeg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-2),
                            CinemaId=1,
                            ProducerId=5,
                            MovieCategory=MovieCategory.Drama
                        },
                            new Movie()
                        {
                            Name="Movie 2",
                            Description="Description for movie 2",
                            Price=39.50,
                            ImageURL="~/Images/Movies/movie2.jpg",
                            StartDate=DateTime.Now.AddDays(-25),
                            EndDate=DateTime.Now.AddDays(12),
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name="Movie 3",
                            Description="Description for movie 3",
                            Price=35.90,
                            ImageURL="~/Images/Movies/movie3.jpg",
                            StartDate=DateTime.Now.AddDays(3),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemaId=3,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Action
                        },
                          new Movie()
                        {
                            Name="Movie 4",
                            Description="Description for movie 4",
                            Price=35.90,
                            ImageURL="~/Images/Movies/movie4.jpg",
                            StartDate=DateTime.Now.AddDays(-15),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemaId=2,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Action
                        },
                            new Movie()
                        {
                            Name="Movie 5",
                            Description="Description for movie 5",
                            Price=35.90,
                            ImageURL="~/Images/Movies/movie5.jpg",
                            StartDate=DateTime.Now.AddDays(-25),
                            EndDate=DateTime.Now.AddDays(22),
                            CinemaId=4,
                            ProducerId=5,
                            MovieCategory=MovieCategory.Documentary
                        },
                          new Movie()
                        {
                            Name="Movie 6",
                            Description="Description for movie 6",
                            Price=35.90,
                            ImageURL="~/Images/Movies/movie6.jpg",
                            StartDate=DateTime.Now.AddDays(3),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemaId=5,
                            ProducerId=2,
                            MovieCategory=MovieCategory.Action
                        },
                          new Movie()
                        {
                            Name="Movie 7",
                            Description="Description for movie 7",
                            Price=35.90,
                            ImageURL="~/Images/Movies/movie7.jpg",
                            StartDate=DateTime.Now.AddDays(15),
                            EndDate=DateTime.Now.AddDays(-10),
                            CinemaId=2,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Drama
                        },
                          new Movie()
                        {
                            Name="Movie 8",
                            Description="Description for movie 8",
                            Price=35.90,
                            ImageURL="~/Images/Movies/movie8.jpg",
                            StartDate=DateTime.Now.AddDays(-33),
                            EndDate=DateTime.Now.AddDays(12),
                            CinemaId=1,
                            ProducerId=4,
                            MovieCategory=MovieCategory.Comedy
                        },
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=4
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=1
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=2
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=7
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=8
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=7
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=8
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
