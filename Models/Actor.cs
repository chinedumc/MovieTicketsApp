using System.ComponentModel.DataAnnotations;


namespace MovieTicketsApp.Models

{
    public class Actor
    {
        //public Actor()
        //{
        //    this.Movies = new HashSet<Movie>();
        //}
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public HashSet<Actor_Movie> Actors_Movies { get; set; } = new HashSet<Actor_Movie> { };

      

    }
}
