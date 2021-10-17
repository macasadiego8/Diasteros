using AutoMapper;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesDiasteros.Server.Storage
{
    public class AutoMapperRegisters : Profile
    {
        public AutoMappeRegisters()
        {
            CreateMap<Actor,Actor>().ForMember(x=>x.Photo, option =>option.Ignore());
            CreateMap<Movie,Movie>().ForMember(x=>x.Poster, option =>option.Ignore());
 
        }       
    }
}