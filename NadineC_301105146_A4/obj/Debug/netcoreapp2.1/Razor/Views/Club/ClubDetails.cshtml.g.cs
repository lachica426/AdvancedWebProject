#pragma checksum "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c14ad60469edfe2478762904bbaca33393552f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Club_ClubDetails), @"mvc.1.0.view", @"/Views/Club/ClubDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Club/ClubDetails.cshtml", typeof(AspNetCore.Views_Club_ClubDetails))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\_ViewImports.cshtml"
using NadineC_301105146_A4.Models;

#line default
#line hidden
#line 3 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\_ViewImports.cshtml"
using NadineC_301105146_A4.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c14ad60469edfe2478762904bbaca33393552f", @"/Views/Club/ClubDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06dd685a2ae5314d44d6cc67b09d2315c262c4d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Club_ClubDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 57, true);
            WriteLiteral("<!-- Name: Nadine Castro, Student Number: 301105146 -->\r\n");
            EndContext();
#line 3 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
  
    ViewBag.Title = "Maple Soccer League";

#line default
#line hidden
            BeginContext(121, 141, true);
            WriteLiteral("\r\n\r\n<div class=\"bg-danger rounded text-center py-5 mb-4 my-2\">\r\n    <div class=\"container\">\r\n        <h1 class=\"font-weight-bold text-white\">");
            EndContext();
            BeginContext(263, 14, false);
#line 10 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
                                           Write(Model.ClubName);

#line default
#line hidden
            EndContext();
            BeginContext(277, 67, true);
            WriteLiteral("</h1>\r\n        <p class=\"overflow-hidden text-white\">\r\n            ");
            EndContext();
            BeginContext(345, 17, false);
#line 12 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(362, 123, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table-responsive-sm float-right\">\r\n    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(485, 374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad6c5387a2424ee185644cae9072d3c5", async() => {
                BeginContext(491, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(509, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "523a7767781d4b539a43c2ceece1be97", async() => {
                    BeginContext(614, 44, true);
                    WriteLiteral("\r\n                    Edit\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-clubID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
                         WriteLiteral(Model.ClubID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clubID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-clubID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clubID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(662, 20, true);
                WriteLiteral("\r\n\r\n                ");
                EndContext();
                BeginContext(682, 156, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6952f2f229d4f79b7008d9b11d1243d", async() => {
                    BeginContext(788, 46, true);
                    WriteLiteral("\r\n                    Delete\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-clubID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
                         WriteLiteral(Model.ClubID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clubID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-clubID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clubID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(838, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(859, 189, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<br />\r\n\r\n\r\n<div class=\"table-responsive-sm\">\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>Club Name</th>\r\n            <td>");
            EndContext();
            BeginContext(1049, 14, false);
#line 41 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
           Write(Model.ClubName);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 84, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Club Name</th>\r\n            <td>");
            EndContext();
            BeginContext(1148, 18, false);
#line 45 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
           Write(Model.ClubNickName);

#line default
#line hidden
            EndContext();
            BeginContext(1166, 86, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Description</th>\r\n            <td>");
            EndContext();
            BeginContext(1253, 17, false);
#line 49 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 87, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Year Founded</th>\r\n            <td>");
            EndContext();
            BeginContext(1358, 17, false);
#line 53 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
           Write(Model.YearFounded);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 84, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>President</th>\r\n            <td>");
            EndContext();
            BeginContext(1460, 15, false);
#line 57 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
           Write(Model.President);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 80, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Coach</th>\r\n            <td>");
            EndContext();
            BeginContext(1556, 11, false);
#line 61 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
           Write(Model.Coach);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 65, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n<br />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1632, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a5eb95289484ea6d20b98f10b4dc6", async() => {
                BeginContext(1713, 12, true);
                WriteLiteral("Add a player");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1729, 421, true);
            WriteLiteral(@"
    <div>
        <p><h4>List of Players</h4></p>
    </div>
</div>

<div class=""table-responsive-sm"">
    <table class=""table table-bordered"">

        <thead>
            <tr>
                <th>PlayerID</th>
                <th>Last Name</th>
                <th>First Name</th>
                <th>Position</th>
                <th>Goals</th>
            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 88 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
             foreach (var playerList in Model.Players)
            {

#line default
#line hidden
            BeginContext(2221, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(2260, 19, false);
#line 91 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
               Write(playerList.PlayerID);

#line default
#line hidden
            EndContext();
            BeginContext(2279, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2307, 19, false);
#line 92 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
               Write(playerList.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2326, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2354, 20, false);
#line 93 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
               Write(playerList.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2374, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2402, 19, false);
#line 94 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
               Write(playerList.Position);

#line default
#line hidden
            EndContext();
            BeginContext(2421, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2449, 16, false);
#line 95 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
               Write(playerList.Goals);

#line default
#line hidden
            EndContext();
            BeginContext(2465, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 97 "C:\Users\Nadine\source\repos\TeamProject\Nadine_C_301105146\NadineC_301105146_A4\NadineC_301105146_A4\Views\Club\ClubDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(2506, 48, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Club> Html { get; private set; }
    }
}
#pragma warning restore 1591
