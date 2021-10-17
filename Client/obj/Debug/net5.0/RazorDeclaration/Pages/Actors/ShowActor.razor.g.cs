// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectMoviesDiasteros.Client.Pages.Actors
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
#line 3 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\ShowActor.razor"
using ProjectMoviesDiasteros.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors")]
    public partial class ShowActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\ShowActor.razor"
       
    public List<Actor> Actors { get; set; }
    protected async override Task OnInitializedAsync()
    {
 
        await Load();
    }
    private async Task Load()
    {
        var responseHttp = await movie.Get<List<Actor>>("api/actors");
        Actors = responseHttp.Response;
    }
 
    private async Task DeleteActor(Actor Actor){
        var responseHttp = await movie.Delete($"api/actors/{Actor.Id}");
        if (responseHttp.Error)
        {
            await showMessage.ShowErrorMessage(await responseHttp.GetBody());
        }else{
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
