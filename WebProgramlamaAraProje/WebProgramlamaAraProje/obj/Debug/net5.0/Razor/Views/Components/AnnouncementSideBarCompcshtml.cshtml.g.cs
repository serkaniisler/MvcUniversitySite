#pragma checksum "C:\Users\jombi\Documents\GitHub\MvcUniversitySite\WebProgramlamaAraProje\WebProgramlamaAraProje\Views\Components\AnnouncementSideBarCompcshtml.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ff0951ccbeaaf7319edb7ab7a5b8ce57b01575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_AnnouncementSideBarCompcshtml), @"mvc.1.0.view", @"/Views/Components/AnnouncementSideBarCompcshtml.cshtml")]
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
#line 1 "C:\Users\jombi\Documents\GitHub\MvcUniversitySite\WebProgramlamaAraProje\WebProgramlamaAraProje\Views\_ViewImports.cshtml"
using WebProgramlamaAraProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jombi\Documents\GitHub\MvcUniversitySite\WebProgramlamaAraProje\WebProgramlamaAraProje\Views\_ViewImports.cshtml"
using WebProgramlamaAraProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ff0951ccbeaaf7319edb7ab7a5b8ce57b01575", @"/Views/Components/AnnouncementSideBarCompcshtml.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2af2c312f47312d8fea8256ed2c5a4c7355427", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_AnnouncementSideBarCompcshtml : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Announcement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/edulab/images/course-pic.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"box-wrap\" itemprop=\"event\" itemscope itemtype=\" http://schema.org/Course\">\r\n    <div class=\"img-wrap\" itemprop=\"image\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e2ff0951ccbeaaf7319edb7ab7a5b8ce57b015754256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n    <a href=\"#\" class=\"learn-desining-banner\" itemprop=\"name\"> ");
#nullable restore
#line 5 "C:\Users\jombi\Documents\GitHub\MvcUniversitySite\WebProgramlamaAraProje\WebProgramlamaAraProje\Views\Components\AnnouncementSideBarCompcshtml.cshtml"
                                                          Write(Model.DuyuruBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral(" >>></a>\r\n    <div class=\"box-body\" itemprop=\"description\">\r\n        <p>");
#nullable restore
#line 7 "C:\Users\jombi\Documents\GitHub\MvcUniversitySite\WebProgramlamaAraProje\WebProgramlamaAraProje\Views\Components\AnnouncementSideBarCompcshtml.cshtml"
      Write(Model.DuyuruIcerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <section itemprop=\"time\">\r\n            <p><span>Tarih ve Saat:</span> ");
#nullable restore
#line 9 "C:\Users\jombi\Documents\GitHub\MvcUniversitySite\WebProgramlamaAraProje\WebProgramlamaAraProje\Views\Components\AnnouncementSideBarCompcshtml.cshtml"
                                      Write(Model.DuyuruTarih.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("        </section>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Announcement> Html { get; private set; }
    }
}
#pragma warning restore 1591
