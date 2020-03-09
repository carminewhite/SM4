#pragma checksum "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3169a15a56cc4f08abdd8e1ecc9856287eeee1c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Employees), @"mvc.1.0.view", @"/Views/Employee/Employees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Employees.cshtml", typeof(AspNetCore.Views_Employee_Employees))]
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
#line 1 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\_ViewImports.cshtml"
using V4;

#line default
#line hidden
#line 2 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\_ViewImports.cshtml"
using V4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3169a15a56cc4f08abdd8e1ecc9856287eeee1c7", @"/Views/Employee/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df4f33652bee458adbb333ee6b23340091ff2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavLeft", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 23, true);
            WriteLiteral("<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(46, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3169a15a56cc4f08abdd8e1ecc9856287eeee1c73494", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(73, 491, true);
            WriteLiteral(@"
    <div class=""col-10 border"">
        <h3 class=""mt-4"">Employee List</h3>
        <a href=""/update-employees"" class=""btn btn-primary"">Update Employees from T-Sheets</a>

        <table class=""table table-striped mt-4"">
            <thead>
                <tr>
                    <th scope=""col"">Employee ID</th>
                    <th scope=""col"">Employee</th>
                    <th scope=""col"">Active</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 17 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml"
                 foreach (var emp in Model)
                {

#line default
#line hidden
            BeginContext(628, 66, true);
            WriteLiteral("                    <tr>\r\n                        <td><a href=\"/\">");
            EndContext();
            BeginContext(695, 6, false);
#line 20 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml"
                                   Write(emp.Id);

#line default
#line hidden
            EndContext();
            BeginContext(701, 51, true);
            WriteLiteral("</a></td>\r\n                        <td><a href=\"/\">");
            EndContext();
            BeginContext(753, 14, false);
#line 21 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml"
                                   Write(emp.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(767, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(769, 13, false);
#line 21 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml"
                                                   Write(emp.Last_Name);

#line default
#line hidden
            EndContext();
            BeginContext(782, 39, true);
            WriteLiteral("</a></td>\r\n                        <td>");
            EndContext();
            BeginContext(822, 10, false);
#line 22 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml"
                       Write(emp.Active);

#line default
#line hidden
            EndContext();
            BeginContext(832, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Employee\Employees.cshtml"
                }

#line default
#line hidden
            BeginContext(885, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
