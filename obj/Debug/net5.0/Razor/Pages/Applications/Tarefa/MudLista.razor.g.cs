#pragma checksum "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0cdcbe67e8722710de5e4f7f7a889454bd6ded"
// <auto-generated/>
#pragma warning disable 1591
namespace CNV2.Pages.Applications.Tarefa
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using CNV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using CNV2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\_Imports.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
    public partial class MudLista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudSimpleTable>(0);
            __builder.AddAttribute(1, "Style", "overflow-x: auto;");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "<thead></thead>\r\n    ");
                __builder2.OpenElement(4, "tbody");
                __builder2.OpenComponent<MudBlazor.MudTreeView<string>>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_0(__builder3, 7, 8, 
#nullable restore
#line 9 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                    "Esclarecimentos"

#line default
#line hidden
#nullable disable
                    , 9, (__builder4) => {
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_1(__builder4, 10, 11, 
#nullable restore
#line 12 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                        "Orçamentos"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(12, "\r\n\r\n                ");
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_2(__builder4, 13, 14, 
#nullable restore
#line 14 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                        "Orçamentos"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(15, "\r\n\r\n                ");
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_3(__builder4, 16, 17, 
#nullable restore
#line 16 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                        "Orçamentos"

#line default
#line hidden
#nullable disable
                        );
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudCard>(19);
            __builder.AddAttribute(20, "style", "margin-top: 20px;");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTreeView<string>>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_4(__builder3, 24, 25, 
#nullable restore
#line 28 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                "Esclarecimentos"

#line default
#line hidden
#nullable disable
                    , 26, (__builder4) => {
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_5(__builder4, 27, 28, 
#nullable restore
#line 29 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                    "Orçamentos"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(29, "\r\n            ");
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_6(__builder4, 30, 31, 
#nullable restore
#line 30 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                    "Certificação PME"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(32, "\r\n            ");
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_7(__builder4, 33, 34, 
#nullable restore
#line 31 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                    "Alvará de Utilização"

#line default
#line hidden
#nullable disable
                        );
                    }
                    );
                    __builder3.AddMarkupContent(35, "\r\n        ");
                    __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_8(__builder3, 36, 37, 
#nullable restore
#line 33 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                "Contratação"

#line default
#line hidden
#nullable disable
                    , 38, (__builder4) => {
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_9(__builder4, 39, 40, 
#nullable restore
#line 34 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                    "Pedido de NIB"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(41, "\r\n            ");
                        __Blazor.CNV2.Pages.Applications.Tarefa.MudLista.TypeInference.CreateMudTreeViewItem_10(__builder4, 42, 43, 
#nullable restore
#line 35 "C:\Users\mcorr\OneDrive\Documentos\Book\CNV2\Pages\Applications\Tarefa\MudLista.razor"
                                    "Solicitar data de Inicio"

#line default
#line hidden
#nullable disable
                        );
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CNV2.Pages.Applications.Tarefa.MudLista
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTreeViewItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_9<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_10<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
