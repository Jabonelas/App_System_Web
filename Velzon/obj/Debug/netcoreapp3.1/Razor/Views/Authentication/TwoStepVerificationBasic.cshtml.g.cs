#pragma checksum "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "342434c99f814470c33e6cc84ce8b8f5ff6278cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_TwoStepVerificationBasic), @"mvc.1.0.view", @"/Views/Authentication/TwoStepVerificationBasic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"342434c99f814470c33e6cc84ce8b8f5ff6278cd", @"/Views/Authentication/TwoStepVerificationBasic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Authentication_TwoStepVerificationBasic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logo-light.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/particles.js/particles.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/particles.app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/two-step-verification.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml"
  
    ViewBag.Title = "Two Step Verification";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\" data-layout=\"vertical\" data-topbar=\"light\" data-sidebar=\"dark\" data-sidebar-size=\"lg\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "342434c99f814470c33e6cc84ce8b8f5ff6278cd6361", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml"
Write(Html.Partial("~/Views/Shared/_title_meta.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml"
Write(Html.Partial("~/Views/Shared/_head_css.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "342434c99f814470c33e6cc84ce8b8f5ff6278cd7904", async() => {
                WriteLiteral(@"

    <div class=""auth-page-wrapper pt-5"">
        <!-- auth page bg -->
        <div class=""auth-one-bg-position auth-one-bg"" id=""auth-particles"">
            <div class=""bg-overlay""></div>

            <div class=""shape"">
                <svg xmlns=""http://www.w3.org/2000/svg"" version=""1.1"" xmlns:xlink=""http://www.w3.org/1999/xlink"" viewBox=""0 0 1440 120"">
                    <path d=""M 0,36 C 144,53.6 432,123.2 720,124 C 1008,124.8 1296,56.8 1440,40L1440 140L0 140z""></path>
                </svg>
            </div>
        </div>

        <!-- auth page content -->
        <div class=""auth-page-content"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""text-center mt-sm-5 mb-4 text-white-50"">
                            <div>
                                <a");
                BeginWriteAttribute("href", " href=\"", 1224, "\"", 1264, 1);
#nullable restore
#line 33 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml"
WriteAttributeValue("", 1231, Url.Action("Index", "Dashboard"), 1231, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-inline-block auth-logo\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "342434c99f814470c33e6cc84ce8b8f5ff6278cd9583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </a>
                            </div>
                            <p class=""mt-3 fs-15 fw-medium"">Premium Admin & Dashboard Template</p>
                        </div>
                    </div>
                </div>
                <!-- end row -->

                <div class=""row justify-content-center"">
                    <div class=""col-md-8 col-lg-6 col-xl-5"">
                        <div class=""card mt-4"">

                            <div class=""card-body p-4"">
                                <div class=""mb-4"">
                                    <div class=""avatar-lg mx-auto"">
                                        <div class=""avatar-title bg-light text-primary display-5 rounded-circle"">
                                            <i class=""ri-mail-line""></i>
                                        </div>
                                    </div>
                                </div>

                                <div class=""p-2 mt-4"">
");
                WriteLiteral("                                    <div class=\"text-muted text-center mb-4 mx-lg-3\">\r\n                                        <h4");
                BeginWriteAttribute("class", " class=\"", 2552, "\"", 2560, 0);
                EndWriteAttribute();
                WriteLiteral(">Verify Your Email</h4>\r\n                                        <p>Please enter the 4 digit code sent to <span class=\"fw-semibold\">example@abc.com</span></p>\r\n                                    </div>\r\n\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "342434c99f814470c33e6cc84ce8b8f5ff6278cd12460", async() => {
                    WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-3"">
                                                <div class=""mb-3"">
                                                    <label for=""digit1-input"" class=""visually-hidden"">Dight 1</label>
                                                    <input type=""text""
                                                           class=""form-control form-control-lg bg-light border-light text-center""
                                                           onkeyup=""moveToNext(this, 2)"" maxLength=""1""
                                                           id=""digit1-input"">
                                                </div>
                                            </div><!-- end col -->

                                            <div class=""col-3"">
                                                <div class=""mb-3"">
                                                    <label for=""di");
                    WriteLiteral(@"git2-input"" class=""visually-hidden"">Dight 2</label>
                                                    <input type=""text""
                                                           class=""form-control form-control-lg bg-light border-light text-center""
                                                           onkeyup=""moveToNext(this, 3)"" maxLength=""1""
                                                           id=""digit2-input"">
                                                </div>
                                            </div><!-- end col -->

                                            <div class=""col-3"">
                                                <div class=""mb-3"">
                                                    <label for=""digit3-input"" class=""visually-hidden"">Dight 3</label>
                                                    <input type=""text""
                                                           class=""form-control form-control-lg bg-light border-light text-center""
    ");
                    WriteLiteral(@"                                                       onkeyup=""moveToNext(this, 4)"" maxLength=""1""
                                                           id=""digit3-input"">
                                                </div>
                                            </div><!-- end col -->

                                            <div class=""col-3"">
                                                <div class=""mb-3"">
                                                    <label for=""digit4-input"" class=""visually-hidden"">Dight 4</label>
                                                    <input type=""text""
                                                           class=""form-control form-control-lg bg-light border-light text-center""
                                                           onkeyup=""moveToNext(this, 4)"" maxLength=""1""
                                                           id=""digit4-input"">
                                                </div>
                         ");
                    WriteLiteral("                   </div><!-- end col -->\r\n                                        </div>\r\n                                    ");
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
                WriteLiteral(@"<!-- end form -->

                                    <div class=""mt-3"">
                                        <button type=""button"" class=""btn btn-success w-100"">Confirm</button>
                                    </div>
                                </div>
                            </div>
                            <!-- end card body -->
                        </div>
                        <!-- end card -->

                        <div class=""mt-4 text-center"">
                            <p class=""mb-0"">Didn't receive a code ? <a");
                BeginWriteAttribute("href", " href=\"", 6577, "\"", 6635, 1);
#nullable restore
#line 116 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml"
WriteAttributeValue("", 6584, Url.Action("PasswordResetBasic", "Authentication"), 6584, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""fw-semibold text-primary text-decoration-underline"">Resend</a> </p>
                        </div>

                    </div>
                </div>
                <!-- end row -->
            </div>
            <!-- end container -->
        </div>
        <!-- end auth page content -->
        <!-- footer -->
        <footer class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""text-center"">
                            <p class=""mb-0 text-muted"">
                                &copy;
                                <script>document.write(new Date().getFullYear())</script> Velzon. Crafted with <i class=""mdi mdi-heart text-danger""></i> by Themesbrand
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!-- end Footer -->
    </div>
    <!-- end auth-page-wr");
                WriteLiteral("apper -->\r\n\r\n    ");
#nullable restore
#line 145 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Authentication\TwoStepVerificationBasic.cshtml"
Write(Html.Partial("~/Views/Shared/_vendor_scripts.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- particles js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "342434c99f814470c33e6cc84ce8b8f5ff6278cd19585", async() => {
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
                WriteLiteral("\r\n    <!-- particles app js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "342434c99f814470c33e6cc84ce8b8f5ff6278cd20718", async() => {
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
                WriteLiteral("\r\n    <!-- two-step-verification js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "342434c99f814470c33e6cc84ce8b8f5ff6278cd21859", async() => {
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
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
