#pragma checksum "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1e2133b7d6942ac0a9ac461b09b5c4178b82d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Edit), @"mvc.1.0.view", @"/Views/Student/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1e2133b7d6942ac0a9ac461b09b5c4178b82d4", @"/Views/Student/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4526315c43cd9efa3325108553415d27ba40a15", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
  
    ViewBag.Titel = " index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
Write(Html.LabelFor(e => e.id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
Write(Html.EditorFor(e => e.id ,  new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
Write(Html.LabelFor(e => e.name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
Write(Html.EditorFor(e => e.name , new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
Write(Html.LabelFor(e => e.age));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"
Write(Html.EditorFor(e => e.age , new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Edit\" />\r\n");
#nullable restore
#line 22 "E:\DataBases\Vs\WebCore\WebCore\Views\Student\Edit.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
