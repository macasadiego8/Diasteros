#pragma checksum "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01bc2c8643536d11480b22c1735222ce04cae3a3"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectMoviesDiasteros.Client.Pages.Components
{
    #line hidden
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
#line 1 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeaHead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style type=\"text/css\">\r\n.blazored-typeahead {\r\nposition: relative;\r\nwidth: 100%;\r\nborder: 1px solid #bfbfbf;\r\nborder-radius: 5px;\r\n}\r\n.blazored-typeahead.valid.modified {\r\noutline: none !important;\r\nborder: 1px solid #26b050;\r\n}\r\n.blazored-typeahead.invalid {\r\noutline: none !important;\r\nborder: 1px solid red;\r\n}\r\n.blazored-typeahead__controls {\r\nposition: relative;\r\ncursor: text;\r\ndisplay: flex;\r\n}\r\n.blazored-typeahead__input {\r\nflex: 1;\r\nmax-width: 100%;\r\nborder: none;\r\npadding: .5rem;\r\nborder-radius: 5px;\r\n}\r\n.blazored-typeahead:focus-within {\r\nbox-shadow: 0 0 0 0.2rem rgba(38,143,255,.5);\r\n}\r\n\r\n.blazored-typeahead__input:focus {\r\noutline: none;\r\n}\r\n.blazored-typeahead__input-multi:focus {\r\noutline: none;\r\nbox-shadow: none;\r\n}\r\n.blazored-typeahead__input-hidden {\r\ndisplay: none;\r\n}\r\n.invalid {\r\nborder-color: red !important;\r\n}\r\n.blazored-typeahead__input-mask-wrapper {\r\ndisplay: flex;\r\nwidth: 100%;\r\n}\r\n.blazored-typeahead__input-multiselect-wrapper {\r\ndisplay: flex;\r\nflex-direction: row;\r\nwidth: 100%;\r\nflex-wrap: wrap;\r\n}\r\n.blazored-typeahead__input-mask-wrapper--disabled {\r\nbackground-color: #e9ecef;\r\ncursor: not-allowed;\r\nborder-radius: 5px 0 0 5px;\r\ncolor: grey;\r\nmin-height: 40px;\r\n}\r\n.blazored-typeahead__input-mask-wrapper--disabled:focus {\r\nborder: none;\r\n}\r\n.blazored-typeahead__input-mask {\r\ndisplay: flex;\r\nalign-items: center;\r\nflex: 1;\r\nborder-radius: 5px 0 0 5px;\r\npadding: .5rem;\r\n}\r\n.blazored-typeahead__input-mask:focus {\r\noutline: none;\r\n}\r\n.blazored-typeahead__clear {\r\nwidth: 40px;\r\ndisplay: flex;\r\npadding: .5rem;\r\nalign-items: center;\r\njustify-content: center;\r\n\r\ncursor: pointer;\r\ncolor: #dbdbdb;\r\n}\r\n.blazored-typeahead__clear:hover {\r\ncolor: #333333;\r\n}\r\n.blazored-typeahead__down-arrow path {\r\nfill: #dbdbdb;\r\n}\r\n.blazored-typeahead__input-icon {\r\nwidth: 40px;\r\ndisplay: flex;\r\nborder-radius: 0 5px 5px 0;\r\npadding: .5rem;\r\ncursor: pointer;\r\nbackground: none;\r\n}\r\n.blazored-typeahead__input-icon:focus {\r\noutline: none;\r\nbox-shadow: 0 0 0 0.2rem rgba(38,143,255,.5);\r\n}\r\n.blazored-typeahead__input-icon:hover {\r\nbackground-color: #f5f5f5;\r\n}\r\n\r\n.blazored-typeahead__input-icon:hover .blazored-typeahead__down-\r\narrow path {\r\n\r\nfill: #333333;\r\n}\r\n.blazored-typeahead__input-icon--disabled,\r\n.blazored-typeahead__input-icon--disabled:hover {\r\nbackground-color: #e9ecef;\r\ncursor: not-allowed;\r\n}\r\n\r\n.blazored-typeahead__input-icon--disabled .blazored-typeahead__down-\r\narrow path,\r\n\r\n.blazored-typeahead__input-icon--disabled:hover .blazored-\r\ntypeahead__down-arrow path {\r\n\r\nfill: #9c9c9c;\r\n}\r\n.blazored-typeahead__multi-value {\r\nbackground-color: #dbdbdb;\r\ndisplay: flex;\r\nalign-items: center;\r\nmin-width: 0px;\r\nbox-sizing: border-box;\r\nborder-radius: 2px;\r\nmargin: .4rem 0 .4rem .4rem;\r\n}\r\n.blazored-typeahead__multi-value-label {\r\ncolor: rgb(51, 51, 51);\r\nfont-size: 85%;\r\n\r\ntext-overflow: ellipsis;\r\nwhite-space: nowrap;\r\nbox-sizing: border-box;\r\nborder-radius: 2px;\r\noverflow: hidden;\r\npadding: 3px 3px 3px 6px;\r\n}\r\n.blazored-typeahead__multi-value-clear {\r\n-webkit-box-align: center;\r\nalign-items: center;\r\ndisplay: flex;\r\npadding-left: 4px;\r\npadding-right: 4px;\r\nbox-sizing: border-box;\r\nborder-radius: 2px;\r\nbackground-color: transparent;\r\nborder: 0;\r\noutline: none;\r\n}\r\n.blazored-typeahead__multi-value-clear:focus {\r\noutline: none;\r\n}\r\n.blazored-typeahead__multi-value-clear:hover {\r\nbackground-color: rgb(212, 212, 212);\r\ncolor: rgb(222, 53, 11);\r\n}\r\n.blazored-typeahead__results {\r\nposition: absolute;\r\nbox-shadow: 0 5px 10px rgba(0,0,0,.2);\r\nborder: 1px solid #dbdbdb;\r\nmin-height: 2rem;\r\nmax-height: 30rem;\r\noverflow-y: auto;\r\nz-index: 10;\r\nwidth: 100%;\r\nbackground: #fff;\r\n}\r\n.blazored-typeahead__result,\r\n.blazored-typeahead__notfound,\r\n.blazored-typeahead__results-help-template,\r\n.blazored-typeahead__results-header,\r\n.blazored-typeahead__results-footer {\r\npadding: .5rem;\r\nborder-top: 1px solid #fff;\r\nborder-bottom: 1px solid #fff;\r\n}\r\n.blazored-typeahead__selected-item {\r\nbackground-color: #dbdbdb;\r\n}\r\n.blazored-typeahead__selected-item-highlighted {\r\nbackground-color: #d3e2f2;\r\n}\r\n.blazored-typeahead__active-item,\r\n\r\n.blazored-typeahead__result:hover,\r\n.blazored-typeahead__result:focus {\r\nbackground-color: #007bff;\r\nborder-top: 1px solid #007bff;\r\nborder-bottom: 1px solid #007bff;\r\ncolor: #fff;\r\ncursor: pointer;\r\n}\r\n.blazored-typeahead__loader {\r\nwidth: 24px;\r\nheight: 24px;\r\nbackground-color: #333;\r\nborder-radius: 100%;\r\n-webkit-animation: sk-scaleout 1.0s infinite ease-in-out;\r\nanimation: sk-scaleout 1.0s infinite ease-in-out;\r\n}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "blazored-typeahead");
            __builder.AddElementReferenceCapture(3, (__value) => {
#nullable restore
#line 222 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                                      typeahead = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "blazored-typeahead__controls");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "blazored-typeahead__input");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 228 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                           ShowSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "autocomplete", "off");
            __builder.AddAttribute(11, "placeholder", 
#nullable restore
#line 231 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                              Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 226 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                              SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddElementReferenceCapture(14, (__value) => {
#nullable restore
#line 224 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                     searchInput = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 233 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
     if (ShouldShowSuggestions())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "blazored-typeahead__results");
#nullable restore
#line 236 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
             foreach (var item in Suggestions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "blazored-typeahead__result" + "\r\n                " + (
#nullable restore
#line 239 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                 GetSelectedSuggestionClass(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "tabindex", "0");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 240 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                            () => SelectResult(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 240 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                                                                 ((e) =>HandleKeyUpOnSuggestion(e,item))

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 238 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                           item

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 241 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                     if (ResultTemplate != null)
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, 
#nullable restore
#line 243 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                         ResultTemplate(item)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 243 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                                             
                    } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 246 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 248 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "blazored-typeahead__results");
#nullable restore
#line 252 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "blazored-typeahead__notfound");
            __builder.AddContent(27, 
#nullable restore
#line 255 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
                     NotFoundTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 257 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<div class=\"blazored-typeahead__notfound\">\r\n                    No Results Found\r\n                </div>");
#nullable restore
#line 263 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 265 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 267 "C:\ProysCicloIII\ProjectMoviesDiasteros\Client\Pages\Components\CustomTypeaHead.razor"
      
    [Parameter] public string Placeholder { get; set; }
    [Parameter] public TItem Value { get; set; }
    [Parameter] public EventCallback<TItem> ValueChanged { get; set; }
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment NotFoundTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> SelectedTemplate { get; set; }
    [Parameter] public RenderFragment FooterTemplate { get; set; }
    [Parameter] public int MinimumLength { get; set; } = 1;
    [Parameter] public int Debounce { get; set; } = 300;
    [Parameter] public int MaximumSuggestions { get; set; } = 25;
    [Parameter] public bool DisplayClear { get; set; } = true;
    protected bool IsSearching { get; private set; } = false;
    protected bool IsShowingSuggestions { get; private set; } = false;
    protected bool IsShowingSearchbar { get; private set; } = true;
    protected bool IsShowingMask { get; private set; } = false;
    protected TItem[] Suggestions { get; set; } = new TItem[0];
    protected string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            if (value.Length == 0)
            {
                _debounceTimer.Stop();
                Suggestions = new TItem[0];
            }
            else if (value.Length >= MinimumLength)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }
        }
    }
    protected ElementReference searchInput;
    protected ElementReference typeahead;
    private Timer _debounceTimer;
    private string _searchText = string.Empty;
    protected override void OnInitialized()
    {
        if (SearchMethod == null)
        {
            throw new InvalidOperationException($"{GetType()} requires a {nameof(SearchMethod)} parameter.");
        }
        if (ResultTemplate == null)
        {
            throw new InvalidOperationException($"{GetType()} requires a {nameof(ResultTemplate)} parameter.");
        }
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;
        
        Initialize();
    }
    protected override void OnParametersSet()
    {
        Initialize();
    }
    private void Initialize()
    {
        IsShowingSuggestions = false;
        if (Value == null)
        {
            IsShowingMask = false;
            IsShowingSearchbar = true;
        }
        else
        {
            IsShowingSearchbar = false;
            IsShowingMask = true;
        }
    }
    protected void HandleClickOnMask()
    {
        IsShowingMask = false;
        IsShowingSearchbar = true;
    }
    protected async Task ShowMaximumSuggestions()
    {
        IsShowingSuggestions = !IsShowingSuggestions;
        if (IsShowingSuggestions)
        {
            SearchText = "";
            IsSearching = true;
            await InvokeAsync(StateHasChanged);
            Suggestions = (await SearchMethod?.Invoke(_searchText)).Take(MaximumSuggestions).ToArray();
            IsSearching = false;
            await InvokeAsync(StateHasChanged);
        }
    }
    protected void ShowSuggestions()
    {
        if (Suggestions.Any())
        {
            IsShowingSuggestions = true;
        }
    }
    protected async Task HandleKeyUpOnSuggestion(KeyboardEventArgs args, TItem item)
    {
        // Maybe on any key except Tab and Enter, continue the typing option.
        switch(args.Key)
        {
            case "Enter":
                await SelectResult(item);
                break;
            case "Escape":
            case "Backspace":
            case "Delete":
            Initialize();
                break;
            default:
                break;
        }
    }
    protected async Task HandleKeyUpOnShowMaximum(KeyboardEventArgs args)
    {
        if (args.Key == "Enter")
        await ShowMaximumSuggestions();
    }
    protected string GetSelectedSuggestionClass(TItem item)
    {
        if (Value == null)
            return null;
        if (Value.Equals(item))
            return "blazored-typeahead__result-selected";
        return null;
    }
    protected async void Search(Object source, ElapsedEventArgs e)
    {
        IsSearching = true;
        await InvokeAsync(StateHasChanged);
        Suggestions = (await SearchMethod?.Invoke(_searchText)).Take(MaximumSuggestions).ToArray();
        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }
    protected async Task SelectResult(TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }
    protected bool ShouldShowSuggestions()
    {
        return IsShowingSuggestions &&
        Suggestions.Any();
    }
    private bool HasValidSearch => !string.IsNullOrWhiteSpace(SearchText) && SearchText.Length >= MinimumLength;
    private bool IsSearchingOrDebouncing => IsSearching || _debounceTimer.Enabled;
    
    protected bool ShowNotFound()
    {
        return IsShowingSuggestions &&
        HasValidSearch &&
        !IsSearchingOrDebouncing &&
        !Suggestions.Any();
    }
    protected void OnFocusOut(object sender, EventArgs e)
    {
        Initialize();
        InvokeAsync(StateHasChanged);
    }
    protected void OnEscape(object sender, EventArgs e)
    {
        Initialize();
        InvokeAsync(StateHasChanged);
    }
    public void Dispose()
    {
        _debounceTimer.Dispose();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
