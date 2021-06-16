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
#line 2 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
       


    IEnumerable<Person> people = new List<Person>();
    public int idPerson { get; set; }
    protected override async Task OnInitializedAsync()
    {
        people = await SwapiService.GetAllPeople( 1 );
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
         foreach (var person in people) {

            string url = person.Url;
            string b = string.Empty;

            for (int i=0; i< url.Length; i++)
            {
                if (Char.IsDigit( url[i]))
                    b += url[i];
            }
            if ( b.Length > 0 )
                idPerson = int.Parse( b );
            person.id = idPerson;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
         

    }

    public async Task PaginaSeleccionada( int pagina )
    {

        people = await SwapiService.GetAllPeople( pagina );
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
         foreach (var person in people) {

            string url = person.Url;
            string b = string.Empty;

            for (int i=0; i< url.Length; i++)
            {
                if (Char.IsDigit( url[i]))
                    b += url[i];
            }
            if ( b.Length > 0 )
                idPerson = int.Parse( b );
            person.id = idPerson;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\Alex\source\repos\RavnRazorChallenge\RavnRazorChallenge\Pages\People.razor"
         
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISwapiService SwapiService { get; set; }
    }
}
#pragma warning restore 1591
