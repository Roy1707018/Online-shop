#pragma checksum "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c6c5612f9251293cb623655af14f3356e7bfa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_User_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_User_Index))]
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
#line 1 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 1 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#line 6 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
using System.Net.Http;

#line default
#line hidden
#line 7 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
using OnlineShop.Utility;

#line default
#line hidden
#line 8 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c6c5612f9251293cb623655af14f3356e7bfa0", @"/Areas/Customer/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d90dc07541a5c6d64c93e024fee34b85f8e0e69", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 10 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
  
    var userRole = HttpContextAccessor.HttpContext.Session.GetString("roleName");



#line default
#line hidden
            BeginContext(334, 118, true);
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">User List</h2>\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
     if (userRole == "Admin")
    {

#line default
#line hidden
            BeginContext(490, 52, true);
            WriteLiteral("        <div class=\"col-6 text-right\">\r\n            ");
            EndContext();
            BeginContext(542, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c6c5612f9251293cb623655af14f3356e7bfa07121", async() => {
                BeginContext(586, 46, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(636, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 26 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(661, 297, true);
            WriteLiteral(@"    </div>
<br />
<div>
    <table class=""table table-striped border"">
        <tr class=""table-info"">
            <th>
                Name
            </th>
            <th>
                UserName
            </th>
            <th>Status</th>
            <th></th>
        </tr>
");
            EndContext();
#line 41 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1007, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1046, 14, false);
#line 44 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1062, 13, false);
#line 44 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1103, 13, false);
#line 45 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
               Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1116, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 46 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                 if (item.LockoutEnd > DateTime.Now && item.LockoutEnd != null)
                {

#line default
#line hidden
            BeginContext(1223, 142, true);
            WriteLiteral("                    <td>Inactive</td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n                            ");
            EndContext();
            BeginContext(1365, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c6c5612f9251293cb623655af14f3356e7bfa011059", async() => {
                BeginContext(1436, 77, true);
                WriteLiteral("\r\n                                <i>Active</i>\r\n                            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
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
            BeginContext(1517, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1547, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c6c5612f9251293cb623655af14f3356e7bfa013623", async() => {
                BeginContext(1617, 77, true);
                WriteLiteral("\r\n                                <i>Delete</i>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
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
            BeginContext(1698, 63, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </td>\r\n");
            EndContext();
#line 60 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1823, 108, true);
            WriteLiteral("                    <td>Active</td>\r\n                    <td style=\"width: 150px\">\r\n                        ");
            EndContext();
            BeginContext(1931, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81c6c5612f9251293cb623655af14f3356e7bfa016633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 66 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1979, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 68 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(2029, 21, true);
            WriteLiteral("\r\n            </tr>\r\n");
            EndContext();
#line 72 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2061, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2102, 178, true);
                WriteLiteral("\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\r\n    <script type=\"text/javascript\">\r\n        $(function(){\r\n            var save = \'");
                EndContext();
                BeginContext(2281, 16, false);
#line 80 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(2297, 111, true);
                WriteLiteral("\'\r\n            if(save!=\'\') {\r\n                alertify.success(save);\r\n            }\r\n            var edit = \'");
                EndContext();
                BeginContext(2409, 16, false);
#line 84 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(2425, 110, true);
                WriteLiteral("\'\r\n            if(edit!=\'\') {\r\n                alertify.success(edit);\r\n            }\r\n            var del = \'");
                EndContext();
                BeginContext(2536, 18, false);
#line 88 "C:\Users\Dell\source\repos\OnlineShop\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(2554, 111, true);
                WriteLiteral("\'\r\n            if (del!=\'\') {\r\n                alertify.error(del);\r\n            }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
