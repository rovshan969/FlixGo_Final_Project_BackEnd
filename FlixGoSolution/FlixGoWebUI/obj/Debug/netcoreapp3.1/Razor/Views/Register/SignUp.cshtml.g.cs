#pragma checksum "C:\Users\ACER\source\repos\Final_Project_BackEnd\FlixGoSolution\FlixGoWebUI\Views\Register\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f72b20c8081833c64fb4c155f75e732938cc12b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_SignUp), @"mvc.1.0.view", @"/Views/Register/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f72b20c8081833c64fb4c155f75e732938cc12b", @"/Views/Register/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sign__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ACER\source\repos\Final_Project_BackEnd\FlixGoSolution\FlixGoWebUI\Views\Register\SignUp.cshtml"
  
    ViewData["Title"] = "SignUp";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f72b20c8081833c64fb4c155f75e732938cc12b5028", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\"\r\n          content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f72b20c8081833c64fb4c155f75e732938cc12b5437", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""assets/css/bootstrap-reboot.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/bootstrap-grid.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/owl.carousel.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/jquery.mCustomScrollbar.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/nouislider.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/ionicons.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/plyr.css"" />
    <link rel=""stylesheet"" href=""assets/css/photoswipe.css"" />
    <link rel=""stylesheet"" href=""assets/css/default-skin.css"" />
    <link rel=""stylesheet"" href=""assets/css/main.css"" />

    <link rel=""icon""
          type=""image/png""
          href=""assets/icon/favicon-32x32.png""
          sizes=""32x32"" />
    <link rel=""apple-touch-icon"" href=""assets/icon/favicon-32x32.png"" />

    <meta name=""description""");
                BeginWriteAttribute("content", " content=\"", 1177, "\"", 1187, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 1218, "\"", 1228, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\" content=\"Dmitry Volkov\" />\r\n    <title>FlixGo – Online Movies, TV Shows & Cinema</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f72b20c8081833c64fb4c155f75e732938cc12b8673", async() => {
                WriteLiteral(@"
    <div class=""sign section--bg"" data-bg=""img/section/section.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""sign__content"">
                        <!-- registration form -->
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f72b20c8081833c64fb4c155f75e732938cc12b9239", async() => {
                    WriteLiteral("\r\n                            <a href=\"index.html\" class=\"sign__logo\">\r\n                                <img src=\"assets/img/logo.svg\"");
                    BeginWriteAttribute("alt", " alt=\"", 1845, "\"", 1851, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                            </a>

                            <div class=""sign__group"">
                                <input type=""text"" class=""sign__input"" placeholder=""Name"" />
                            </div>

                            <div class=""sign__group"">
                                <input type=""text"" class=""sign__input"" placeholder=""Email"" />
                            </div>

                            <div class=""sign__group"">
                                <input type=""password""
                                       class=""sign__input""
                                       placeholder=""Password"" />
                            </div>

                            <div class=""sign__group sign__group--checkbox"">
                                <input id=""remember""
                                       name=""remember""
                                       type=""checkbox""
                                       checked=""checked"" />
                             ");
                    WriteLiteral(@"   <label for=""remember"">
                                    I agree to the
                                    <a href=""privacy.html"">Privacy Policy</a>
                                </label>
                            </div>

                            <button class=""sign__btn"" type=""button"">Sign up</button>

                            <span class=""sign__text"">
                                Already have an account?
                                <a href=""signin.html"">Sign in!</a>
                            </span>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- JS -->
    <script src=""assets/js/jquery-3.5.1.min.js""></script>
    <script src=""assets/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/js/owl.carousel.min.js""></script>
    <script src=""assets/js/jquery.mousewheel.min.js""></script>
    <script src=""assets/js/jquery.mCustomScrollbar.min.js""></script>
    <script src=""assets/js/wNumb.js""></script>
    <script src=""assets/js/nouislider.min.js""></script>
    <script src=""assets/js/plyr.min.js""></script>
    <script src=""assets/js/jquery.morelines.min.js""></script>
    <script src=""assets/js/photoswipe.min.js""></script>
    <script src=""assets/js/photoswipe-ui-default.min.js""></script>
    <script src=""assets/js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
