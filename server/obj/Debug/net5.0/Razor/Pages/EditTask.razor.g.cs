#pragma checksum "C:\Bryan\ERIC\server\Pages\EditTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da15b1befab142350475f22305c570d76b1df0ba"
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
#line 5 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
using RadzenCrm.Models.Crm;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-task/{Id}")]
    public partial class EditTask : RadzenCrm.Pages.EditTaskComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<RadzenCrm.Models.Crm.Task>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<RadzenCrm.Models.Crm.Task>(
#nullable restore
#line 12 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                     task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                      task != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenCrm.Models.Crm.Task>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenCrm.Models.Crm.Task>(this, 
#nullable restore
#line 12 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                              Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Title");
                    __builder3.AddAttribute(19, "Component", "Title");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 20 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                          256

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddAttribute(27, "Name", "Title");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                  task.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.Title = __value, task.Title))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => task.Title));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(34, "class", "row");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                    __builder3.AddAttribute(38, "Text", "Opportunity");
                    __builder3.AddAttribute(39, "Component", "OpportunityId");
                    __builder3.AddAttribute(40, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n              ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "col-md-9");
                    __Blazor.RadzenCrm.Pages.EditTask.TypeInference.CreateRadzenDropDown_0(__builder3, 44, 45, 
#nullable restore
#line 30 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                       getOpportunitiesResult

#line default
#line hidden
#nullable disable
                    , 46, "Name", 47, "Id", 48, "Choose Opportunity", 49, "display: block; width: 100%", 50, "OpportunityId", 51, 
#nullable restore
#line 30 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                                                                                                          task.OpportunityId

#line default
#line hidden
#nullable disable
                    , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.OpportunityId = __value, task.OpportunityId)), 53, () => task.OpportunityId);
                    __builder3.AddMarkupContent(54, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(55);
                    __builder3.AddAttribute(56, "Component", "OpportunityId");
                    __builder3.AddAttribute(57, "Text", "OpportunityId is required");
                    __builder3.AddAttribute(58, "style", "position: absolute");
                    __builder3.AddAttribute(59, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                                                             0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\n            ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(63, "class", "row");
                    __builder3.OpenElement(64, "div");
                    __builder3.AddAttribute(65, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(66);
                    __builder3.AddAttribute(67, "Text", "Due Date");
                    __builder3.AddAttribute(68, "Component", "DueDate");
                    __builder3.AddAttribute(69, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n              ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "col-md-9");
                    __Blazor.RadzenCrm.Pages.EditTask.TypeInference.CreateRadzenDatePicker_1(__builder3, 73, 74, "MM/dd/yyyy", 75, "display: block; width: 100%", 76, "DueDate", 77, 
#nullable restore
#line 42 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                             task.DueDate

#line default
#line hidden
#nullable disable
                    , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.DueDate = __value, task.DueDate)), 79, () => task.DueDate);
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(81);
                    __builder3.AddAttribute(82, "Component", "DueDate");
                    __builder3.AddAttribute(83, "Text", "DueDate is required");
                    __builder3.AddAttribute(84, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(88, "class", "row");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(91);
                    __builder3.AddAttribute(92, "Text", "Task Type");
                    __builder3.AddAttribute(93, "Component", "TypeId");
                    __builder3.AddAttribute(94, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "col-md-9");
                    __Blazor.RadzenCrm.Pages.EditTask.TypeInference.CreateRadzenDropDown_2(__builder3, 98, 99, 
#nullable restore
#line 54 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                       getTaskTypesResult

#line default
#line hidden
#nullable disable
                    , 100, "Name", 101, "Id", 102, "Choose TaskType", 103, "display: block; width: 100%", 104, "TypeId", 105, 
#nullable restore
#line 54 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                                                                                                   task.TypeId

#line default
#line hidden
#nullable disable
                    , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.TypeId = __value, task.TypeId)), 107, () => task.TypeId);
                    __builder3.AddMarkupContent(108, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(109);
                    __builder3.AddAttribute(110, "Component", "TypeId");
                    __builder3.AddAttribute(111, "Text", "TypeId is required");
                    __builder3.AddAttribute(112, "style", "position: absolute");
                    __builder3.AddAttribute(113, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                                               0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\n            ");
                    __builder3.OpenElement(115, "div");
                    __builder3.AddAttribute(116, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(117, "class", "row");
                    __builder3.OpenElement(118, "div");
                    __builder3.AddAttribute(119, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(120);
                    __builder3.AddAttribute(121, "Text", "Task Status");
                    __builder3.AddAttribute(122, "Component", "StatusId");
                    __builder3.AddAttribute(123, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\n              ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "class", "col-md-9");
                    __Blazor.RadzenCrm.Pages.EditTask.TypeInference.CreateRadzenDropDown_3(__builder3, 127, 128, 
#nullable restore
#line 66 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                       getTaskStatusesResult

#line default
#line hidden
#nullable disable
                    , 129, "Name", 130, "Id", 131, "Choose TaskStatus", 132, "width: 100%", 133, "StatusId", 134, 
#nullable restore
#line 66 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                                                                                        task.StatusId

#line default
#line hidden
#nullable disable
                    , 135, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => task.StatusId = __value, task.StatusId)), 136, () => task.StatusId);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(137, "\n            ");
                    __builder3.OpenElement(138, "div");
                    __builder3.AddAttribute(139, "class", "row");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(142);
                    __builder3.AddAttribute(143, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 72 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(144, "Icon", "save");
                    __builder3.AddAttribute(145, "Text", "Save");
                    __builder3.AddAttribute(146, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 72 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(147, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(148);
                    __builder3.AddAttribute(149, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 74 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(150, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(151, "Text", "Cancel");
                    __builder3.AddAttribute(152, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Bryan\ERIC\server\Pages\EditTask.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
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
namespace __Blazor.RadzenCrm.Pages.EditTask
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
