#pragma checksum "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c815a0aced6ae4dcfb940953f364f53eb4c79e5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorBlogger.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using BlazorBlogger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\_Imports.razor"
using BlazorBlogger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\Pages\FetchData.razor"
using BlazorBlogger.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Work\Project\Local Projects\Blazor\Blogger\Blazor Blogger\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591