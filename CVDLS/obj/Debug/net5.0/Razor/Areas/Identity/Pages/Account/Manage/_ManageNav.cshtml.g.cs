#pragma checksum "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2330276888ba4c7618e0366cd5ab86afb02ac52e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__ManageNav), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml")]
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
#line 1 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\_ViewImports.cshtml"
using CVDLS.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\_ViewImports.cshtml"
using CVDLS.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using CVDLS.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using CVDLS.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2330276888ba4c7618e0366cd5ab86afb02ac52e", @"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0882a1584abcb2fdb9285f61547703bd055f3cbb", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1cbeea4ed2259acffebd938c141ded319613cb8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a867e15b9d2b649f534c4000ce7842057ca8154", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("external-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ExternalLogins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--\r\n<ul class=\"nav nav-pills flex-column\">\r\n    <li class=\"nav-item\"><a class=\"nav-link ");
#nullable restore
#line 7 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
                                       Write(ManageNavPages.IndexNavClass(ViewContext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"profile\" asp-page=\"./Index\">Profile</a></li>\r\n    <li class=\"nav-item\"><a class=\"nav-link ");
#nullable restore
#line 8 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
                                       Write(ManageNavPages.EmailNavClass(ViewContext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"email\" asp-page=\"./Email\">Email</a></li>\r\n    <li class=\"nav-item\"><a class=\"nav-link ");
#nullable restore
#line 9 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
                                       Write(ManageNavPages.ChangePasswordNavClass(ViewContext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"change-password\" asp-page=\"./ChangePassword\">Password</a></li>\r\n");
#nullable restore
#line 10 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
     if (hasExternalLogins)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li id=\"external-logins\" class=\"nav-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2330276888ba4c7618e0366cd5ab86afb02ac52e6856", async() => {
                WriteLiteral("External logins");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 755, "nav-link", 755, 8, true);
#nullable restore
#line 12 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
AddHtmlAttributeValue(" ", 763, ManageNavPages.ExternalLoginsNavClass(ViewContext), 764, 51, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\"><a class=\"nav-link ");
#nullable restore
#line 14 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
                                       Write(ManageNavPages.TwoFactorAuthenticationNavClass(ViewContext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"two-factor\" asp-page=\"./TwoFactorAuthentication\">Two-factor authentication</a></li>\r\n    <li class=\"nav-item\"><a class=\"nav-link ");
#nullable restore
#line 15 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
                                       Write(ManageNavPages.PersonalDataNavClass(ViewContext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" id=\"personal-data\" asp-page=\"./PersonalData\">Personal data</a></li>\r\n</ul>\r\n-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
