#pragma checksum "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b32a8e14ae4c86eaad9087c80720825de37d24a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Bot), @"mvc.1.0.view", @"/Views/List/Bot.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/Bot.cshtml", typeof(AspNetCore.Views_List_Bot))]
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
#line 1 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web;

#line default
#line hidden
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web.Models;

#line default
#line hidden
#line 4 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b32a8e14ae4c86eaad9087c80720825de37d24a", @"/Views/List/Bot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df02d679023bc56e9cc697f1d66d605b9a4371f2", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Bot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotDeatilsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
  
    ViewData["Title"] = Localizer["Bot Deatils"];

#line default
#line hidden
            BeginContext(82, 198, true);
            WriteLiteral("<div class=\"container d-flex justify-content-center\">\r\n    <div class=\"wide-board\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <h1 class=\"text-center\">");
            EndContext();
            BeginContext(281, 24, false);
#line 9 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
                                   Write(Localizer["Bot Deatils"]);

#line default
#line hidden
            EndContext();
            BeginContext(305, 133, true);
            WriteLiteral("</h1>\r\n                <hr />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12\"><h1><u>");
            EndContext();
            BeginContext(439, 10, false);
#line 14 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(449, 128, true);
            WriteLiteral(" :</u></h1></div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <h3>");
            EndContext();
            BeginContext(578, 12, false);
#line 18 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
               Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(590, 114, true);
            WriteLiteral(" </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-3 text-center\">");
            EndContext();
            BeginContext(705, 12, false);
#line 22 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
                                      Write(Model.Domain);

#line default
#line hidden
            EndContext();
            BeginContext(717, 52, true);
            WriteLiteral("</div> \r\n            <div class=\"col-3 text-center\">");
            EndContext();
            BeginContext(770, 19, false);
#line 23 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
                                      Write(Model.LastIPAddress);

#line default
#line hidden
            EndContext();
            BeginContext(789, 51, true);
            WriteLiteral("</div>\r\n            <div class=\"col-3 text-center\">");
            EndContext();
            BeginContext(841, 21, false);
#line 24 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Bot.cshtml"
                                      Write(Model.LastLoggedInUTC);

#line default
#line hidden
            EndContext();
            BeginContext(862, 42, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotDeatilsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
