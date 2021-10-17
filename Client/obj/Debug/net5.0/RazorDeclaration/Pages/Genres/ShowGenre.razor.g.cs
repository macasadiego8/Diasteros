// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectMovies5.Client.Pages.Genres
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using ProjectMovies5.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using ProjectMovies5.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using ProjectMovies5.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using ProjectMovies5.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mintic\Diasteros-devAGG\Client\Pages\Genres\ShowGenre.razor"
using ProjectMovies5.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/genres")]
    public partial class ShowGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\mintic\Diasteros-devAGG\Client\Pages\Genres\ShowGenre.razor"
       

    public List<MovieGenre> MovieGenres { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await Load();
    }
    private async Task Load()
    {
        var responseHttp = await movie.Get<List<MovieGenre>>("api/moviegenres");
        MovieGenres = responseHttp.Response;
    }

    private async Task DeleteMovieGenre(MovieGenre moviegenre)    {

        var responseHttp = await movie.Delete($"api/moviegenres/{moviegenre.Id}");
        if (responseHttp.Error)
        {

            await showMessage.ShowErrorMessage(await responseHttp.GetBody());
        }
        else
        {
            await Load();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
