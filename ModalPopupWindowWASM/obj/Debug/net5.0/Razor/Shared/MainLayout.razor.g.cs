#pragma checksum "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c82e3c1ce753a9e8eaf59a762dbf28277143a5f3"
// <auto-generated/>
#pragma warning disable 1591
namespace ModalPopupWindowWASM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using ModalPopupWindowWASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using ModalPopupWindowWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\_Imports.razor"
using Blazored.Modal.Services;

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
            __builder.AddAttribute(2, "b-1cqgejq3ss");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-1cqgejq3ss");
            __builder.OpenComponent<ModalPopupWindowWASM.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-1cqgejq3ss");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-1cqgejq3ss><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-1cqgejq3ss>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-1cqgejq3ss");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\Projects\ModalPopupWindowBlazorWASM\ModalPopupWindowWASM\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(17);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
