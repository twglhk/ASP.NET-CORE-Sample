#pragma checksum "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58fdd548e5b4b79fdd23d31c41cd1fca1d719aa3"
// <auto-generated/>
#pragma warning disable 1591
namespace RankingApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using RankingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\_Imports.razor"
using RankingApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
using RankingApp.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
using SharedData.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ranking")]
    public partial class Ranking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ranking</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 11 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
         if (_gameResults == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.AddMarkupContent(6, "<thead><tr><th>UserName</th>\r\n                        <th>Score</th>\r\n                        <th>Date</th>\r\n                        <th></th>\r\n                        <th></th></tr></thead>\r\n                ");
                __builder2.OpenElement(7, "tbody");
#nullable restore
#line 28 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                     foreach (var gameResult in _gameResults)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 31 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                             gameResult.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n                        ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 32 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                             gameResult.Score

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 33 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                             gameResult.Date.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "td");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "class", "btn btn-primary");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                      () => UpdateGameResult(gameResult)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(22, "Edit");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "td");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "class", "btn btn-primary");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                      () => DeleteGameResult(gameResult)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 41 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.OpenElement(29, "p");
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "class", "btn btn-primary");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                          AddGameResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(33, "\r\n                    Add\r\n                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 51 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
             if (_showPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "modal");
                __builder2.AddAttribute(36, "style", "display:block");
                __builder2.AddAttribute(37, "role", "dialog");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "modal-dialog");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "modal-content");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "modal-header");
                __builder2.AddMarkupContent(44, "<h3 class=\"modal-title\">Add/Update GameResult</h3>\r\n                                ");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "type", "button");
                __builder2.AddAttribute(47, "class", "close");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                              ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(49, "<span area-hidden=\"true\">X</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "modal-body");
                __builder2.AddMarkupContent(53, "<label for=\"UserName\">UserName</label>\r\n                                ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "type", "text");
                __builder2.AddAttribute(57, "placeholder", "UserName");
                __builder2.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                                                            _gameResult.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _gameResult.UserName = __value, _gameResult.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                                ");
                __builder2.AddMarkupContent(61, "<label for=\"Score\">Score</label>\r\n                                ");
                __builder2.OpenElement(62, "input");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "type", "text");
                __builder2.AddAttribute(65, "placeholder", "Score");
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                                                         _gameResult.Score

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _gameResult.Score = __value, _gameResult.Score));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                ");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "class", "btn btn-primary");
                __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                          SaveGameResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(72, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 74 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
             
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(73, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(74, "<p>Not Authorized</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\User\source\repos\HelloASP\RankingApp\RankingApp\Pages\Ranking.razor"
       
    List<GameResult> _gameResults;

    bool _showPopup;
    GameResult _gameResult;

    protected override async Task OnInitializedAsync()
    {
        _gameResults = await RankingService.GetGameResultAsync();
    }

    void AddGameResult()
    {
        _showPopup = true;
        _gameResult = new GameResult() { Id = 0 };  // ID를 사용해 데이터 생성/수정 구분
    }

    void ClosePopup()
    {
        _showPopup = false;
    }

    void UpdateGameResult(GameResult gameResult)
    {
        _showPopup = true;
        _gameResult = gameResult;
    }

    async Task DeleteGameResult(GameResult gameResult)
    {
        var result = RankingService.DeleteGameResult(gameResult);

        _gameResults = await RankingService.GetGameResultAsync();
    }

    async Task SaveGameResult()
    {
        if (_gameResult.Id == 0)
        {
            // Create
            _gameResult.Date = DateTime.Now;
            var result = await RankingService.AddGameResult(_gameResult);
        }
        else
        {
            // Edit
            var result = await RankingService.UpdateGameResult(_gameResult);
        }

        _showPopup = false;
        _gameResults = await RankingService.GetGameResultAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RankingService RankingService { get; set; }
    }
}
#pragma warning restore 1591
