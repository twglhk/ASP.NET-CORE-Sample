#pragma checksum "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3dc349fe0aa0e963922086536b045c5b487410"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Online Users</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    User : ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 8 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
               _users.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "class", "list-group");
#nullable restore
#line 14 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
     foreach (var user in _users)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "list-group-item");
            __builder.SetKey(
#nullable restore
#line 16 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
                  user

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", "btn btn-link");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
                                                                 () => KickUser(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "[Kick]");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, 
#nullable restore
#line 18 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
                    user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "placeholder", "Add User");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
                                                                            _inputName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputName = __value, _inputName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
                                                                    AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Add a User");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\User\source\repos\HelloASP\BlazorApp\BlazorApp\Pages\User.razor"
       
    List<UserData> _users = new List<UserData>();

    string _inputName;

    protected override void OnInitialized()
    {
        _users.Add(new UserData() { Name = "Humba" });
        _users.Add(new UserData() { Name = "Ba" });
        _users.Add(new UserData() { Name = "Gerrard" });
    }

    void AddUser()
    {
        _users.Add(new UserData() { Name = _inputName });
        _inputName = "";
    }

    void KickUser(UserData user)
    {
        _users.Remove(user);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591