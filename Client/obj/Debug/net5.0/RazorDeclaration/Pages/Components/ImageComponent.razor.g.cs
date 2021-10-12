// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectMovies5.Client.Pages.Components
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
#line 13 "D:\mintic\Diasteros-devAGG\Client\_Imports.razor"
using ProjectMovies5.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    public partial class ImageComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\mintic\Diasteros-devAGG\Client\Pages\Components\ImageComponent.razor"
       
    [Parameter] public string Label { get; set; } = "Imagen";
    [Parameter] public string ImageURL { get; set; }
    [Parameter] public EventCallback<string> ImageSelected { get; set; }
    private string imageT;
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var images = e.GetMultipleFiles();
        foreach (var image in images)
        {
            var tamaño = new byte[image.Size];
            await image.OpenReadStream().ReadAsync(tamaño);
            imageT = Convert.ToBase64String(tamaño);
            ImageURL = null;
            await ImageSelected.InvokeAsync(imageT);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
