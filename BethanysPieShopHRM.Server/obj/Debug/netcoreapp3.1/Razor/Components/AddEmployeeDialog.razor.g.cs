#pragma checksum "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "828a4abfe2414491a0afc3408bc4c176ce75a5de"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Server.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    public partial class AddEmployeeDialog : AddEmployeeDialogBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
 if (ShowDialog)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h5 class=\"modal-title\" id=\"titleLabel\">Employee Quick Add</h5>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                        Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "aria-label", "Close");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(38);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n\r\n                        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.AddMarkupContent(43, "<label for=\"lastName\">Last name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "lastName");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "placeholder", "Enter last name");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                        Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_0(__builder2, 52, 53, 
#nullable restore
#line 25 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                      () => Employee.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.AddMarkupContent(59, "<label for=\"firstName\">First name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "id", "firstName");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "placeholder", "Enter first name");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                         Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_1(__builder2, 68, 69, 
#nullable restore
#line 31 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                      () => Employee.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\r\n                            ");
                __builder2.AddMarkupContent(75, "<label for=\"email\">Email: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "id", "email");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "placeholder", "Enter email");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                                     Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog.TypeInference.CreateValidationMessage_2(__builder2, 84, 85, 
#nullable restore
#line 37 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                      () => Employee.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.AddMarkupContent(88, "<button type=\"submit\" class=\"btn btn-primary\">Save employee</button>\r\n                        ");
                __builder2.OpenElement(89, "a");
                __builder2.AddAttribute(90, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(92, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 47 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Components\AddEmployeeDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BethanysPieShopHRM.Server.Components.AddEmployeeDialog
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
