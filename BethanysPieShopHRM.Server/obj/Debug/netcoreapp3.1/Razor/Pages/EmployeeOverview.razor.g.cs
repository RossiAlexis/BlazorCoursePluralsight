#pragma checksum "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5394b1e695de02e1b7fec7f5ef91c8b28820b7a7"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Server.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : EmployeeOverviewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All employees</h1>\r\n\r\n\r\n");
#nullable restore
#line 7 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
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
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th></th>\r\n                <th>Employee ID</th>\r\n                <th>First name</th>\r\n                <th>Last name</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 24 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 27 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                                    $"https://gillcleerenpluralsight.blob.core.windows.net/person/{employee.EmployeeId}-small.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "rounded-circle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                         employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 29 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 30 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 32 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                                   $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "btn btn-primary table-info");
            __builder.AddMarkupContent(32, "\r\n                            <i class=\"fa fa-info-circle\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 35 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                                   $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "class", "btn btn-primary table-info");
            __builder.AddMarkupContent(37, "\r\n                            <i class=\"fa fa-edit\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 40 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 43 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                   QuickAddEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "btn btn-dark table-btn quick-add-btn");
            __builder.AddContent(48, "  +  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
            __builder.OpenComponent<BethanysPieShopHRM.Server.Components.AddEmployeeDialog>(50);
            __builder.AddAttribute(51, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 47 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                                                              AddEmployeeDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(52, (__value) => {
#nullable restore
#line 47 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\EmployeeOverview.razor"
                         EmployeeDialog = (BethanysPieShopHRM.Server.Components.AddEmployeeDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591