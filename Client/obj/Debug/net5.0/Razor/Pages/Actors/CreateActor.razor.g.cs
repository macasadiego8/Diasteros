#pragma checksum "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\CreateActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a138953bd2a6336becddb48917335557f0b362bf"
// <auto-generated/>
#pragma warning disable 1591
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
using ProjectMoviesDiasteros.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\CreateActor.razor"
using ProjectMoviesDiasteros.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/create")]
    public partial class CreateActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProjectMoviesDiasteros.Client.Pages.Components.FormActor>(0);
            __builder.AddAttribute(1, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProjectMoviesDiasteros.Shared.Entity.Actor>(
#nullable restore
#line 4 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\CreateActor.razor"
                  Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\CreateActor.razor"
                                        Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\CreateActor.razor"
 
    private Actor Actor = new Actor();
    void Create()
    {
        Console.WriteLine($"Actor: {Actor.Name}");
        Console.WriteLine($"Fecha de nacimiento: {Actor.BirthDate}");
        Console.WriteLine($"Cantidad de créditos: {Actor.KnowCredits}");
        Console.WriteLine($"Foto base64: {Actor.Photo}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
