#pragma checksum "C:\Users\student\source\repos\graniteOnlineStore\raniteOnlineStore\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b9cc1955a2cd06c53e8a43052f08e2568eb4a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "C:\Users\student\source\repos\graniteOnlineStore\raniteOnlineStore\Views\_ViewImports.cshtml"
using raniteOnlineStore;

#line default
#line hidden
#line 2 "C:\Users\student\source\repos\graniteOnlineStore\raniteOnlineStore\Views\_ViewImports.cshtml"
using raniteOnlineStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b9cc1955a2cd06c53e8a43052f08e2568eb4a8", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8139b8e8d2bc901f0a3ea161bdfef07b944cad3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(136, 74, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"btn-group\" role=\"group\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 210, "\"", 243, 1);
#line 10 "C:\Users\student\source\repos\graniteOnlineStore\raniteOnlineStore\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 217, Url.Action("Edit/"+Model), 217, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 97, true);
            WriteLiteral("><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i>Edit</a>\r\n    <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 341, "\"", 377, 1);
#line 11 "C:\Users\student\source\repos\graniteOnlineStore\raniteOnlineStore\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 348, Url.Action("Details/"+Model), 348, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 95, true);
            WriteLiteral("><i class=\"fa fa-info-circle\" aria-hidden=\"true\"></i>Details</a>\r\n    <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 473, "\"", 508, 1);
#line 12 "C:\Users\student\source\repos\graniteOnlineStore\raniteOnlineStore\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 480, Url.Action("Delete/"+Model), 480, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(509, 69, true);
            WriteLiteral("><i class=\"fa fa-ban\" aria-hidden=\"true\"></i>Delete</a>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
