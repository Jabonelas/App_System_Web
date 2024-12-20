#pragma checksum "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Icons\MaterialDesign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a5efc4baea939f13b5199479de93474c5208ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Icons_MaterialDesign), @"mvc.1.0.view", @"/Views/Icons/MaterialDesign.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a5efc4baea939f13b5199479de93474c5208ca", @"/Views/Icons/MaterialDesign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Icons_MaterialDesign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/materialdesign.list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Projects\raju\velzon\Velzon_asp_core\Velzon\Velzon\Views\Icons\MaterialDesign.cshtml"
  
    ViewBag.Title = "Material Design Icons";
    ViewBag.pTitle = "Material Design Icons";
    ViewBag.pageTitle = "Icons";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row icon-demo-content"">
    <div class=""col-12"">
        <div class=""card"">

            <div class=""card-body"">
                <h4 class=""card-title"">New Icons</h4>
                <p class=""card-title-desc mb-2"">Use <code>&lt;i class=""mdi mdi-*-*""&gt;&lt;/i&gt;</code> class.<span class=""badge bg-success"">v 6.5.95</span>.</p>

                <div class=""row icon-demo-content"" id=""newIcons""></div>
            </div> <!-- end card-body -->
        </div> <!-- end card -->

        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title mb-4"">All Icons</h4>
                <div class=""row icon-demo-content"" id=""icons""></div>
            </div> <!-- end card-body -->
        </div> <!-- end card -->
    </div> <!-- end col -->
</div> <!-- end row -->

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">

            <div class=""card-body"">
                <h4 class=""card-title"">Size</h4>

                <div class=");
            WriteLiteral(@"""row icon-demo-content"">
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-18px mdi-account""></i> mdi-18px
                    </div>

                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-24px mdi-account""></i> mdi-24px
                    </div>

                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-36px mdi-account""></i> mdi-36px
                    </div>

                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-48px mdi-account""></i> mdi-48px
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">

            <div class=""card-body"">
                <h4 class=""card-title"">Rotate</h4>

                <div class=""row icon-demo-content"">
             ");
            WriteLiteral(@"       <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-45 mdi-account""></i> mdi-rotate-45
                    </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-90 mdi-account""></i> mdi-rotate-90
                    </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-135 mdi-account""></i> mdi-rotate-135
                    </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-180 mdi-account""></i> mdi-rotate-180
                    </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-225 mdi-account""></i> mdi-rotate-225
                    </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-270 mdi-account""></i> mdi-rotate-270
       ");
            WriteLiteral(@"             </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-rotate-315 mdi-account""></i> mdi-rotate-315
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">

            <div class=""card-body"">
                <h4 class=""card-title"">Spin</h4>

                <div class=""row icon-demo-content"">
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-spin mdi-loading""></i> mdi-spin
                    </div>
                    <div class=""col-xl-3 col-lg-4 col-sm-6"">
                        <i class=""mdi mdi-spin mdi-star""></i> mdi-spin
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end row -->

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- materialdesign icon js-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a5efc4baea939f13b5199479de93474c5208ca8570", async() => {
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
                WriteLiteral("\r\n\r\n    <!-- App js -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a5efc4baea939f13b5199479de93474c5208ca9696", async() => {
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
