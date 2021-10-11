using System;
using System.Collections.Generic;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesDiasteros.Client.Services
{
    public class ServiceActor : IServiceActor
    {
        public List<Actor> GetActors()
        {
            return new List<Actor>()
            {
                new Actor(){Id= 1, Name="Actor 1", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor1.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 2, Name="Actor 2", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor2.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 3, Name="Actor 3", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor3.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 4, Name="Actor 4", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor4.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 5, Name="Actor 5", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor5.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 6, Name="Actor 6", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor6.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 7, Name="Actor 7", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor7.jpeg", Biography = "Vive en Hollywood"},
                new Actor(){Id= 8, Name="Actor 8", BirthDate= new DateTime(1985,12,06), MoviesPerform= "Inception", KnowCredits= 7, Awards= "Oscars", Photo = "Images/Actors/actor8.jpeg", Biography = "Vive en Hollywood"}

            };
        }
        
    }
}