#pragma checksum "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9821068c4ca2cf1a951d0962f314cb1aa79c11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9821068c4ca2cf1a951d0962f314cb1aa79c11a", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e0241b3ac3ce846973a3b0cefaae9a47eea6e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GestionProject.ViewModels.ProjectViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml"
  
    Layout = "_DashboardLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-12"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""container"">

                <from method=""get"" asp-action=""Index"">
                    <label> </label>
                    <input type=""text"" name="" key""/>
                    <button type =""submit"" class=""btn btn-primary""> Search</button>

                </from>
            </div>


            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>Name project</th>
                            <th>Client</th>
                            <th>manager project</th>
                            <th>Team Member</th>
                            <th>Date Start</th>
                            <th>Days to Deadline</th>
                            <th>Project Status</th>

                            <th class=""text-nowrap"">Action</th>
                        </tr>
                    </thead>
         ");
            WriteLiteral("           <tbody>\n");
#nullable restore
#line 35 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml"
                         foreach (var project in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 38 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml"
                           Write(project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            \n                            <td>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml"
                           Write(project.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        \n                            <td>");
#nullable restore
#line 42 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml"
                           Write(project.StartDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            


                            <td class=""text-nowrap"">
                                <a href=""#"" data-toggle=""tooltip"" data-original-title=""Edit""> <i class=""fas fa-pencil-alt text-inverse mr-1""></i> </a>
                                <a href=""#"" data-toggle=""tooltip"" data-original-title=""Close""> <i class=""fas fa-times text-danger""></i> </a>
                            </td>
                        </tr>
");
#nullable restore
#line 51 "C:\Users\HP\Desktop\gestiopro\GestionProject\Views\Project\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    </tbody>\n                </table>\n            </div>\n            <!-- /#page-content-wrapper -->\n           \n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GestionProject.ViewModels.ProjectViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
