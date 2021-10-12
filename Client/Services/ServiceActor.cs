using ProjectMovies5.Shared.Entity;
using System;
using System.Collections.Generic;

namespace ProjectMovies5.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List <Actor> GetActors()
        {
            return new List<Actor>()
            {
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"},
                new Actor(){Id = 0, Name="Actor 1",BirthDate= new DateTime(1990,12,03),Photo="",KnowCredits=12,Biography="Biografía...",Nominations = "3"}
            };
        }
    }
}