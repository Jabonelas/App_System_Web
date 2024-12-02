#pragma checksum "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Charts\Echarts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172b5eb2f142b42a0c2460774ec6ce6b3e51aa05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts_Echarts), @"mvc.1.0.view", @"/Views/Charts/Echarts.cshtml")]
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
#line 1 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\_ViewImports.cshtml"
using Velzon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\_ViewImports.cshtml"
using Velzon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172b5eb2f142b42a0c2460774ec6ce6b3e51aa05", @"/Views/Charts/Echarts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Charts_Echarts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/echarts/echarts.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/echarts.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Charts\Echarts.cshtml"
  
    ViewBag.Title = "E Charts";
    ViewBag.pTitle = "E Charts";
    ViewBag.pageTitle = "Charts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Line Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-line"" data-colors='[""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Stacked Line Chart</h4>
                                    </div>
       ");
            WriteLiteral(@"                             <div class=""card-body"">
                                        <div id=""chart-line-stacked"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->
        
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Area Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-area"" data-colors='[""--vz-suc");
            WriteLiteral(@"cess""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Stacked Area Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-area-stacked"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
       ");
            WriteLiteral(@"                 </div>
                        <!-- end row -->
        
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Step Line</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-step-line"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
          ");
            WriteLiteral(@"                              <h4 class=""card-title mb-0"">Line Y Category</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-line-y-category"" data-colors='[""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->
        
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Basic Bar</h4>
                                    </div>
                                    <div class=""card-body"">
           ");
            WriteLiteral(@"                             <div id=""chart-bar"" data-colors='[""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Bar Label</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-bar-label-rotation"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div");
            WriteLiteral(@">
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Horizontal Bar</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-horizontal-bar"" data-colors='[""--vz-primary"", ""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                               ");
            WriteLiteral(@"     <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Stacked Horizontal Bar</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-horizontal-bar-stacked"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Pie Charts</h4>
       ");
            WriteLiteral(@"                             </div>
                                    <div class=""card-body"">
                                        <div id=""chart-pie"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Doughnut Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-doughnut"" data-colors='[""--vz-primary"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-info""]' class=""e-charts""");
            WriteLiteral(@"></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Basic Scatter Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-scatter"" data-colors='[""--vz-primary""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                      ");
            WriteLiteral(@"      <!-- end col -->
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Candlestick Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-candlestick"" data-colors='[""--vz-danger"", ""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                            
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                           ");
            WriteLiteral(@"         <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Graph Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-graph"" data-colors='[""--vz-primary""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Treemap Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-treemap"" data-colors='[""--vz-primary"", ""--vz-");
            WriteLiteral(@"success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Sunburst Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-sunburst"" data-colors='[""--vz-warning"", ""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                   ");
            WriteLiteral(@"         </div>
                            <!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Parallel Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-parallel"" data-colors='[""--vz-success""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <");
            WriteLiteral(@"div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Sankey Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-sankey"" data-colors='[""--vz-info"", ""--vz-success"", ""--vz-warning"", ""--vz-danger"", ""--vz-primary""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Funnel Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""");
            WriteLiteral(@"chart-funnel"" data-colors='[""--vz-primary"", ""--vz-danger, ""--vz-info"", ""--vz-success"", ""--vz-wrning""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Gauge Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-gauge"" data-colors='[""--vz-primary""]' class=""e-charts""></div>
                                    </div>
                                </div>
");
            WriteLiteral(@"                                <!-- end card -->
                            </div>
                            <!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title mb-0"">Heatmap Chart</h4>
                                    </div>
                                    <div class=""card-body"">
                                        <div id=""chart-heatmap""  data-colors='[""--vz-primary"", ""--vz-warning""]' class=""e-charts""></div>
                                    </div>
                                </div>
                                <!-- end card -->
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- echarts js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172b5eb2f142b42a0c2460774ec6ce6b3e51aa0522949", async() => {
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
                WriteLiteral("\r\n\r\n    <!-- echarts init -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172b5eb2f142b42a0c2460774ec6ce6b3e51aa0524082", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "172b5eb2f142b42a0c2460774ec6ce6b3e51aa0525209", async() => {
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591