#pragma checksum "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b21f756d430d20b8ee16b46d56f9bb49ab1b20"
// <auto-generated/>
#pragma warning disable 1591
namespace CNV2.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Layouts.SfDashboardLayout>(0);
            __builder.AddAttribute(1, "CellSpacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double[]>(
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                  new double[]{20 ,20 }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Columns", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                                                   5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanels>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanel>(6);
                    __builder3.AddAttribute(7, "SizeX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                    1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "SizeY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "Column", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                                     0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(11, "div");
                        __builder4.AddAttribute(12, "style", "text-align: start;");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.SfTreeView<MusicAlbum>>(13);
                        __builder4.AddAttribute(14, "ShowCheckBox", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "AutoCheck", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Navigations.TreeViewFieldsSettings<MusicAlbum>>(17);
                            __builder5.AddAttribute(18, "Id", "Id");
                            __builder5.AddAttribute(19, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<MusicAlbum>>(
#nullable restore
#line 9 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                                                                         Albums

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "Text", "Name");
                            __builder5.AddAttribute(21, "ParentID", "ParentId");
                            __builder5.AddAttribute(22, "HasChildren", "HasChild");
                            __builder5.AddAttribute(23, "Expanded", "Expanded");
                            __builder5.AddAttribute(24, "IsChecked", "IsChecked");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Layouts.DashboardLayoutPanel>(26);
                    __builder3.AddAttribute(27, "SizeX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                    2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "SizeY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Column", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
                                                     1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(31, "div");
                        __builder4.OpenComponent<Syncfusion.Blazor.Schedule.SfSchedule<AppointmentData>>(32);
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.AddMarkupContent(34, "<style>\r\n    .e-panel-content {\r\n        text-align: center;\r\n        margin-top: 10px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\NoLogicTech\Documents\Repos\ASerio\CNV2\Pages\Index.razor"
       
    public class MusicAlbum
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public bool Expanded { get; set; }
        public bool? IsChecked { get; set; }
        public bool HasChild { get; set; }
    }
    List<MusicAlbum> Albums = new List<MusicAlbum>();
    protected override void OnInitialized()
    {
        base.OnInitialized();
        Albums.Add(new MusicAlbum
        {
            Id = 1,
            Name = "Discover Music",
            HasChild = true,
        });
        Albums.Add(new MusicAlbum
        {
            Id = 2,
            ParentId = 1,
            Name = "Hot Singles"
        });
        Albums.Add(new MusicAlbum
        {
            Id = 3,
            ParentId = 1,
            Name = "Rising Artists"
        });
        Albums.Add(new MusicAlbum
        {
            Id = 4,
            ParentId = 1,
            Name = "Live Music"
        });
        Albums.Add(new MusicAlbum
        {
            Id = 14,
            HasChild = true,
            Name = "MP3 Albums",
            Expanded = true,
            IsChecked = true
        });
        Albums.Add(new MusicAlbum
        {
            Id = 15,
            ParentId = 14,
            Name = "Rock"
        });
        Albums.Add(new MusicAlbum
        {
            Id = 16,
            Name = "Gospel",
            ParentId = 14,
        });
        Albums.Add(new MusicAlbum
        {
            Id = 17,
            ParentId = 14,
            Name = "Latin Music"
        });
        Albums.Add(new MusicAlbum
        {
            Id = 18,
            ParentId = 14,
            Name = "Jazz"
        });
    }
    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
