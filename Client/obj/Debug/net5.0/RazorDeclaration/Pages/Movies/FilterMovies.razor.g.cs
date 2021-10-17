// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectMoviesDiasteros.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using ProjectMoviesDiasteros.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using ProjectMoviesDiasteros.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using ProjectMoviesDiasteros.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using ProjectMoviesDiasteros.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\_Imports.razor"
using ProjectMoviesDiasteros.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
using ProjectMoviesDiasteros.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/filter")]
    public partial class FilterMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
 
    private List<Movie> Movies;
    private List<Category> Categories = new List<Category>();
    string movieName = "";
    string categorySelected = "";
    private bool comingSoon = false;
    private bool onBillboard = false;
    private bool bestRanking = false;

    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

    private void ShowMovies()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
                                                                                                              
        Movies = movie.GetMovies().Where(x => x.Name.ToLower().Contains(movieName.ToLower())).ToList();
        Console.WriteLine($"Película: {movieName}, categoría seleccionada: {categorySelected}");
        Console.WriteLine($"Próximos estrenos: {comingSoon}, en cartelera: {onBillboard}, mejor calificada: {bestRanking}");
    }

    private void CleanFields()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
                                                           
        Movies = movie.GetMovies(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
                                                                                                        
        movieName = ""; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
                                                               
        categorySelected = "0"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
                                                                           
        comingSoon = false; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\FilterMovies.razor"
                                                                                                 
        onBillboard = false;
        bestRanking = false;
    }

    private void SearchMovies(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            ShowMovies();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
