#pragma checksum "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29adbd4dc9c3892b48d89ef1ddd53566ec6032dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Display), @"mvc.1.0.view", @"/Views/Job/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Job/Display.cshtml", typeof(AspNetCore.Views_Job_Display))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29adbd4dc9c3892b48d89ef1ddd53566ec6032dc", @"/Views/Job/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df4f33652bee458adbb333ee6b23340091ff2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExistNewCustomersJobsViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(23, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29adbd4dc9c3892b48d89ef1ddd53566ec6032dc3742", async() => {
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
            BeginContext(50, 35, true);
            WriteLiteral("\r\n    <div class=\"col-10 border\">\r\n");
            EndContext();
            BeginContext(132, 53, true);
            WriteLiteral("\r\n        <h2>Existing Customers in DB</h2>\r\n        ");
            EndContext();
            BeginContext(185, 1781, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29adbd4dc9c3892b48d89ef1ddd53566ec6032dc5192", async() => {
                BeginContext(191, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
             foreach (var c in Model.ExistingCustomers)
            {

#line default
#line hidden
                BeginContext(265, 130, true);
                WriteLiteral("                <div class=\"form-row\">\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 395, "\"", 415, 1);
#line 12 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 403, c.FirstName, 403, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(416, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 539, "\"", 558, 1);
#line 15 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 547, c.LastName, 547, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(559, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 682, "\"", 700, 1);
#line 18 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 690, c.Address, 690, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(701, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 824, "\"", 839, 1);
#line 21 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 832, c.City, 832, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(840, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 963, "\"", 977, 1);
#line 24 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 971, c.Zip, 971, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(978, 57, true);
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 27 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
            }

#line default
#line hidden
                BeginContext(1050, 47, true);
                WriteLiteral("\r\n            <h2>New Customers to Add</h2>\r\n\r\n");
                EndContext();
#line 31 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
             foreach (var c in Model.NewCustomers)
            {

#line default
#line hidden
                BeginContext(1164, 130, true);
                WriteLiteral("                <div class=\"form-row\">\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1294, "\"", 1314, 1);
#line 35 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 1302, c.FirstName, 1302, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1315, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1438, "\"", 1457, 1);
#line 38 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 1446, c.LastName, 1446, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1458, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1581, "\"", 1599, 1);
#line 41 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 1589, c.Address, 1589, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1600, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1723, "\"", 1738, 1);
#line 44 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 1731, c.City, 1731, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1739, 123, true);
                WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1862, "\"", 1876, 1);
#line 47 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
WriteAttributeValue("", 1870, c.Zip, 1870, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1877, 57, true);
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 50 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\Display.cshtml"
            }

#line default
#line hidden
                BeginContext(1949, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1966, 26, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExistNewCustomersJobsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591