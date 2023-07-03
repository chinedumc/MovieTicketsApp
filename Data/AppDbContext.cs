using Microsoft.EntityFrameworkCore;
using MovieTicketsApp.Models;
using MovieTicketsApp.Data;
using System.Reflection;

namespace MovieTicketsApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //public AppDbContext() : base("AppDb-DataAnnotations")
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            //{
            //    am.ActorId,
            //    am.MovieId
            //});

            //modelBuilder.Entity<Actor_Movie>()
            //    .HasOne(m => m.Movie)
            //    .WithMany(am => am.Actors_Movies)
            //    .HasForeignKey(m => m.MovieId);

            // modelBuilder.Entity<Actor_Movie>()
            //.HasOne(m => m.Actor)
            // .WithMany(am => am.Actors_Movies)
            // .HasForeignKey(m => m.ActorId);


            //base.OnModelCreating(modelBuilder);

            AppDbInitializer.Seed(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
