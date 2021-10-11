#pragma checksum "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5078250387abd692d7d7a666a58b56fce99df272"
// <auto-generated/>
#pragma warning disable 1591
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
using ProjectMoviesDiasteros.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor"
using ProjectMoviesDiasteros.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProjectMoviesDiasteros.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectMoviesDiasteros.Shared.Entity.Movie>(
#nullable restore
#line 5 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor"
                  Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor"
                                        Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "CategoriasNoSeleccionadas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProjectMoviesDiasteros.Shared.Entity.Category>>(
#nullable restore
#line 5 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor"
                                                                           CategoriasNoSeleccionadas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor"
       
    private Movie Movie = new Movie();
    private List<Category> CategoriasNoSeleccionadas = new List<Category>();

    protected override void OnInitialized()
    {
        CategoriasNoSeleccionadas = new List<Category>(){
            new Category(){Id = 1, Name="Comedia"},
            new Category(){Id = 2, Name="Terror"},
            new Category(){Id = 3, Name="Ciencia Ficción"},
            new Category(){Id = 4, Name="Documentales"},
            new Category(){Id = 5, Name="Comedia"}
};
    }
    void Create()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Movies\CreateMovie.razor"
                                                                                                        
        Console.WriteLine(navigationManager.Uri);
        navigationManager.NavigateTo("movie");
        Console.WriteLine($"Pelicula: {Movie.Name}");
        Console.WriteLine($"Premier: {Movie.Premier}");
        Console.WriteLine($"Esta en cartelera: {Movie.OnBoard}");
        Console.WriteLine($"Poster: {Movie.Poster}");
        Console.WriteLine($"Sinopsis: {Movie.Sinopsis}");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
