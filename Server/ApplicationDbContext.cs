using Microsoft.EntityFrameworkCore;
using ProjectMovies5.Shared.Entity; 
using System;
using System.Collections.Generic;

namespace ProjectMovies5.Server
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Movie> Movies {get;set;}
        public DbSet<MovieGenre> MovieGenres {get;set;}
        public DbSet<Actor> Actors {get;set;}

        public ApplicationDbContext
        (DbContextOptions<ApplicationDbContext>options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }   
           
    }
}
    
