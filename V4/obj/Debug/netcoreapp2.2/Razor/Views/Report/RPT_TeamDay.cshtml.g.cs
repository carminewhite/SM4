#pragma checksum "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Report\RPT_TeamDay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "322d2d416bc6780fef00e911d3ab3689bbed6b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_RPT_TeamDay), @"mvc.1.0.view", @"/Views/Report/RPT_TeamDay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/RPT_TeamDay.cshtml", typeof(AspNetCore.Views_Report_RPT_TeamDay))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"322d2d416bc6780fef00e911d3ab3689bbed6b85", @"/Views/Report/RPT_TeamDay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df4f33652bee458adbb333ee6b23340091ff2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_RPT_TeamDay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobTeamViewModel>
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
            BeginContext(25, 29, true);
            WriteLiteral("    \r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(54, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "322d2d416bc6780fef00e911d3ab3689bbed6b853504", async() => {
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
            BeginContext(81, 96, true);
            WriteLiteral("\r\n    <div class=\"col-10 border\">\r\n        <h3 class=\"mt-4 mr-4\">Team Performance By Date</h3>\r\n");
            EndContext();
            BeginContext(464, 8008, true);
            WriteLiteral(@"        <hr />
        <div class=""p-3"">
            <h5>Team 5 - Wed, Mar 13 2020</h5>


            <h5 class=""bg-info p-3 text-white"">Day Summary</h5>
            <div class=""p-3"">
                <div class=""d-inline-block float-left ml-1 mt-3 mr-4"">
                    <table>
                        <tr>
                            <td class=""text-right p-1""><h4>Revenue:</h4></td>
                            <td class=""ml-3""><h4 class=""ml-2"">$750.25</h4></td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1""><h4>Total Cost:</h4></td>
                            <td><h4 class=""ml-2"">$430.60</h4></td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1""><h4>Total Profit:</h4></td>
                            <td><h4 class=""ml-2"">$319.65</h4></td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1""><h");
            WriteLiteral(@"4>GPM:</h4></td>
                            <td><h4 class=""ml-2"">42.68%</h4></td>
                        </tr>
                    </table>
                </div>
                <div class=""d-inline-block m-3 ml-4"">
                    <table class=""table-bordered"">
                        <tr>
                            <td class=""text-right p-1 pr-2""># of Jobs</td>
                            <td class=""px-3"">4</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Revenue</td>
                            <td class=""px-3"">$750.25</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Labor Costs</td>
                            <td class=""px-3"">$375.25</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Job Costs</td>
                            <td class=""px-3"">$55.35</td>
 ");
            WriteLiteral(@"                       </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Day's Gross Profit</td>
                            <td class=""px-3"">$319.65</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">GPM</td>
                            <td class=""px-3"">42.68%</td>
                        </tr>
                    </table>
                </div>
                <div class=""d-inline-block m-3"">
                    <table class=""table-bordered"">
                        <tr>
                            <td class=""text-right p-1 pr-2"">Hrs budgeted</td>
                            <td class=""px-3"">15.77 hrs</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Hrs on Site</td>
                            <td class=""px-3"">19.35 hrs</td>
                        </tr>
                        <tr>
             ");
            WriteLiteral(@"               <td class=""text-right p-1 pr-2"">Overage</td>
                            <td class=""px-3"">3.58 hrs</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Labor hrs paid</td>
                            <td class=""px-3"">25.5 hrs</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Drive-time</td>
                            <td class=""px-3"">6.15 hrs</td>
                        </tr>
                        <tr>
                            <td class=""text-right p-1 pr-2"">Non-billable %</td>
                            <td class=""px-3"">32.17%</td>
                        </tr>
                    </table>
                </div>

            </div>
            <h5 class=""bg-info p-3 text-white"">Labor</h5>
            <table class=""table table-sm ml-2 mt-4"">
                <thead>
                    <tr>
                        <th>Team");
            WriteLiteral(@" Members</th>
                        <th>Start</th>
                        <th>End</th>
                        <th>Lunch</th>
                        <th>Hours</th>
                        <th>Wage</th>
                        <th>Payroll Exp</th>
                        <th>Total Cost</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Victoria Carrereon</td>
                        <td>8:30am</td>
                        <td>4:30pm</td>
                        <td>30</td>
                        <td>8.5</td>
                        <td>$16.50</td>
                        <td>$1.67</td>
                        <td>$153.94</td>
                    </tr>
                    <tr>
                        <td>Olivia Sanchez</td>
                        <td>8:30am</td>
                        <td>4:30pm</td>
                        <td>30</td>
                        <td>8.5</td>
                        <");
            WriteLiteral(@"td>$14.50</td>
                        <td>$1.42</td>
                        <td>$135.32</td>
                    </tr>
                    <tr>
                        <td>Juana Bautista</td>
                        <td>8:30am</td>
                        <td>4:30pm</td>
                        <td>30</td>
                        <td>8.5</td>
                        <td>$14.50</td>
                        <td>$1.42</td>
                        <td>$135.32</td>
                    </tr>
                    <tr>
                        <td colspan=""6"">&nbsp;</td>
                        <td><b>TOTAL</b></td>
                        <td><b>$424.58</b></td>
                    </tr>
                </tbody>
            </table>
            <h5 class=""bg-info p-3 text-white"">Job Info</h5>
            <table class=""table table-sm ml-2 mt-4"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Customer</th>
                     ");
            WriteLiteral(@"   <th>Start</th>
                        <th>End</th>
                        <th>B. Hrs</th>
                        <th>Act. Hrs</th>
                        <th>Workers</th>
                        <th>Qty</th>
                        <th>Rate</th>
                        <th>Revenue</th>
                        <th>Labor</th>
                        <th>Job Cost</th>
                        <th>Profit</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><a href="""">1</a></td>
                        <td><a href="""">Jessica Wellington</a></td>
                        <td>8:13AM</td>
                        <td>9:34AM</td>
                        <td>3.00</td>
                        <td>2.70</td>
                        <td>3</td>
                        <td>3</td>
                        <td>49.00</td>
                        <td>$147.00</td>
                        <td><a href="""">$49.35</a></td>
     ");
            WriteLiteral(@"                   <td><a href="""">$6.07</a></td>
                        <td>$91.58</td>
                    </tr>
                    <tr>
                        <td><a href="""">2</a></td>
                        <td><a href="""">Chris Lonack</a></td>
                        <td>9:40AM</td>
                        <td>11:29AM</td>
                        <td>3.50</td>
                        <td>3.64</td>
                        <td>3</td>
                        <td>3.5</td>
                        <td>49.00</td>
                        <td>$171.50</td>
                        <td><a href="""">$54.22</a></td>
                        <td><a href="""">$7.21</a></td>
                        <td>$110.17</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobTeamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
