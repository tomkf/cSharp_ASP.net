#pragma checksum "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50547eb692f9e81168847f9bd3c167a3136f917b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TechPro_TechPro), @"mvc.1.0.view", @"/Views/TechPro/TechPro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TechPro/TechPro.cshtml", typeof(AspNetCore.Views_TechPro_TechPro))]
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
#line 1 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\_ViewImports.cshtml"
using in_Class5;

#line default
#line hidden
#line 2 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\_ViewImports.cshtml"
using in_Class5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50547eb692f9e81168847f9bd3c167a3136f917b", @"/Views/TechPro/TechPro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55dec0f29ea67870849a1abf938163307797cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_TechPro_TechPro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<in_Class5.Models.Portfolio.TechnologyProjects>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
  
    ViewData["Title"] = "TechPro";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 104, true);
            WriteLiteral("\r\n<h1>TechPro</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 49, false);
#line 13 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.DisplayNameFor(model => model.TechnoglyName));

#line default
#line hidden
            EndContext();
            BeginContext(313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(369, 45, false);
#line 16 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(414, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(532, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(581, 48, false);
#line 25 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.DisplayFor(modelItem => item.TechnoglyName));

#line default
#line hidden
            EndContext();
            BeginContext(629, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(685, 44, false);
#line 28 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(729, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(785, 65, false);
#line 31 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(850, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(871, 71, false);
#line 32 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(942, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(963, 69, false);
#line 33 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\A01211467\Desktop\cSharp_ASP.net\in_Class5\Views\TechPro\TechPro.cshtml"
}

#line default
#line hidden
            BeginContext(1071, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<in_Class5.Models.Portfolio.TechnologyProjects>> Html { get; private set; }
    }
}
#pragma warning restore 1591
