#pragma checksum "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5087e1ac9ca71e6a226333eae05d641d60ffffe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Courses), @"mvc.1.0.view", @"/Views/Home/Courses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Courses.cshtml", typeof(AspNetCore.Views_Home_Courses))]
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
#line 1 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\_ViewImports.cshtml"
using SoftwareCourse;

#line default
#line hidden
#line 2 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\_ViewImports.cshtml"
using SoftwareCourse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5087e1ac9ca71e6a226333eae05d641d60ffffe7", @"/Views/Home/Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c40b72b6022e5f4e7cd15ee9ae8741733cc0115", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Courses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SoftwareCourse.Models.Courses>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
  
    ViewData["Title"] = "Courses";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 163, true);
            WriteLiteral("\r\n<h2>Kurslar</h2>\r\n\r\n<div class=\"container-fluid\">\r\n    \r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(305, 46, false);
#line 15 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
               Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(351, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(419, 53, false);
#line 18 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
               Write(Html.DisplayNameFor(model => model.CourseDescription));

#line default
#line hidden
            EndContext();
            BeginContext(472, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(540, 49, false);
#line 21 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
               Write(Html.DisplayNameFor(model => model.CourseTeacher));

#line default
#line hidden
            EndContext();
            BeginContext(589, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(752, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(825, 45, false);
#line 31 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(870, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(950, 52, false);
#line 34 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CourseDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1082, 48, false);
#line 37 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CourseTeacher));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 73, true);
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Users\HP\source\repos\SoftwareCourse\SoftwareCourse\Views\Home\Courses.cshtml"
            }

#line default
#line hidden
            BeginContext(1218, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SoftwareCourse.Models.Courses>> Html { get; private set; }
    }
}
#pragma warning restore 1591
