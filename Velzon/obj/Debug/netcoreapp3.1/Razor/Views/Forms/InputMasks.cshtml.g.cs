#pragma checksum "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Forms\InputMasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b4fb03518d0a3be60682c2696066e42b4956ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_InputMasks), @"mvc.1.0.view", @"/Views/Forms/InputMasks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b4fb03518d0a3be60682c2696066e42b4956ef", @"/Views/Forms/InputMasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_InputMasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/cleave.js/cleave.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/form-masks.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Forms\InputMasks.cshtml"
  
    ViewBag.Title = "Input Masks";
    ViewBag.pTitle = "Input Masks";
    ViewBag.pageTitle = "Forms";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title mb-0"">Examples</h4>
            </div><!-- end card header -->

            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7b4fb03518d0a3be60682c2696066e42b4956ef5444", async() => {
                WriteLiteral(@"
                    <div>
                        <h5 class=""fs-14 mb-3 text-muted"">Date Formatting</h5>
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-date"" class=""form-label"">Date</label>
                                    <input type=""text"" class=""form-control"" placeholder=""DD-MM-YYYY"" id=""cleave-date"">
                                </div>

                            </div><!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-date-format"" class=""form-label"">Date Formatting</label>
                                    <input type=""text"" class=""form-control"" placeholder=""MM/YY"" id=""cleave-date-format"">
                                </div>
                            </div><!-- end col -->
                        </di");
                WriteLiteral(@"v><!-- end row -->
                    </div>

                    <div class=""border mt-3 border-dashed""></div>

                    <div class=""mt-4"">
                        <h6 class=""mb-3 fs-14 text-muted"">Time Formatting</h6>
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-time"" class=""form-label"">Time</label>
                                    <input type=""text"" class=""form-control"" placeholder=""hh:mm:ss"" id=""cleave-time"">
                                </div>

                            </div><!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-time-format"" class=""form-label"">Time Formatting</label>
                                    <input type=""text"" class=""form-control"" placeholder=""hh:mm"" id=""cleave-time-fo");
                WriteLiteral(@"rmat"">
                                </div>
                            </div><!-- end col -->
                        </div><!-- end row -->
                    </div>

                    <div class=""border mt-3 border-dashed""></div>

                    <div class=""mt-4"">
                        <h5 class=""fs-14 mb-3 text-muted"">Custom Options</h5>
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-ccard"" class=""form-label"">Credit Card</label>
                                    <input type=""text"" class=""form-control"" id=""cleave-ccard"" placeholder=""xxxx xxxx xxxx xxxx"">
                                </div>

                            </div><!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-delimiter"" class=""form-l");
                WriteLiteral(@"abel"">Delimiter</label>
                                    <input type=""text"" class=""form-control"" id=""cleave-delimiter"" placeholder=""xxx·xxx·xxx"">
                                </div>
                            </div><!-- end col -->
                        </div><!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-delimiters"" class=""form-label"">Delimiters</label>
                                    <input type=""text"" class=""form-control"" id=""cleave-delimiters"" placeholder=""xxx.xxx.xxx-xx"">
                                </div>
                            </div><!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""mb-3"">
                                    <label for=""cleave-prefix"" class=""form-label"">Prefix</label>
                                    <input type=""tex");
                WriteLiteral(@"t"" class=""form-control"" id=""cleave-prefix"">
                                </div>
                            </div><!-- end col -->
                        </div><!-- end row -->

                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""mb-3 mb-xl-0"">
                                    <label for=""cleave-phone"" class=""form-label"">Phone</label>
                                    <input type=""text"" class=""form-control"" id=""cleave-phone"" placeholder=""(xxx)xxx-xxxx"">
                                </div>
                            </div><!-- end col -->

                            <div class=""col-xl-6"">
                                <div class=""mb-0"">
                                    <label for=""cleave-numeral"" class=""form-label"">Numeral Formatting</label>
                                    <input type=""text"" class=""form-control"" placeholder=""Enter numeral"" id=""cleave-numeral"">
                           ");
                WriteLiteral("     </div>\r\n                            </div><!-- end col -->\r\n                        </div><!-- end row -->\r\n\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<!-- end form -->\r\n            </div><!-- end card-body -->\r\n        </div><!-- end card -->\r\n    </div>\r\n    <!-- end col -->\r\n</div>\r\n<!-- end row -->\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- cleave.js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7b4fb03518d0a3be60682c2696066e42b4956ef12697", async() => {
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
                WriteLiteral("\r\n    <!-- form masks init -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7b4fb03518d0a3be60682c2696066e42b4956ef13829", async() => {
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7b4fb03518d0a3be60682c2696066e42b4956ef14933", async() => {
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
