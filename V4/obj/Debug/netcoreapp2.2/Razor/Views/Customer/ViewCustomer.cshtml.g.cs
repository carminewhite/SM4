#pragma checksum "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c29f5f42958dc882057d6b876162495c0ed263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewCustomer), @"mvc.1.0.view", @"/Views/Customer/ViewCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/ViewCustomer.cshtml", typeof(AspNetCore.Views_Customer_ViewCustomer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c29f5f42958dc882057d6b876162495c0ed263", @"/Views/Customer/ViewCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df4f33652bee458adbb333ee6b23340091ff2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
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
            BeginContext(17, 23, true);
            WriteLiteral("<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(40, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8c29f5f42958dc882057d6b876162495c0ed2633509", async() => {
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
            BeginContext(67, 126, true);
            WriteLiteral("\r\n    <div class=\"col-10 border p-3\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-6 mt-4\">\r\n                <h3>");
            EndContext();
            BeginContext(194, 15, false);
#line 8 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(209, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(211, 14, false);
#line 8 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml"
                                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(225, 48, true);
            WriteLiteral("</h3>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(274, 13, false);
#line 10 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml"
               Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(287, 22, true);
            WriteLiteral("<br>\r\n                ");
            EndContext();
            BeginContext(310, 10, false);
#line 11 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml"
           Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(320, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(323, 11, false);
#line 11 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml"
                        Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(334, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(337, 9, false);
#line 11 "C:\Users\Carmine White\Desktop\SM\V4\V4\Views\Customer\ViewCustomer.cshtml"
                                      Write(Model.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(346, 813, true);
            WriteLiteral(@"
            </p>
        </div>
        <div class=""col-6 mt-4"">
            <p>Monthly Recurring Revenue: $147</p>
            <p>Yearly Recurring Revenue: $1,764</p>
            <p>Customer Value:  $5,292</p>
        </div>
    </div>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Job ID</th>
                <th scope=""col"">Date</th>
                <th scope=""col"">Team</th>
                <th scope=""col"">Revenue</th>
                <th scope=""col"">Cost</th>
                <th scope=""col"">Gross Profit</th>
                <th scope=""col"">GPM</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <!-- Placeholder -->
            </tr>

        </tbody>
    </table>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
