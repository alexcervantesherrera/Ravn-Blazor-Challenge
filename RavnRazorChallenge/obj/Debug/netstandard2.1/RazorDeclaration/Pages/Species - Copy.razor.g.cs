// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Species - Copy.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Species - Copy.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/species")]
    public partial class Species___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\Species - Copy.razor"
       

    IEnumerable<Specie> species = new List<Specie>();
    protected override async Task OnInitializedAsync()
    {
        species = await SwapiService.GetAllSpecies();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISwapiService SwapiService { get; set; }
    }
}
#pragma warning restore 1591
