using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMoviesDiasteros.Client.Services
{
    public class ErrorMessage : IErrorMessage
    {
        public async Task ShowErrorMessage(string message)
        {
            await Task.FromResult(0);
        }
    }
}