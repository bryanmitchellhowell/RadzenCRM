#pragma checksum "C:\Bryan\ERIC\server\Pages\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25096def95cbe35c8b253d8cf4f23cd3396379b7"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenCrm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Bryan\ERIC\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Bryan\ERIC\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Bryan\ERIC\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Bryan\ERIC\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Bryan\ERIC\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Bryan\ERIC\server\_Imports.razor"
using RadzenCrm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
using RadzenCrm.Models.Crm;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tasks")]
    public partial class Tasks : RadzenCrm.Pages.TasksComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Tasks");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<RadzenCrm.Models.Crm.Task>>(17);
                __builder2.AddAttribute(18, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenCrm.Models.Crm.Task>>(
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                                                          getTasksResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenCrm.Models.Crm.Task>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenCrm.Models.Crm.Task>(this, 
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                                                                                                                        Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(25);
                    __builder3.AddAttribute(26, "Property", "Id");
                    __builder3.AddAttribute(27, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(29);
                    __builder3.AddAttribute(30, "Property", "Title");
                    __builder3.AddAttribute(31, "Title", "Title");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(33);
                    __builder3.AddAttribute(34, "Property", "OpportunityId");
                    __builder3.AddAttribute(35, "SortProperty", "Opportunity.Name");
                    __builder3.AddAttribute(36, "GroupProperty", "Opportunity.Name");
                    __builder3.AddAttribute(37, "FilterProperty", "Opportunity.Name");
                    __builder3.AddAttribute(38, "Title", "Opportunity");
                    __builder3.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm.Models.Crm.Task>)((data) => (__builder4) => {
                        __builder4.AddContent(40, 
#nullable restore
#line 24 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                data.Opportunity?.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(42);
                    __builder3.AddAttribute(43, "Property", "DueDate");
                    __builder3.AddAttribute(44, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Due Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(47);
                    __builder3.AddAttribute(48, "Property", "TypeId");
                    __builder3.AddAttribute(49, "SortProperty", "TaskType.Name");
                    __builder3.AddAttribute(50, "GroupProperty", "TaskType.Name");
                    __builder3.AddAttribute(51, "FilterProperty", "TaskType.Name");
                    __builder3.AddAttribute(52, "Title", "Task Type");
                    __builder3.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm.Models.Crm.Task>)((data) => (__builder4) => {
                        __builder4.AddContent(54, 
#nullable restore
#line 31 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                data.TaskType?.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(56);
                    __builder3.AddAttribute(57, "Property", "StatusId");
                    __builder3.AddAttribute(58, "SortProperty", "TaskStatus.Name");
                    __builder3.AddAttribute(59, "GroupProperty", "TaskStatus.Name");
                    __builder3.AddAttribute(60, "FilterProperty", "TaskStatus.Name");
                    __builder3.AddAttribute(61, "Title", "Task Status");
                    __builder3.AddAttribute(62, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm.Models.Crm.Task>)((data) => (__builder4) => {
                        __builder4.AddContent(63, 
#nullable restore
#line 36 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                data.TaskStatus?.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<RadzenCrm.Models.Crm.Task>>(65);
                    __builder3.AddAttribute(66, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "Width", "70px");
                    __builder3.AddAttribute(69, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 39 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                                                TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RadzenCrm.Models.Crm.Task>)((radzenCrmModelsCrmTask) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(71);
                        __builder4.AddAttribute(72, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 41 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(73, "Icon", "close");
                        __builder4.AddAttribute(74, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 41 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, radzenCrmModelsCrmTask)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(76, "onclick", 
#nullable restore
#line 41 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                                                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(77, (__value) => {
#nullable restore
#line 16 "C:\Bryan\ERIC\server\Pages\Tasks.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<RadzenCrm.Models.Crm.Task>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591