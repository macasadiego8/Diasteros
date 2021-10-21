namespace ProjectMoviesDiasteros.Shared.Entity
{
    public class CategoryMovie
    {
        public int CategoryId{get;set;}
        public int MovieId{get;set;}
        public Movie Movie{get; set;}
        public Category Category{get; set;}         
        
    }
}