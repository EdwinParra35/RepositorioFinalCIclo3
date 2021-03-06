#pragma checksum "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\CreateCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "776912402b473b185c7f993c6e72f1a397d799d6"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Pages.Categories
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
#nullable restore
#line 2 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\CreateCategory.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/create")]
    public partial class CreateCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h6>Crear Categoria</h6>\r\n");
            __builder.OpenComponent<MovieProject.Client.Pages.Categories.FormCategory>(1);
            __builder.AddAttribute(2, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MovieProject.Shared.Entity.Category>(
#nullable restore
#line 8 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\CreateCategory.razor"
                        Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\CreateCategory.razor"
                                                 Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\CreateCategory.razor"
      
    private Category Category = new Category();

    private async Task Create(){
        var httpResponse = await movie.Post("api/categories", Category);
        if(httpResponse.Error){
            var body = await httpResponse.GetBody();
            await showMessage.ShowErrorMessage(body);
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Categories\CreateCategory.razor"
                                      
        }else{
            navigationManager.NavigateTo("/categories");
        }
        Console.WriteLine($"Creando la categoria {Category.Name}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
