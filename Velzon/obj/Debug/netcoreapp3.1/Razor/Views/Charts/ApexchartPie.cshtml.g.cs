#pragma checksum "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Charts\ApexchartPie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1302eb95ce95fe821fff0954f42aa56a9e16d0d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts_ApexchartPie), @"mvc.1.0.view", @"/Views/Charts/ApexchartPie.cshtml")]
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
#line 1 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\_ViewImports.cshtml"
using Velzon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\_ViewImports.cshtml"
using Velzon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1302eb95ce95fe821fff0954f42aa56a9e16d0d8", @"/Views/Charts/ApexchartPie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts_ApexchartPie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/apexcharts/apexcharts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/apexcharts-pie.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Charts\ApexchartPie.cshtml"
  
    ViewBag.Title = "Apex Pie Charts";
    ViewBag.pTitle = "Pie Charts";
    ViewBag.pageTitle = "Apexcharts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Simple Pie Chart</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div id=""simple_pie_chart"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""apex-charts"" dir=""ltr""></div>
            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Simple Donut Chart</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div id=""simple_dount_chart"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""apex-charts"" dir=""ltr""></div>
            </div><!-- end card-body -->
        </di");
            WriteLiteral(@"v><!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Updating Donut Chart</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div>
                    <div id=""updating_donut_chart"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""apex-charts"" dir=""ltr""></div>

                    <div class=""d-flex align-items-start flex-wrap gap-2 justify-content-center mt-4"">
                        <button id=""add"" class=""btn btn-light btn-sm"">
                            + ADD
                        </button>

                        <button id=""remove"" class=""btn btn-light btn-sm"">
                            - REMOVE
                        </button>

                        <button id=""randomize"" class=""btn btn-light bt");
            WriteLiteral(@"n-sm"">
                            RANDOMIZE
                        </button>

                        <button id=""reset"" class=""btn btn-light btn-sm"">
                            RESET
                        </button>
                    </div>
                </div>
            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Monochrome Pie Chart</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div id=""monochrome_pie_chart"" data-colors='[""--vz-primary""]' class=""apex-charts"" dir=""ltr""></div>
            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <");
            WriteLiteral(@"h4 class=""card-title mb-0"">Gradient Donut Chart</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div id=""gradient_chart"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""apex-charts"" dir=""ltr""></div>
            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Patterned Donut Chart</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div id=""pattern_chart"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""apex-charts"" dir=""ltr""></div>
            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-xl-6"">
   ");
            WriteLiteral(@"     <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Pie Chart with Image Fill</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div id=""image_pie_chart"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-info""]' class=""apex-charts"" dir=""ltr""></div>
            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- apexcharts -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1302eb95ce95fe821fff0954f42aa56a9e16d0d89631", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- piecharts init -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1302eb95ce95fe821fff0954f42aa56a9e16d0d810765", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- App js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1302eb95ce95fe821fff0954f42aa56a9e16d0d811892", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
