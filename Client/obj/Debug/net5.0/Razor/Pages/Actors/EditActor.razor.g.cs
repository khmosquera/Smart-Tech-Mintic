#pragma checksum "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Actors\EditActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a671dbf77d0344f678a1cfdb76bd84e293cdb7a1"
// <auto-generated/>
#pragma warning disable 1591
namespace PeliculaIISemanaIV.Client.Pages.Actors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Actors\EditActor.razor"
using PeliculaIISemanaIV.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/edit/{Id:int}")]
    public partial class EditActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PeliculaIISemanaIV.Client.Pages.Components.FormActor>(0);
            __builder.AddAttribute(1, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PeliculaIISemanaIV.Shared.Entity.Actor>(
#nullable restore
#line 4 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Actors\EditActor.razor"
                    Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Actors\EditActor.razor"
                                          Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Actors\EditActor.razor"
                                       
    
    [Parameter] public int Id{get;set;}
    Actor Actor = new Actor();
    protected override void OnInitialized(){
        Actor = new Actor(){
            Id = Id,
            Name = "Cobbie Smulders",
            KnowCredits = 18,
            BirthDate = DateTime.Today
        };
    } 

    void Edit(){
       Console.WriteLine("Información del actor actualizada");
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
