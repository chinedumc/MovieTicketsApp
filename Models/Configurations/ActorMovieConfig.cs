using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTicketsApp.Migrations;

namespace MovieTicketsApp.Models.Configurations
{
    public class ActorMovieConfig : IEntityTypeConfiguration<Actor_Movie>
    {
        public void Configure(EntityTypeBuilder<Actor_Movie> builder)
        {
            builder.HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
        }
    }
}
