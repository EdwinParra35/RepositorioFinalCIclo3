#pragma checksum "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8fcaf9ee1b73b71a7270f43fba0a7997770d8f"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\_Imports.razor"
using MovieProject.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-4auyzqk7xp");
#nullable restore
#line 6 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Shared\MainLayout.razor"
     if (expandSubNav)
    {
        
    }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-4auyzqk7xp");
            __builder.OpenComponent<MovieProject.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 13 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Shared\MainLayout.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main");
            __builder.AddAttribute(9, "b-4auyzqk7xp");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "top-row px-1");
            __builder.AddAttribute(12, "b-4auyzqk7xp");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "nav-link ");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Shared\MainLayout.razor"
                                             ()=>expandSubNav = !expandSubNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-4auyzqk7xp");
            __builder.AddMarkupContent(17, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-4auyzqk7xp></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            <a target=\"_blank\" class=\"ml-md-auto\" b-4auyzqk7xp></a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "content px-4");
            __builder.AddAttribute(22, "b-4auyzqk7xp");
            __builder.AddContent(23, 
#nullable restore
#line 24 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Shared\MainLayout.razor"
       

    private bool expandSubNav=false;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
