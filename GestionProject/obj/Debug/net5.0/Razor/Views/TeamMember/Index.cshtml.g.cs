#pragma checksum "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b802c8b84ed3ed224aea70553348b61b90c32a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamMember_Index), @"mvc.1.0.view", @"/Views/TeamMember/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\_ViewImports.cshtml"
using GestionProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\_ViewImports.cshtml"
using GestionProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b802c8b84ed3ed224aea70553348b61b90c32a7", @"/Views/TeamMember/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e0241b3ac3ce846973a3b0cefaae9a47eea6e7", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamMember_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GestionProject.ViewModels.TeamMemberViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
   Layout = "_DashboardLayout"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
   
    ViewData["Title"] = "index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row page-titles"">
    <div class=""col-md-5 align-self-center"">
        <h3 class=""txt-themecolor""> Teams members</h3>
    </div>
    <div class=""col-md-7 align-self-center"">

    </div>

</div>

<div id=""PlaceHolderHere""></div>

<button type=""button"" clasa=""btn btn-primary"" data-toggle=""ajax_modal"" data-target=""#addTeamMember""
        data-url=""");
#nullable restore
#line 20 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
             Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></button>\"\n\n\n<table class=\" table\">\n    <thead>\n\n        <tr>\n\n\n            <th>FullName </th>\n            <th> Email </th>\n            <th>Group </th>\n            <th>  Price </th>\n\n\n        </tr>\n");
#nullable restore
#line 36 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
         foreach (var teamMember in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
       Write(teamMember.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
       Write(teamMember.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
       Write(teamMember.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
       Write(teamMember.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        

        <td class=""text-nowrap"">
            <a href=""#"" data-toggle=""tooltip"" data-original-title=""Edit""> <i class=""fas fa-pencil-alt text-inverse mr-1""></i> </a>
            <a href=""#"" data-toggle=""tooltip"" data-original-title=""Close""> <i class=""fas fa-times text-danger""></i> </a>
        </td>working
    </tr>
");
#nullable restore
#line 50 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\TeamMember\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n    </thead>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GestionProject.ViewModels.TeamMemberViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
