// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorwebapp.Client.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Blazorwebapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Blazorwebapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\_Imports.razor"
using Blazorwebapp.Shared;

#line default
#line hidden
#nullable disable
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\blazor\Blazorwebapp\Blazorwebapp\Client\Shared\GenericList.razor"
       

    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
