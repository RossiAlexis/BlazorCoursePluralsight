#pragma checksum "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43ee1898226e65929141d5e7de9890ad54ae28dd"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Server.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex");
            __builder.AddAttribute(2, "id", "wrapper");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenComponent<BethanysPieShopHRM.Server.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "page-content-wrapper");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.AddMarkupContent(9, @"<nav class=""navbar navbar-expand-lg navbar-light border-bottom"">
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <h3 class=""title"">Bethany's Pie Shop HRM </h3>
                <ul class=""navbar-nav ml-auto mt-2 mt-lg-0"">
                </ul>
            </div>
        </nav>

        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container-fluid");
            __builder.AddMarkupContent(12, "\r\n\r\n            ");
            __builder.AddContent(13, 
#nullable restore
#line 20 "D:\Cursos\Pluralsight\Blazor\Blazor Getting Started\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
