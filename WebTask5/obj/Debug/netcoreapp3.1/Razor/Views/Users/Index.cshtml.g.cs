#pragma checksum "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8833ab852603742daaa5ff251653701a1605300e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\_ViewImports.cshtml"
using WebTask5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
using WebTask5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8833ab852603742daaa5ff251653701a1605300e", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3ce364ccabfad6928999645225edd2b378a420", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebTask5.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Block", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Unblock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
  
    ViewBag.Title = "???????????? ??????????????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    var users = UserManager.Users;
    User userKey = UserManager.Users.First();


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8833ab852603742daaa5ff251653701a1605300e6059", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8833ab852603742daaa5ff251653701a1605300e6325", async() => {
                    WriteLiteral("<i style=\"color: white\" class=\"bi bi-lock-fill\"></i> Block");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8833ab852603742daaa5ff251653701a1605300e7934", async() => {
                    WriteLiteral("<i style=\"color: white\" class=\"bi bi-unlock-fill\"></i> Unblock");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8833ab852603742daaa5ff251653701a1605300e9547", async() => {
                    WriteLiteral(" <i style=\"color: white\" class=\"bi bi-trash2-fill\"></i> Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <table class=\"table table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\"><input type=\"checkbox\" id=\"checkAll\"></th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 29 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(m => userKey.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 30 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(m => userKey.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 31 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(m => userKey.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 32 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(m => userKey.RegistrationDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 33 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(m => userKey.LastLogin));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 34 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                               Write(Html.DisplayNameFor(m => userKey.IsLockUser));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td scope=\"col\"><input type=\"checkbox\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1768, "\"", 1784, 1);
#nullable restore
#line 41 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
WriteAttributeValue("", 1776, user.Id, 1776, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"id\"></td>\r\n                        <td scope=\"col\">");
#nullable restore
#line 42 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(m => user.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td scope=\"col\">");
#nullable restore
#line 43 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(m => user.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td scope=\"col\">");
#nullable restore
#line 44 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(m => user.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td scope=\"col\">");
#nullable restore
#line 45 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(m => user.RegistrationDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td scope=\"col\">");
#nullable restore
#line 46 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(m => user.LastLogin));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <th scope=\"col\">");
#nullable restore
#line 47 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(m => user.IsLockUser));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\Maksim\source\repos\WebTask5\WebTask5\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebTask5.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
