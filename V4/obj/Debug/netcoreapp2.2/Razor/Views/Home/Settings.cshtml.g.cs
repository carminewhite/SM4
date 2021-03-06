#pragma checksum "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Home\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac34dd07903fe2cf1407ddd978420a517fae1ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Settings), @"mvc.1.0.view", @"/Views/Home/Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Settings.cshtml", typeof(AspNetCore.Views_Home_Settings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac34dd07903fe2cf1407ddd978420a517fae1ac1", @"/Views/Home/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df4f33652bee458adbb333ee6b23340091ff2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavLeft", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/save-company-settings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 27, true);
            WriteLiteral("    <div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(43, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac34dd07903fe2cf1407ddd978420a517fae1ac14396", async() => {
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
            BeginContext(70, 43, true);
            WriteLiteral("\r\n    <div class=\"col-10 border\">\r\n        ");
            EndContext();
            BeginContext(113, 3816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac34dd07903fe2cf1407ddd978420a517fae1ac15697", async() => {
                BeginContext(165, 889, true);
                WriteLiteral(@"
            <input type=""hidden"" name=""CompanyId"" value=""1"" />
            <div class=""p-3 mt-4"">
                <h3 class=""d-inline"">Custom Settings</h3>
                <input class=""btn btn-success float-right"" type=""submit"" value=""Save Settings"" />
            </div>
            <div class=""border rounded p-3"">
                <h5>Payroll Burden (percent)</h5>
                <p>This is a multiplier that will be added to each wage expense, to get a true look at the cost per hour for each employee.  Run this calculation separately based</p>
                <p class=""ml-2""><i>Example:  Pull a wage report from payroll.  If your gross wages are $15,000, and the ""Employer Cost"" other than wages is $1,200, then your Payroll Burden is 8% (1,200 / 15,000)</i></p>
                <p><input class=""col-1 mx-sm-2 p-1 text-right"" type=""text"" name=""EE_payroll_burden_percent""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1054, "\"", 1094, 1);
#line 15 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Home\Settings.cshtml"
WriteAttributeValue("", 1062, Model.EE_payroll_burden_percent, 1062, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1095, 753, true);
                WriteLiteral(@"/>%</p>
            </div>
            <div class=""mt-1 border rounded p-3"">
                <h5>Merchant Fees (percent)</h5>
                <p>An estimate of how much in merchant fees per job.  This multiple is added to the charge of each job, to estimate how much in merchant fees each job is costing.  Even if this particular job paid by check/cash, this is still added as an average.</p>
                <p class=""ml-2""><i>Example:  Pull a P&L report.  Take your total merchant expense and divide by top-line revenue.  For example, if your monthly revenue is $100,000 and you paid $2,250 in merchant fees, your % per job is 2.25%</i></p>
                <p><input class=""col-1 mx-sm-2 p-1 text-right"" type=""text"" name=""Avg_Merch_Fees_percent""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1848, "\"", 1885, 1);
#line 21 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Home\Settings.cshtml"
WriteAttributeValue("", 1856, Model.Avg_Merch_Fees_percent, 1856, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1886, 678, true);
                WriteLiteral(@"/>%</p>
            </div>
            <div class=""mt-1 border rounded p-3"">
                <h5>Vehicle expense (percent)</h5>
                <p>An estimate of how much in vehicle costs per job.  This multiple is added to the charge of each job, to estimate how much in vehicle expense each job is costing.</p>
                <p class=""ml-2""><i>Example:  Pull a P&L report.  Take your total vehicle expense and divide by top-line revenue.  For example, if your monthly revenue is $100,000 and you paid $1,350 in vehicle expenses, your % per job is 1.35%</i></p>
                <p><input class=""col-1 mx-sm-2 p-1 text-right"" type=""text"" name=""Avg_Vehicle_Costs_percent""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2564, "\"", 2604, 1);
#line 27 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Home\Settings.cshtml"
WriteAttributeValue("", 2572, Model.Avg_Vehicle_Costs_percent, 2572, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2605, 704, true);
                WriteLiteral(@" />%</p>
            </div>
            <div class=""mt-1 border rounded p-3"">
                <h5>Average Supplies Cost per Job (percent)</h5>
                <p>An estimate of how much in supply costs per job.  This multiple is added to the charge of each job, to estimate how much in supply expense each job is costing.</p>
                <p class=""ml-2""><i>Example:  Pull a P&L report.  Take your total supplies expense and divide by top-line revenue.  For example, if your monthly revenue is $100,000 and you purchased $3,450 in supplies/chemicals, your % per job is 3.45%</i></p>
                <p><input class=""col-1 mx-sm-2 p-1 text-right"" type=""text"" name=""Avg_Per_Job_Supply_Cost_amount""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3309, "\"", 3354, 1);
#line 33 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Home\Settings.cshtml"
WriteAttributeValue("", 3317, Model.Avg_Per_Job_Supply_Cost_amount, 3317, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3355, 490, true);
                WriteLiteral(@"/>%</p>
            </div>
            <div class=""mt-1 border rounded p-3"">
                <h5>Misc additional (percent)</h5>
                <p>Add a modifier to each job expense, to factor in other items not listed here.</p>
                <p class=""ml-2""><i>Example:  Things not accounted above, like commission.  If average commission expense is 1%, add that here</i></p>
                <p><input class=""col-1 mx-sm-2 p-1 text-right"" type=""text"" name=""Misc_Additional_percent""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3845, "\"", 3883, 1);
#line 39 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Home\Settings.cshtml"
WriteAttributeValue("", 3853, Model.Misc_Additional_percent, 3853, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3884, 38, true);
                WriteLiteral(" />%</p>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3929, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
