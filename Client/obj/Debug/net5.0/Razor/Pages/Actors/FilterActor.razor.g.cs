#pragma checksum "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3fe34bfcb21030d717f266f19a780e7bb1b6c08"
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
#line 2 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
using ProjectMoviesDiasteros.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/filter")]
    public partial class FilterActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-3");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 8 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                                                                  (KeyboardEventArgs e)=>SearchActors(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "actorName");
            __builder.AddAttribute(11, "placeholder", "Buscar actor");
            __builder.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                            actorName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => actorName = __value, actorName));
            __builder.SetUpdatesAttributeName("Value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "        \r\n        ");
            __builder.OpenElement(15, "div");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                                                 ShowActors

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "btn btn-secondary mb-2 mx-sm-3");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                                                   CleanFields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Cancelar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenComponent<ProjectMoviesDiasteros.Client.Pages.Components.ServiceActorComponent>(28);
            __builder.AddAttribute(29, "Actors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ProjectMoviesDiasteros.Shared.Entity.Actor>>(
#nullable restore
#line 15 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                               Actors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
 
    private List<Actor> Actors;    
    string actorName = "";
    
    protected override void OnInitialized()
    {
        Actors = actor.GetActors();
    }

    private void ShowActors()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                                                                              
        Actors = actor.GetActors().Where(x => x.Name.ToLower().Contains(actorName.ToLower())).ToList();
        Console.WriteLine($"Actor: {actorName}");
        
    }

    private void CleanFields()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                           
        Actors = actor.GetActors(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                                                                        
        actorName = ""; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Actors\FilterActor.razor"
                                                                       
    }

    private void SearchActors(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            ShowActors();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceActor actor { get; set; }
    }
}
#pragma warning restore 1591
