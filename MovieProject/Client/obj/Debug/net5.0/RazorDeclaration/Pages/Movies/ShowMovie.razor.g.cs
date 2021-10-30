// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MovieProject.Client.Pages.Movies
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
#line 3 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\ShowMovie.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{Id:int}/{Name}")]
    public partial class ShowMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\ShowMovie.razor"
       
    [Parameter] public int Id { get; set; }
    [Parameter] public string Name { get; set; }
    private ShowMovieDB model;
    private RenderFragment<Category> linkCategory = (category) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "movies/search?categoryId=" + (
#nullable restore
#line 54 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                     category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(2, 
#nullable restore
#line 54 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                                   category.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 54 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\ShowMovie.razor"
                                                                                                                                    ;

    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await movie_i.Get<ShowMovieDB>($"api/movies/{Id}");
        if (responseHttp.Error)
        {
            if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("");
            }
            else
            {
                var mensajeError = await responseHttp.GetBody();
                await showMessage.ShowErrorMessage(mensajeError);
            }
        }
        else
        {
            model = responseHttp.Response;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage showMessage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie_i { get; set; }
    }
}
#pragma warning restore 1591
