#pragma checksum "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79dcd92ee663a0a3e8155cead84317be003149d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "E:\DataBases\Vs\WebCore\WebCore\Views\_ViewImports.cshtml"
using WebCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DataBases\Vs\WebCore\WebCore\Views\_ViewImports.cshtml"
using WebCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79dcd92ee663a0a3e8155cead84317be003149d8", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4526315c43cd9efa3325108553415d27ba40a15", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
  
    ViewBag.Titel = " index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a href=""/Student/Create"">Create</a>
<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>id</th>
            <th>name</th>
            <th>age</th>
            <th>Edit</th>
            <th>Details</th>
            <th>Delte</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
           Write(item.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", "  href=\"", 561, "\"", 591, 2);
            WriteAttributeValue("", 569, "/Student/Edit/", 569, 14, true);
#nullable restore
#line 26 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
WriteAttributeValue("", 583, item.id, 583, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("   >Edit</a> </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 630, "\"", 662, 2);
            WriteAttributeValue("", 637, "/Student/Details/", 637, 17, true);
#nullable restore
#line 27 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
WriteAttributeValue("", 654, item.id, 654, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Details</a> </td>\r\n                   \r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 723, "\"", 754, 2);
            WriteAttributeValue("", 730, "/Student/Delete/", 730, 16, true);
#nullable restore
#line 29 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
WriteAttributeValue("", 746, item.id, 746, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> </td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 33 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
