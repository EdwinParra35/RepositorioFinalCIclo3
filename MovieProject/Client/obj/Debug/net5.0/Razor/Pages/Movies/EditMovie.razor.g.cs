#pragma checksum "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461b782a4b6b4523c8314dcde79d4bd1f6e0da8e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
using MovieProject.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
using MovieProject.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{Id:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Pelicula</h3>");
#nullable restore
#line 10 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
 if (Movie == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"alert alert-info\" role=\"alert\">Cargando</div>");
#nullable restore
#line 13 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MovieProject.Client.Pages.Components.FormMovie>(2);
            __builder.AddAttribute(3, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MovieProject.Shared.Entity.Movie>(
#nullable restore
#line 17 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
                      Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
                                            Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ActoresSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Shared.Entity.Actor>>(
#nullable restore
#line 18 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
                                               ActoresSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "CategoriasNoSeleccionadas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Shared.Entity.Category>>(
#nullable restore
#line 19 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
                                                    CategoriasNoSeleccionadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "CategoriasSeleccionadas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MovieProject.Shared.Entity.Category>>(
#nullable restore
#line 20 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
                                                  CategoriasSeleccionadas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 21 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Movies\EditMovie.razor"
       
    [Parameter] public int Id { get; set; }
    Movie Movie;
    private List<Category> CategoriasSeleccionadas = new List<Category>();
    private List<Category> CategoriasNoSeleccionadas = new List<Category>();
    private List<Actor> ActoresSeleccionados { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await movie_i.Get<PutMovie>($"api/movies/edit/{Id}");

        if (httpResponse.Error)
        {
            if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("");
            }
            else
            {
                await showMessage.ShowErrorMessage(await httpResponse.GetBody());
            }
        }
        else
        {
            var model = httpResponse.Response;
            ActoresSeleccionados = model.Actors;
            CategoriasNoSeleccionadas = model.CategoriasNoSeleccionadas;
            CategoriasSeleccionadas = model.CategoriasSeleccionadas;
            Movie = model.Movie;
        }
    }

    private async Task Edit()
    {
        var httpResponse = await movie_i.Put("api/movies", Movie);
        if (httpResponse.Error)
        {
            await showMessage.ShowErrorMessage(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo($"movie/{Id}");
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
