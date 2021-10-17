using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace ProjectMoviesDiasteros.Client.Services
{
    public class HttpResponseWrapper<T>
    {
        

        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public bool Error{get; set;}
        public T Response{get; set;}
        public HttpResponseMessage HttpResponseMessage{get; set;}        
    }
}