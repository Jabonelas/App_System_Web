#pragma checksum "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Authentication\Errors404Alt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc004b5776fc687f521795237d0e0da33b6b5c70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_Errors404Alt), @"mvc.1.0.view", @"/Views/Authentication/Errors404Alt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc004b5776fc687f521795237d0e0da33b6b5c70", @"/Views/Authentication/Errors404Alt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80afc5ce8da2f6d710778254f78ee8b5408a46c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Authentication_Errors404Alt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Authentication\Errors404Alt.cshtml"
  
    ViewBag.Title = "404 Error alt";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\" data-layout=\"vertical\" data-topbar=\"light\" data-sidebar=\"dark\" data-sidebar-size=\"sm-hover\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc004b5776fc687f521795237d0e0da33b6b5c703706", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Authentication\Errors404Alt.cshtml"
Write(Html.Partial("~/Views/Shared/_title_meta.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Authentication\Errors404Alt.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc004b5776fc687f521795237d0e0da33b6b5c705223", async() => {
                WriteLiteral(@"
    
     <!-- auth-page wrapper -->
        <div class=""auth-page-wrapper auth-bg-cover py-5 d-flex justify-content-center align-items-center min-vh-100"">
            <div class=""bg-overlay""></div>
            <!-- auth-page content -->
            <div class=""auth-page-content overflow-hidden pt-lg-5"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-xl-5"">
                            <div class=""card overflow-hidden"">
                                <div class=""card-body p-4"">
                                    <div class=""text-center"">
                                        <lord-icon class=""avatar-xl""
                                               src=""https://cdn.lordicon.com/ofbvmdiz.json""
                                        trigger=""loop""
                                        colors=""primary:#405189,secondary:#0ab39c"">
                                        </lord-icon>
             ");
                WriteLiteral(@"                           <h1 class=""text-primary mb-4"">Oops !</h1>
                                        <h4 class=""text-uppercase"">Sorry, Page not Found 😭</h4>
                                        <p class=""text-muted mb-4"">The page you are looking for not available!</p>
                                        <a");
                BeginWriteAttribute("href", " href=\"", 1677, "\"", 1717, 1);
#nullable restore
#line 33 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Authentication\Errors404Alt.cshtml"
WriteAttributeValue("", 1684, Url.Action("Index", "Dashboard"), 1684, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-success""><i class=""mdi mdi-home me-1""></i>Back to home</a>
                                    </div>
                                </div>
                            </div>
                            <!-- end card -->
                        </div>
                        <!-- end col -->
    
                    </div>
                    <!-- end row -->
                </div>
                <!-- end container -->
            </div>
            <!-- end auth page content -->
        </div>
        <!-- end auth-page-wrapper -->

    ");
#nullable restore
#line 50 "C:\Users\Vishal\Desktop\asp.net\Modern\Modern\Velzon\Views\Authentication\Errors404Alt.cshtml"
Write(Html.Partial("~/Views/Shared/_vendor_scripts.cshtml"));

#line default
#line hidden
#nullable disable
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
