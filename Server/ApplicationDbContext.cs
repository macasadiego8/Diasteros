using Microsoft.EntityFrameworkCore;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesDiasteros.Server
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<CategoryMovie> CategoriesMovie {get;set;}
        public DbSet<Actor> Actors {get;set;}
        public DbSet<MovieActor> MoviesActor {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<CategoryMovie>().HasKey(x=>new{x.CategoryId, x.MovieId});
        modelBuilder.Entity<MovieActor>().HasKey(x=>new{x.ActorId, x.MovieId});
        base.OnModelCreating(modelBuilder);
        }       
    }   
}