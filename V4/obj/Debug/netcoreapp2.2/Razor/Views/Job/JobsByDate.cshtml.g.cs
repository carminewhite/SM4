#pragma checksum "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276c42a87d04db376749cb05a33b6a7b87b50170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_JobsByDate), @"mvc.1.0.view", @"/Views/Job/JobsByDate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Job/JobsByDate.cshtml", typeof(AspNetCore.Views_Job_JobsByDate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276c42a87d04db376749cb05a33b6a7b87b50170", @"/Views/Job/JobsByDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df4f33652bee458adbb333ee6b23340091ff2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_JobsByDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavLeft", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/jobsdaterange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("jobsdateform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(18, 23, true);
            WriteLiteral("<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(41, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "276c42a87d04db376749cb05a33b6a7b87b501704742", async() => {
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
            BeginContext(68, 275, true);
            WriteLiteral(@"
    <div class=""col-10 border"">
        <h3 class=""mt-4"">Select Date to View Jobs:</h3>
        <div id=""reportrange"" class=""col-3"" style=""background: #fff; cursor: pointer; padding: 5px 10px; border: 1px solid #ccc; width: 100%"">
            <span></span>
            ");
            EndContext();
            BeginContext(343, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "276c42a87d04db376749cb05a33b6a7b87b501706280", async() => {
                BeginContext(405, 148, true);
                WriteLiteral("\r\n                <input type=\"hidden\" id=\"start\" name=\"startDate\" />\r\n                <input type=\"hidden\" id=\"end\" name=\"endDate\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(560, 673, true);
            WriteLiteral(@"
        </div>

        <table class=""table table-striped mt-4"">
            <thead>
                <tr>
                    <th scope=""col"">Job ID</th>
                    <th scope=""col"">Customer</th>
                    <th scope=""col"">Job Date</th>
                    <th scope=""col"">Start</th>
                    <th scope=""col"">End</th>
                    <th scope=""col"">B. Hrs</th>
                    <th scope=""col"">Act. Hrs</th>
                    <th scope=""col""># Workers</th>
                    <th scope=""col"">Team</th>
                    <th scope=""col"">Revenue</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 30 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                 foreach (var job in Model)
                {


#line default
#line hidden
            BeginContext(1299, 56, true);
            WriteLiteral("                    <tr>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1355, "\"", 1381, 2);
            WriteAttributeValue("", 1362, "/viewjob/", 1362, 9, true);
#line 34 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
WriteAttributeValue("", 1371, job.JobId, 1371, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1382, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1384, 9, false);
#line 34 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                                                     Write(job.JobId);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 41, true);
            WriteLiteral("</a></td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1434, "\"", 1470, 2);
            WriteAttributeValue("", 1441, "/viewcustomer/", 1441, 14, true);
#line 35 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
WriteAttributeValue("", 1455, job.CustomerId, 1455, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1471, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1473, 17, false);
#line 35 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                                                               Write(job.Cust.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1490, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1493, 18, false);
#line 35 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                                                                                   Write(job.Cust.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 39, true);
            WriteLiteral("</a></td>\r\n                        <td>");
            EndContext();
            BeginContext(1551, 36, false);
#line 36 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.ScheduleDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1587, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1623, 13, false);
#line 37 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.StartTime);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1672, 11, false);
#line 38 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.EndTime);

#line default
#line hidden
            EndContext();
            BeginContext(1683, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1719, 17, false);
#line 39 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.BudgetedHours);

#line default
#line hidden
            EndContext();
            BeginContext(1736, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1772, 9, false);
#line 40 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.Hours);

#line default
#line hidden
            EndContext();
            BeginContext(1781, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1817, 7, false);
#line 41 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.Men);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1860, 15, false);
#line 42 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.Tm.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1875, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1911, 10, false);
#line 43 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                       Write(job.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1921, 36, true);
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Job\JobsByDate.cshtml"
                }

#line default
#line hidden
            BeginContext(1976, 1234, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<script type=""text/javascript"">
    var start = moment().subtract(1, 'days');
    var end = moment().subtract(1, 'days');

    function cb(start, end) {
        $('#reportrange span').html(""Select a date..."");
    }

    $('#reportrange').daterangepicker({
        startDate: start,
        endDate: end,
        ranges: {
            'Today': [moment(), moment()],
            'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
            'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        }
    }, cb);

    cb(start, end);
    $('#reportrange').on('apply.daterangepicker', function (ev, picker) {
        $('input#start').v");
            WriteLiteral("al(picker.startDate.format(\'YYYY-MM-DD\'));\r\n        $(\'input#end\').val(picker.endDate.format(\'YYYY-MM-DD\'));\r\n\r\n        $(\'#jobsdateform\').submit();\r\n        console.log(\"form submitted\");\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
