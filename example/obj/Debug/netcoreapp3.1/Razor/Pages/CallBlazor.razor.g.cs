#pragma checksum "/Users/vimalraveendran/Projects/example/example/Pages/CallBlazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8849309c714924c240b04a96a1c2096d4b2ccbf2"
// <auto-generated/>
#pragma warning disable 1591
namespace example.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using example;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Projects/example/example/_Imports.razor"
using example.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/vimalraveendran/Projects/example/example/Pages/CallBlazor.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CallBlazor")]
    public partial class CallBlazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"bg-info text-white\">Call Blazor from JavaScript</h1>\n\n");
            __builder.AddMarkupContent(1, @"<div class=""form-group"">
    <p class=""bg-light text-danger"">2nd Indexed No from { 10, 20, 30, 40 } is: <span class=""bg-warning text-black-50"" id=""noIndex""></span></p>
    <button class=""btn btn-primary"" onclick=""GetNumber(2)"">Call Static method</button>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/vimalraveendran/Projects/example/example/Pages/CallBlazor.razor"
       

    [JSInvokable]
    public static Task<int> ReturnArrayAsync(int num)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/vimalraveendran/Projects/example/example/Pages/CallBlazor.razor"
            
        int[] nos = { 10, 20, 30, 40 };
        return Task.FromResult(nos[num]);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
