#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0b986cd8a03c55fa91d97ffe2208a47612ff72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_ViewAll), @"mvc.1.0.view", @"/Views/Students/ViewAll.cshtml")]
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
#line 1 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\_ViewImports.cshtml"
using Classwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\_ViewImports.cshtml"
using Classwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0b986cd8a03c55fa91d97ffe2208a47612ff72", @"/Views/Students/ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608ff8d9849d6836adede9c20af7cc390cf76207", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Classwork.DAO.StudentDbContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>View All Students</h1>\r\n");
#nullable restore
#line 3 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml"
 foreach (StudentModel student in @Model.students)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>ID : ");
#nullable restore
#line 5 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml"
       Write(student.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Name : ");
#nullable restore
#line 6 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml"
         Write(student.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml"
     if(@student.classworkAvg >= 3)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>This student is doing well!</p>\r\n");
#nullable restore
#line 10 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200901\200901-entity-cw-autumn-ragland\Classwork\Views\Students\ViewAll.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Classwork.DAO.StudentDbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
