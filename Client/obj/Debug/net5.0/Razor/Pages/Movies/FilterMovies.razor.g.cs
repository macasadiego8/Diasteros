#pragma checksum "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9844b5b61ce9ce372e18c6b74e2350133a06b345"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectMovies5.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using ProjectMovies5.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using ProjectMovies5.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using ProjectMovies5.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using ProjectMovies5.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
using ProjectMovies5.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/filter")]
    public partial class FilterMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-3");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 10 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                           (KeyboardEventArgs e)=>MovieSearch(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "movie_name");
            __builder.AddAttribute(11, "placeholder", "Buscar pelicula");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                  movie_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie_name = __value, movie_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group mb-3");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                            categorySelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categorySelected = __value, categorySelected));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "0");
            __builder.AddMarkupContent(23, "Selecciona una categoría");
            __builder.CloseElement();
#nullable restore
#line 17 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
             foreach (var item in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", 
#nullable restore
#line 19 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, 
#nullable restore
#line 19 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-inline");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group mx-sm-3 mb-3");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "checkbox");
            __builder.AddAttribute(34, "class", "form-check-input");
            __builder.AddAttribute(35, "id", "estrenos");
            __builder.AddAttribute(36, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                                                                 futurosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurosEstrenos = __value, futurosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.AddMarkupContent(39, "<label class=\"form-check-label\" for=\"estrenos\">Próximos estrenos</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group mx-sm-3 mb-3");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "checkbox");
            __builder.AddAttribute(45, "class", "form-check-input");
            __builder.AddAttribute(46, "id", "cartelera");
            __builder.AddAttribute(47, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                                                                  enCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enCartelera = __value, enCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.AddMarkupContent(50, "<label class=\"form-check-label\" for=\"cartelera\">En cartelera</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group mx-sm-3 mb-3");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "checkbox");
            __builder.AddAttribute(56, "class", "form-check-input");
            __builder.AddAttribute(57, "id", "mejora_calificada");
            __builder.AddAttribute(58, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                                                                          mejorCalificada

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mejorCalificada = __value, mejorCalificada));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n            ");
            __builder.AddMarkupContent(61, "<label class=\"form-check-label\" for=\"mejora_calificada\">Mejor calificadas</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n\n    ");
            __builder.OpenElement(63, "div");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                                                             ShowMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(68, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n        ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "type", "button");
            __builder.AddAttribute(72, "class", "btn btn-danger mb-2 mx-sm-3");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                                                                            ClearInputs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Limpiar campos");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n");
            __builder.OpenComponent<ProjectMovies5.Client.Pages.Components.ServiceComponent>(76);
            __builder.AddAttribute(77, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProjectMovies5.Shared.Entity.Movie>>(
#nullable restore
#line 47 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
                          Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\mintic\ProjectMovies5\Client\Pages\Movies\FilterMovies.razor"
       
    private List<Movie> Movies;
    private List<MovieGenre> categories = new List<MovieGenre>();
    string movie_name = "";
    string categorySelected = "";
    private bool futurosEstrenos = false;
    private bool enCartelera = false;
    private bool mejorCalificada = false;

    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

    private void ShowMovies()
    {
        Movies = movie.GetMovies().Where(x=>x.Name.ToLower().Contains(movie_name.ToLower())).ToList();
        Console.WriteLine($"Pelicula: {movie_name}, categoría seleccionada {categorySelected}");
        Console.WriteLine($"Próximos estrenos {futurosEstrenos}, en cartelera: {enCartelera} mejor calificada {mejorCalificada}");
    }

private void ClearInputs(){
    Movies = movie.GetMovies();
    movie_name = "";
    categorySelected = "0";
    futurosEstrenos = false;
    enCartelera = false;
    mejorCalificada = false;
}

    private void MovieSearch(KeyboardEventArgs e)
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
