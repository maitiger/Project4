#pragma checksum "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12332076bb29fb21ac87c16c50d515f086a36932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contests_Index), @"mvc.1.0.view", @"/Views/Contests/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contests/Index.cshtml", typeof(AspNetCore.Views_Contests_Index))]
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
#line 1 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\_ViewImports.cshtml"
using J4;

#line default
#line hidden
#line 2 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\_ViewImports.cshtml"
using J4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12332076bb29fb21ac87c16c50d515f086a36932", @"/Views/Contests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab698cef0f719c403ef80828ea28088a4778ac82", @"/Views/_ViewImports.cshtml")]
    public class Views_Contests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<J4.Models.Contests>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 30, true);
            WriteLiteral("\r\n<h2>Contests</h2>\r\n\r\n<div>\r\n");
            EndContext();
#line 10 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(154, 109, true);
            WriteLiteral("        <div class=\"Contests-Row\">\r\n            <div class=\"Box\">\r\n                <div class=\"item-video\">\r\n");
            EndContext();
            BeginContext(363, 97, true);
            WriteLiteral("                    <video width=\"100%\" height=\"240px\" controls>\r\n                        <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 460, "\"", 510, 1);
#line 17 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
WriteAttributeValue("", 466, Html.DisplayFor(modelItem => item.UrlVideo), 466, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 120, true);
            WriteLiteral(" type=\"video/mp4\">\r\n                        Your browser does not support HTML5 video.\r\n                    </video>\r\n\r\n");
            EndContext();
            BeginContext(661, 136, true);
            WriteLiteral("                </div>\r\n                <div class=\"item-info\">\r\n\r\n                    <div class=\"Name\">\r\n                        <h4> ");
            EndContext();
            BeginContext(798, 39, false);
#line 26 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(837, 104, true);
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"Role\">\r\n                        <h4> ");
            EndContext();
            BeginContext(942, 39, false);
#line 29 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.role));

#line default
#line hidden
            EndContext();
            BeginContext(981, 101, true);
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"Link\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1082, "\"", 1134, 1);
#line 32 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
WriteAttributeValue("", 1089, Html.DisplayFor(modelItem => item.LinkRegis), 1089, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1135, 150, true);
            WriteLiteral("><h4>Sign up for the contests</h4></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"Status\">\r\n                    ");
            EndContext();
            BeginContext(1285, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e40e266f1cb4168b3b5156335c0602a", async() => {
                BeginContext(1330, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1338, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1360, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6f630e46c44a579e6162a52cc9c708", async() => {
                BeginContext(1408, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1441, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf55441782f241f98989b9decf76c5d7", async() => {
                BeginContext(1488, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1498, 66, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 44 "D:\Cac Thu Cac Thu\ProjectNhom4\JamesThew\Project4\J4\J4\Views\Contests\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1571, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<J4.Models.Contests>> Html { get; private set; }
    }
}
#pragma warning restore 1591
