#pragma checksum "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c5f413d1fb0634dd71b334fa74fbbfe7226a70"
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
    public partial class FormActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "placeholder", "Actor");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                                              Actor.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Name = __value, Actor.Name))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n                ");
                __Blazor.ProjectMovies5.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 7 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                          ()=>Actor.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row mb-3");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-sm-8");
                __Blazor.ProjectMovies5.Client.Pages.Components.FormActor.TypeInference.CreateInputDate_1(__builder2, 26, 27, "form-control", 28, 
#nullable restore
#line 11 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                                                  Actor.BirthDate

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.BirthDate = __value, Actor.BirthDate)), 30, () => Actor.BirthDate);
                __builder2.AddMarkupContent(31, "\n                    ");
                __Blazor.ProjectMovies5.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_2(__builder2, 32, 33, 
#nullable restore
#line 12 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                              ()=>Actor.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-sm-4");
                __Blazor.ProjectMovies5.Client.Pages.Components.FormActor.TypeInference.CreateInputNumber_3(__builder2, 37, 38, "form-control", 39, "Cantidad de créditos", 40, 
#nullable restore
#line 16 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                                                    Actor.KnowCredits

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.KnowCredits = __value, Actor.KnowCredits)), 42, () => Actor.KnowCredits);
                __builder2.AddMarkupContent(43, "\n                    ");
                __Blazor.ProjectMovies5.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_4(__builder2, 44, 45, 
#nullable restore
#line 18 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                              ()=>Actor.KnowCredits

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.OpenComponent<ProjectMovies5.Client.Pages.Components.ImageComponent>(49);
                __builder2.AddAttribute(50, "Label", "photo");
                __builder2.AddAttribute(51, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 23 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                                             ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(52, "ImageURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
                                                                                       imageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n            <div class=\"form-group\"></div>\n            ");
                __builder2.AddMarkupContent(54, "<button class=\"btn btn-success\">Guardar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\mintic\ProjectMovies5\Client\Pages\Components\FormActor.razor"
       
    string imageURL;
    [Parameter] public Actor Actor { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(Actor.Photo))
        {
            imageURL = Actor.Photo;
            Actor.Photo = null;
        }
    }

    private void ImageSelected(string imageB64)
    {
        Actor.Photo = imageB64;
        imageURL = null;
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ProjectMovies5.Client.Pages.Components.FormActor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
