#pragma checksum "D:\mintic\ProjectMovies5\Client\Pages\Components\ShowMovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "070d98142f731a3cb862d46b0e03f9042eb08e38"
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
    public partial class ShowMovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "text-center");
            __builder.AddMarkupContent(4, "\r\n        Nombre:\r\n        ");
            __builder.OpenElement(5, "small");
            __builder.AddAttribute(6, "class", "text-muted");
            __builder.AddContent(7, 
#nullable restore
#line 4 "D:\mintic\ProjectMovies5\Client\Pages\Components\ShowMovieComponent.razor"
                                   movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 8 "D:\mintic\ProjectMovies5\Client\Pages\Components\ShowMovieComponent.razor"
              movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "imgfluid");
            __builder.AddAttribute(16, "alt", "Responsive image");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.OpenElement(20, "blockquote");
            __builder.AddAttribute(21, "class", "blockquote text-center");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "mb-0");
            __builder.AddContent(24, "Sinopsis: ");
            __builder.AddContent(25, 
#nullable restore
#line 12 "D:\mintic\ProjectMovies5\Client\Pages\Components\ShowMovieComponent.razor"
                                   movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "footer");
            __builder.AddAttribute(28, "class", "blockquotefooter");
            __builder.AddContent(29, "Fecha de Estreno ");
            __builder.OpenElement(30, "cite");
            __builder.AddAttribute(31, "title", "Source Title");
            __builder.AddContent(32, 
#nullable restore
#line 14 "D:\mintic\ProjectMovies5\Client\Pages\Components\ShowMovieComponent.razor"
                                      movie.Premier

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
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\mintic\ProjectMovies5\Client\Pages\Components\ShowMovieComponent.razor"
      
    [Parameter]
    public Movie movie{get;set;}
    
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
