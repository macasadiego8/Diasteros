using System;
namespace ProjectMoviesDiasteros.Client.Model
{
    public class SelectorMultipleModel
    {
        public SelectorMultipleModel(string key, string value) 
        {
            this.Key = key;
            this.Value = value;
               
        }
        public string Key{get;set;}
        public string Value{get;set;}
    }
}