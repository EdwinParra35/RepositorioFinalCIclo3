#pragma checksum "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31122930faa3f36c9de2679d59a61e33052eeba1"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieProject.Client.Pages.Components
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
#line 3 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-gropup");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col col-sm-12 col-lg-7");
                __builder2.OpenElement(16, "div");
                __builder2.AddMarkupContent(17, "<label>Nombre del Actor:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "Actor");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                          Actor.ActorName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.ActorName = __value, Actor.ActorName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.ActorName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 12 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                      ()=>Actor.ActorName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col col-sm-12 col-lg-5");
                __builder2.AddMarkupContent(30, "<label>Fecha de Nacimiento:</label>\r\n                        ");
                __builder2.OpenElement(31, "div");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateInputDate_1(__builder2, 32, 33, "form-control", 34, 
#nullable restore
#line 18 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                          Actor.BirthDate

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.BirthDate = __value, Actor.BirthDate)), 36, () => Actor.BirthDate);
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_2(__builder2, 38, 39, 
#nullable restore
#line 19 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                      ()=>Actor.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col col-sm-12 col-lg-7");
                __builder2.OpenElement(45, "div");
                __builder2.AddMarkupContent(46, "<label>Creditos  del Actor:</label>\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateInputNumber_3(__builder2, 47, 48, "form-control", 49, 
#nullable restore
#line 27 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                            Actor.KnowCredits

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.KnowCredits = __value, Actor.KnowCredits)), 51, () => Actor.KnowCredits);
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_4(__builder2, 53, 54, 
#nullable restore
#line 29 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                      ()=>Actor.KnowCredits

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col col-sm-12 col-lg-5  ");
                __builder2.AddMarkupContent(58, "<label>Nomincaciones del Actor:</label>\r\n                        ");
                __builder2.OpenElement(59, "div");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateInputNumber_5(__builder2, 60, 61, "form-control", 62, 
#nullable restore
#line 35 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                            Actor.Nominations

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Nominations = __value, Actor.Nominations)), 64, () => Actor.Nominations);
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_6(__builder2, 66, 67, 
#nullable restore
#line 37 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                      ()=>Actor.Nominations

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col");
                __builder2.AddMarkupContent(73, "<label>Biografia:</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "placeholder", "Biografia");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                          Actor.Biography

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Biography = __value, Actor.Biography))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.Biography));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __Blazor.MovieProject.Client.Pages.Components.FormActor.TypeInference.CreateValidationMessage_7(__builder2, 81, 82, 
#nullable restore
#line 45 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                  ()=>Actor.Biography

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            <p></p>\r\n            ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group");
                __builder2.OpenComponent<MovieProject.Client.Pages.Components.ImageComponent>(86);
                __builder2.AddAttribute(87, "Label", "Photo");
                __builder2.AddAttribute(88, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 51 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                 ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(89, "imageURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
                                                                                           imageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n            <div class=\"form-group\"></div>\r\n            ");
                __builder2.AddMarkupContent(91, "<button class=\"btn btn-success\" type=\"submit\">Guardar cambios</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "E:\MisticCiclo3DesarrolloSoftwre\Sprint_V\MinTIC_g02_TicDigitalG8\Sprint V\Codigo Fuente\MovieProject\Client\Pages\Components\FormActor.razor"
       
    private string imageURL;
    [Parameter] public Actor Actor { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrWhiteSpace(Actor.Photo))
        {
            imageURL = Actor.Photo;
            Console.WriteLine(imageURL);
            Actor.Photo = null;
        }
    }

    private void ImageSelected(string imagenBase64)
    {
        Actor.Photo = imagenBase64;
        imageURL = null;
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MovieProject.Client.Pages.Components.FormActor
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
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
