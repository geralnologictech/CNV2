#pragma checksum "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16770190b92ce7d3b92556c72f5089bb3ee0de0a"
// <auto-generated/>
#pragma warning disable 1591
namespace CNV2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using CNV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using CNV2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class");
            __builder.AddAttribute(2, "b-6vy1i6s9u6");
            __builder.OpenComponent<MudBlazor.MudPaper>(3);
            __builder.AddAttribute(4, "Width", "250px");
            __builder.AddAttribute(5, "Class", "py-3");
            __builder.AddAttribute(6, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Shared\NavMenu.razor"
                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(10);
                    __builder3.AddAttribute(11, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 4 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Shared\NavMenu.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Class", "px-4");
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(14, "Gestão de Projetos");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(16);
                    __builder3.AddAttribute(17, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(19);
                    __builder3.AddAttribute(20, "Href", "/");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(22, "Dashboard");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavGroup>(24);
                    __builder3.AddAttribute(25, "Title", "Listas");
                    __builder3.AddAttribute(26, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Shared\NavMenu.razor"
                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(28);
                        __builder4.AddAttribute(29, "Href", "/cliente");
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, "Clientes");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(33);
                        __builder4.AddAttribute(34, "Href", "/projeto");
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(36, "Projetos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(38);
                        __builder4.AddAttribute(39, "Href", "/medida");
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(41, "Medidas");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(43);
                        __builder4.AddAttribute(44, "Href", "/estados");
                        __builder4.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(46, "Estados");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(48);
                        __builder4.AddAttribute(49, "Href", "/contactos");
                        __builder4.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(51, "Contactos");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavGroup>(53);
                    __builder3.AddAttribute(54, "Title", "Utilitários");
                    __builder3.AddAttribute(55, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Shared\NavMenu.razor"
                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(57);
                        __builder4.AddAttribute(58, "Href", "/calendario");
                        __builder4.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(60, "Calendário");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(62);
                        __builder4.AddAttribute(63, "Href", "/listadetarefa");
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(65, "Lista de Tarefas");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(67);
                        __builder4.AddAttribute(68, "Href", "/senha");
                        __builder4.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(70, "Senhas");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavGroup>(72);
                    __builder3.AddAttribute(73, "Title", "Tabelas");
                    __builder3.AddAttribute(74, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Shared\NavMenu.razor"
                                                   false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(76);
                        __builder4.AddAttribute(77, "Href", "/tcliente");
                        __builder4.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(79, "Clientes");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(81);
                        __builder4.AddAttribute(82, "Href", "/tprojeto");
                        __builder4.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(84, "Projetos");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(85, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(86);
                        __builder4.AddAttribute(87, "Href", "/ttarefa");
                        __builder4.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(89, "Tarefas");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(91);
                        __builder4.AddAttribute(92, "Href", "/tchat");
                        __builder4.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(94, "Chat");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(96);
                    __builder3.AddAttribute(97, "Href", "/utilizadores");
                    __builder3.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(99, "Utilizadores");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(101);
                    __builder3.AddAttribute(102, "Href", "/definicoes");
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(104, "Definições");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
