#pragma checksum "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a437c94c46d2dee6d9e207f6994656ecc7c0ed84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CVDLS.Pages.Pages_Info), @"mvc.1.0.razor-page", @"/Pages/Info.cshtml")]
namespace CVDLS.Pages
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
#line 1 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\_ViewImports.cshtml"
using CVDLS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\_ViewImports.cshtml"
using CVDLS.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a437c94c46d2dee6d9e207f6994656ecc7c0ed84", @"/Pages/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d88ac9c9be518bbb05bd47c378536e062b94b9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Info : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\Info.cshtml"
  
    ViewData["Title"] = "Health Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\Info.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <p>The following information was provided by the World Health Organization at the start of the COVID-19 pandemic.</p>
    <div>
        <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/i0ZabxXmH4Y"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
        <p><img");
            BeginWriteAttribute("src", " src=\'", 531, "\'", 573, 1);
#nullable restore
#line 12 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\Info.cshtml"
WriteAttributeValue("", 537, Url.Content("~/content/spacer.png"), 537, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Spacer\" width=\"100\" height=\"15\" /></p>\r\n        <p>The following tips were also provided to help maintain a sanitary environment.</p>\r\n        <p><img");
            BeginWriteAttribute("src", " src=\'", 730, "\'", 772, 1);
#nullable restore
#line 14 "C:\Users\YuMo17\source\repos\Design3\CVDLS\CVDLS\Pages\Info.cshtml"
WriteAttributeValue("", 736, Url.Content("~/content/spacer.png"), 736, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Spacer"" width=""100"" height=""15"" /></p>
        <blockquote class=""twitter-tweet"" data-dnt=""true"" width=""400""><p lang=""en"" dir=""ltr"">Lower your risk from <a href=""https://twitter.com/hashtag/COVID19?src=hash&amp;ref_src=twsrc%5Etfw"">#COVID19</a> by combining these 5??? precautions:<br>1??? Wear a mask ????<br>2??? Clean your hands????<br>3??? Keep physical distance ????<br>4??? Cough/sneeze away into your elbow ????<br>5??? Open windows as much as possible ???? <br><br>We are <a href=""https://twitter.com/hashtag/InThisTogether?src=hash&amp;ref_src=twsrc%5Etfw"">#InThisTogether</a> to beat <a href=""https://twitter.com/hashtag/COVID19?src=hash&amp;ref_src=twsrc%5Etfw"">#COVID19</a><a href=""https://t.co/eFRNDXc8Fc"">pic.twitter.com/eFRNDXc8Fc</a></p>&mdash; World Health Organization (WHO) (WHO) <a href=""https://twitter.com/WHO/status/1402206588123942915?ref_src=twsrc%5Etfw"">June 8, 2021</a></blockquote>
        <script async src=""https://platform.twitter.com/widgets.js"" charset=""utf-8""></script>
    </div>
</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InfoModel>)PageContext?.ViewData;
        public InfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
