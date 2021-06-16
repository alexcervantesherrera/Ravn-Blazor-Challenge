#pragma checksum "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8d6607810a5cc348bbabc1a298eb1307f7c4d5"
// <auto-generated/>
#pragma warning disable 1591
namespace RavnRazorChallenge.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using RavnRazorChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\_Imports.razor"
using RavnRazorChallenge.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/films")]
    public partial class Films : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Films</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
 if ( films == null )
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
                <tr class=""main-header-grid"">
                    <th>Title</th>
                    <th>Director</th>
                    <th>Producer </th>
                    <th>Release Date </th>
                </tr>
            </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 26 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
         foreach ( var film in films )
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "class", "main-row-grid");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
                     film.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
                     film.Director

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
                     film.Producer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
                     film.ReleaseDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 34 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 37 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Films.razor"
       

    IEnumerable<Film> films = new List<Film>();
    protected override async Task OnInitializedAsync()
    {
        films = await SwapiService.GetAllFilms();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISwapiService SwapiService { get; set; }
    }
}
#pragma warning restore 1591