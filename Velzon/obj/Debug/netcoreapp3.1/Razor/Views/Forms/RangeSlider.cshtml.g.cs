#pragma checksum "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Forms\RangeSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_RangeSlider), @"mvc.1.0.view", @"/Views/Forms/RangeSlider.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b", @"/Views/Forms/RangeSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_RangeSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/nouislider/nouislider.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/nouislider/nouislider.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/wnumb/wNumb.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/range-sliders.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Forms\RangeSlider.cshtml"
  
    ViewBag.Title = "Range Slider";
    ViewBag.pTitle = "Range Slider";
    ViewBag.pageTitle = "Forms";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <!-- nouisliderribute css -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b5786", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header align-items-center d-flex"">
                <h4 class=""card-title mb-0 flex-grow-1"">Bootstrap Range</h4>
                <div class=""flex-shrink-0"">
                    <div class=""form-check form-switch form-switch-right form-switch-md"">
                        <label for=""default-rangeslider"" class=""form-label text-muted"">Show Code</label>
                        <input class=""form-check-input code-switcher"" type=""checkbox"" id=""default-rangeslider"">
                    </div>
                </div>
            </div><!-- end card header -->

            <div class=""card-body"">
                <div class=""live-preview"">
                    <div>
                        <div>
                            <h5 class=""fs-14"">Default Range</h5>
                            <p class=""text-muted"">Use <code>type=""range""</code> attribute and  <code>form-range</code> class to create a deafult ");
            WriteLiteral(@"range.</p>
                            <!-- Default Range -->
                            <input type=""range"" class=""form-range"" id=""customRange1"">
                        </div>

                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Disabled</h5>
                            <p class=""text-muted"">Use <code>disabled</code> attribute on an input to give it a grayed out appearance and remove pointer events.</p>

                            <!-- Disabled Range -->
                            <input type=""range"" class=""form-range"" id=""disabledRange"" disabled>
                        </div>

                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Min and Max</h5>
                            <p class=""text-muted"">Use <code>min</code> and <code>max</code> attribute with specified range input respectively.</p>

                            <!-- Min and Max -->
                            <input type=""range"" class=""form-range"" min=""0"" ");
            WriteLiteral(@"max=""5"" id=""customRange2"">
                        </div>

                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Steps</h5>
                            <p class=""text-muted"">By default, range inputs “snap” to integer values. To change this, you can specify a step value. In the example below, we double the number of steps by using <code>step=""0.5""</code> attribute.</p>

                            <!-- Steps -->
                            <input type=""range"" class=""form-range"" min=""0"" max=""5"" step=""0.5"" id=""customRange3"">
                        </div>
                    </div>
                </div>


                <div class=""d-none code-view"">
<pre class=""language-markup"">
<code>&lt;!-- Default Range --&gt;
&lt;input type=&quot;range&quot; class=&quot;form-range&quot; id=&quot;customRange1&quot;&gt;

&lt;!-- Disabled Range --&gt;
&lt;input type=&quot;range&quot; class=&quot;form-range&quot; id=&quot;disabledRange&quot; disabled&gt;

&lt;!-- Min an");
            WriteLiteral(@"d Max --&gt;
&lt;input type=&quot;range&quot; class=&quot;form-range&quot; min=&quot;0&quot; max=&quot;5&quot; id=&quot;customRange2&quot;&gt;

&lt;!-- Steps --&gt;
&lt;input type=&quot;range&quot; class=&quot;form-range&quot; min=&quot;0&quot; max=&quot;5&quot; step=&quot;0.5&quot; id=&quot;customRange3&quot;&gt;</code></pre>
                </div>

            </div>
            <!-- end card body -->
        </div>
        <!-- end card -->
    </div> <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Nouislider</h4>
            </div><!-- end card header -->

            <div class=""card-body"">

                <p class=""text-muted mb-4"">noUiSlider is a lightweight JavaScript range slider</p>

                <div class=""live-preview"">
                    <div>
                        <div class=""mb-3"">
                            <d");
            WriteLiteral(@"iv class=""row align-items-center"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Basic Example</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div data-rangeslider></div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row align-items-center"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Multi elements range handle</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div data-multielement></div>
                                </div");
            WriteLiteral(@"><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Colorpicker</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""sliders"" id=""red""></div>
                                    <div class=""sliders"" id=""green""></div>
                                    <div class=""sliders"" id=""blue""></div>

                                    <div id=""result""></div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                      ");
            WriteLiteral(@"  <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Using HTML5 Input Elements</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""d-inline-flex gap-2 mb-3"">
                                        <select id=""input-select"" class=""form-select form-select-sm w-xs shadow-none""></select>
                                        <input type=""number"" class=""form-control form-control-sm w-xs shadow-none"" min=""-20"" max=""40"" step=""1"" id=""input-number"">
                                    </div>
                                    <div id=""html5""></div>

                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                ");
            WriteLiteral(@"        <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Non linear slider</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div id=""nonlinear""></div>
                                    <div class=""d-flex justify-content-between"">
                                        <div class=""example-val"" id=""lower-value""></div>
                                        <div class=""example-val"" id=""upper-value""></div>
                                    </div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row"">
                                ");
            WriteLiteral(@"<div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Locking sliders together</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""slider"" id=""slider1""></div>
                                    <span class=""example-val mt-2"" id=""slider1-span""></span>

                                    <div class=""slider"" id=""slider2""></div>
                                    <span class=""example-val mt-2"" id=""slider2-span""></span>

                                    <button id=""lockbutton"" class=""btn btn-primary"" style=""float: right; margin: 20px 0 0;"">Lock</button>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row align-items-center"">");
            WriteLiteral(@"
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Merging overlapping tooltips</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""slider"" id=""slider-merging-tooltips""></div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Only showing tooltips when sliding handle</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""slider"" id=""slider-hide""></div>
                    ");
            WriteLiteral(@"            </div><!-- end col -->
                            </div><!-- end row-->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""mt-4 mb-5"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Moving the slider by clicking pips</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""slider"" id=""slider-pips""></div>
                                </div><!-- end col -->
                            </div><!-- end row-->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5");
            WriteLiteral(@" class=""fs-14"">Colored Connect Elements</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div class=""slider"" id=""slider-color""></div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <div class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Creating a toggle</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div id=""slider-toggle""></div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>

                        <di");
            WriteLiteral(@"v class=""border border-dashed""></div>

                        <div class=""my-4"">
                            <div class=""row"">
                                <div class=""col-lg-3"">
                                    <h5 class=""fs-14"">Soft limits</h5>
                                </div><!-- end col -->
                                <div class=""col-lg-9"">
                                    <div id=""soft""></div>
                                </div><!-- end col -->
                            </div><!-- end row -->
                        </div>
                    </div>
                </div>

            </div><!-- end card-body -->
        </div><!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Color Scheme</h4>
            </div><!-- end card header -->
            <div class=""card-body"">

 ");
            WriteLiteral(@"               <div class=""row"">
                    <div class=""col-xl-4 col-lg-6"">
                        <div>
                            <h5 class=""fs-14"">Primary</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""primary""</code> attribute to set primary color scheme.</p>
                            <div data-rangeslider data-slider-color=""primary""></div>
                        </div>
                    </div>
                    <!-- end col -->
                    <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4 mt-lg-0"">
                            <h5 class=""fs-14"">Secondary</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""secondary""</code> attribute to set secondary color scheme.</p>
                            <div data-rangeslider data-slider-color=""secondary""></div>
                        </div>
                    </div>
                    <!-- end col -->
                 ");
            WriteLiteral(@"   <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4 mt-xl-0"">
                            <h5 class=""fs-14"">Success</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""success""</code> attribute to set success color scheme.</p>
                            <div data-rangeslider data-slider-color=""success""></div>
                        </div>
                    </div>
                    <!-- end col -->
                </div>
                <!-- end row -->

                <div class=""row mt-4"">
                    <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Info</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""info""</code> attribute to set info color scheme.</p>
                            <div data-rangeslider data-slider-color=""info""></div>
                        </div>
                    </div>
             ");
            WriteLiteral(@"       <!-- end col -->
                    <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Warning</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""warning""</code> attribute to set warning color scheme.</p>
                            <div data-rangeslider data-slider-color=""warning""></div>
                        </div>
                    </div>
                    <!-- end col -->
                    <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Danger</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""danger""</code> attribute to set danger color scheme.</p>
                            <div data-rangeslider data-slider-color=""danger""></div>
                        </div>
                    </div>
                    <!-- end col -->
                </div>
         ");
            WriteLiteral(@"       <!-- end row -->

                <div class=""row mt-4"">
                    <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4"">
                            <h5 class=""fs-14"">Dark</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-color=""dark""</code> attribute to set dark color scheme.</p>
                            <div data-rangeslider data-slider-color=""dark""></div>
                        </div>
                    </div>
                    <!-- end col -->
                </div>
                <!-- end row -->
            </div>
            <!-- end card body -->
        </div>
        <!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Sizes</h4>
            </div><!-- end card header -->
            <div class=""card-body"">
             ");
            WriteLiteral(@"   <div class=""row"">
                    <div class=""col-xl-4 col-lg-6"">
                        <div>
                            <h5 class=""fs-14"">Large</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-size=""lg""</code> attribute to set large size rangeslider.</p>
                            <div data-rangeslider data-slider-size=""lg""></div>
                        </div>
                    </div>
                    <!-- end col -->
                    <div class=""col-xl-4 col-lg-6"">
                        <div class=""mt-4 mt-lg-0"">
                            <h5 class=""fs-14"">Medium</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-size=""md""</code> attribute to set medium size data-rangeslider.</p>
                            <div data-rangeslider data-slider-size=""md""></div>
                        </div>
                    </div>
                    <!-- end col -->

                    <div class=""col-xl-4 col-lg-6"">");
            WriteLiteral(@"
                        <div class=""mt-4 mt-xl-0"">
                            <h5 class=""fs-14"">Small</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-size=""sm""</code> attribute to set small size rangeslider.</p>
                            <div data-rangeslider data-slider-size=""sm""></div>
                        </div>
                    </div>
                    <!-- end col -->
                </div>
                <!-- end row -->
            </div>
            <!-- end card body -->
        </div>
        <!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Styling</h4>
            </div><!-- end card header -->
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div>
            ");
            WriteLiteral(@"                <h5 class=""fs-14"">Line Rangeslider</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-style=""line""</code> attribute to set line rangeslider.</p>
                            <div data-rangeslider data-slider-style=""line""></div>
                        </div>
                    </div>
                    <!-- end col -->
                    <div class=""col-lg-6"">
                        <div class=""mt-4 mt-lg-0"">
                            <h5 class=""fs-14"">Circle Bordered Rangeslider</h5>
                            <p class=""text-muted mb-4"">Use <code>data-slider-style=""border""</code> attribute to set circle bordered rangeslider.</p>
                            <div data-rangeslider data-slider-style=""border""></div>
                        </div>
                    </div>
                    <!-- end col -->

                    <div class=""row mt-4"">
                        <div class=""col-lg-6"">
                            <div class=""mt-4"">");
            WriteLiteral(@"
                                <h5 class=""fs-14"">Square Rangeslider</h5>
                                <p class=""text-muted mb-4"">Use  <code>data-slider-style=""square""</code> attribute to set square shape rangeslider.</p>
                                <div data-rangeslider data-slider-style=""square""></div>
                            </div>
                        </div>
                        <!-- end col -->
                    </div>
                    <!-- end row -->
                </div>
                <!-- end card body -->
            </div>
            <!-- end card -->
        </div>
    </div>
    <!-- end col -->
</div>
<!-- end row -->

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- nouisliderribute js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b29497", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b30597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- range slider init -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b31731", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef027eac9c0eb3a4bbdd680e6f1207659d7dd80b32835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
