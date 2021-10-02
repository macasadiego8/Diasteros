#pragma checksum "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd57840e71e7b2c225aa4ae35502207ce36b90fc"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectMovies5.Client.Pages.Components
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
#line 13 "D:\mintic\ProjectMovies5\Client\_Imports.razor"
using ProjectMovies5.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    public partial class CardComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddAttribute(2, "b-jrd8djhg0c");
#nullable restore
#line 2 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
     if (Movies == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<label b-jrd8djhg0c><small class=\"text-muted\" b-jrd8djhg0c>Buscando películas</small></label>\n        <img src=\"/Images/load.gif\" height=\"40\" width=\"40\" b-jrd8djhg0c>");
#nullable restore
#line 6 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
    }else if (Movies.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<label b-jrd8djhg0c><small class=\"text-muted\" b-jrd8djhg0c>No se encontraron registros</small></label>");
#nullable restore
#line 9 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid");
            __builder.AddAttribute(7, "b-jrd8djhg0c");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row mb-3");
            __builder.AddAttribute(10, "b-jrd8djhg0c");
#nullable restore
#line 14 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                 foreach (var movie in Movies)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-2 col-md-4");
            __builder.AddAttribute(13, "b-jrd8djhg0c");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-flex-md-row mb-3 box-shadow h-md-200");
            __builder.AddAttribute(16, "b-jrd8djhg0c");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body d-flex flex-column align-items-start");
            __builder.AddAttribute(19, "b-jrd8djhg0c");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card bg");
            __builder.AddAttribute(22, "b-jrd8djhg0c");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 20 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                               movie.UriImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "class", "img-thumbnail card-img-top");
            __builder.AddAttribute(26, "alt", "Card image cap");
            __builder.AddAttribute(27, "height", "auto");
            __builder.AddAttribute(28, "width", "auto");
            __builder.AddAttribute(29, "b-jrd8djhg0c");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-body");
            __builder.AddAttribute(33, "b-jrd8djhg0c");
            __builder.OpenElement(34, "h6");
            __builder.AddAttribute(35, "class", "card-title");
            __builder.AddAttribute(36, "b-jrd8djhg0c");
            __builder.AddContent(37, 
#nullable restore
#line 22 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                                                movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                                        ");
            __builder.OpenElement(39, "p");
            __builder.AddAttribute(40, "class", "text-muted");
            __builder.AddAttribute(41, "b-jrd8djhg0c");
            __builder.AddContent(42, 
#nullable restore
#line 24 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                             movie.Synopsis

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\n                                            <br b-jrd8djhg0c>\n                                            ");
            __builder.AddContent(44, 
#nullable restore
#line 26 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                             movie.Genre

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\n                                            <br b-jrd8djhg0c>\n                                            ");
            __builder.OpenElement(46, "small");
            __builder.AddAttribute(47, "b-jrd8djhg0c");
            __builder.AddContent(48, 
#nullable restore
#line 28 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                                    movie.Cast

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                                            <br b-jrd8djhg0c>\n                                            ");
            __builder.OpenElement(50, "small");
            __builder.AddAttribute(51, "b-jrd8djhg0c");
            __builder.AddContent(52, 
#nullable restore
#line 30 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                                    movie.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
    
    [Parameter] public List<Movie> Movies2{get;set;}
    public List<Movie> Movies;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\mintic\ProjectMovies5\Client\Pages\Components\CardComponent.razor"
                                                                       
    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(500);
        Movies = Movies2;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
