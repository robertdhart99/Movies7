#pragma checksum "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "174e1bde06ae156cade3f2487b19ec789c88e97b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\_ViewImports.cshtml"
using Movies7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\_ViewImports.cshtml"
using Movies7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174e1bde06ae156cade3f2487b19ec789c88e97b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46dfa98f26da9dd9ddc1af18ec47f48d5a603047", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <h3 class=\"mt-3\">Genres</h3>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 10 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
             foreach (Genre g in Model.Genres)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "174e1bde06ae156cade3f2487b19ec789c88e97b4557", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
               Write(g.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGenre", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                              WriteLiteral(g.GenreID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGenre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                               WriteLiteral(Model.ActiveMember);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeMember"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeMember", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeMember"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 438, "list-group-item", 438, 15, true);
#nullable restore
#line 15 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 453, Model.CheckActiveGenre(g.GenreID), 454, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <h3 class=\"mt-3\">Members</h3>\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 22 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
             foreach (Member m in Model.Members)
            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "174e1bde06ae156cade3f2487b19ec789c88e97b9015", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
               Write(m.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activeGenre", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                              WriteLiteral(Model.ActiveGenre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeGenre", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeGenre"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                               WriteLiteral(m.MemberID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeMember"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activeMember", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activeMember"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 898, "list-group-item", 898, 15, true);
#nullable restore
#line 27 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 913, Model.CheckActiveMember(m.MemberID), 914, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-sm-9\">\r\n");
#nullable restore
#line 34 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
         foreach (Member m in Model.Members)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
             if (m.MemberID != "all" && m.MemberID == Model.ActiveMember)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4 id=\"name\">\r\n                   Name: ");
#nullable restore
#line 39 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                    Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n                <br />\r\n                <h4>\r\n                  Year:  ");
#nullable restore
#line 43 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                    Write(m.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n                <br />\r\n                <h4>\r\n                   Major: ");
#nullable restore
#line 47 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                     Write(m.Major);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n                <br />\r\n                <h4>\r\n                   Bio: ");
#nullable restore
#line 51 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                   Write(m.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n                <br />\r\n                <h4 id=\"FavMov\">\r\n                   Favorite Movies:\r\n                </h4>\r\n                <br />\r\n");
#nullable restore
#line 58 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"list-inline\">\r\n");
#nullable restore
#line 62 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
             foreach (Movie movie in Model.Movies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-inline-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "174e1bde06ae156cade3f2487b19ec789c88e97b16104", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "174e1bde06ae156cade3f2487b19ec789c88e97b16384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2049, "~/images/", 2049, 9, true);
#nullable restore
#line 66 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2058, movie.LogoImage, 2058, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 66 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2081, movie.Name, 2081, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2131, movie.Name, 2131, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue(" ", 2142, "|", 2143, 2, true);
#nullable restore
#line 67 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2144, movie.Genre.Name, 2145, 17, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
AddHtmlAttributeValue(" ", 2162, movie.Member.Name, 2163, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
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
#nullable restore
#line 65 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
                                              WriteLiteral(movie.MovieID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 70 "C:\Users\ccbro\Classwork\UC Clifton\Web Application Development\Movies7\Movies7\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
