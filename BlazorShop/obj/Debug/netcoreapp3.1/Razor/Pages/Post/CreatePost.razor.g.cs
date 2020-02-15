#pragma checksum "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b9b25e61b9d4ded2787df5a38e387591c97f0a8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Pages.Post
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using BlazorShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\_Imports.razor"
using BlazorShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreatePost")]
    public partial class CreatePost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Post</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div>Title</div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "name", "Title");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor"
                                                Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.AddMarkupContent(11, "<div>Content</div>\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.OpenElement(13, "textarea");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor"
                          Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Content = __value, Content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "name", "addPost");
            __builder.AddAttribute(21, "value", "Add Post");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor"
                                                                        savePost

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.OpenElement(25, "label");
            __builder.AddContent(26, 
#nullable restore
#line 16 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor"
                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\Work\Project\Local Projects\Blazor\Blogger\BlazorShop\Pages\Post\CreatePost.razor"
       

    private string Title { get; set; }
    private string Content { get; set; }

    private static string Message { get; set; }

    private void savePost()
    {
        Message = "saved";
        ResetMessage();
    }

    protected override void OnInitialized()
    {

        base.OnInitialized();
    }

    private void ResetMessage()
    {
        Timer timer = new Timer(new TimerCallback(_ =>
       {
           Message = string.Empty;
           InvokeAsync(StateHasChanged);
       }), null, 1000, 1000);

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
