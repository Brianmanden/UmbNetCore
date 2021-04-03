#pragma checksum "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be6032e8bd3f11858ead24d03d9910db269d3d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_UmbracoBackOffice_Default), @"mvc.1.0.view", @"/umbraco/UmbracoBackOffice/Default.cshtml")]
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
#line 1 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Web.WebAssets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Web.Common.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Core.WebAssets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Core.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Core.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Core.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
using Umbraco.Web.BackOffice.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be6032e8bd3f11858ead24d03d9910db269d3d6", @"/umbraco/UmbracoBackOffice/Default.cshtml")]
    public class umbraco_UmbracoBackOffice_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-class", new global::Microsoft.AspNetCore.Html.HtmlString("{\'touch\':touchDevice, \'emptySection\':emptySection, \'umb-drawer-is-visible\':drawer.show, \'umb-tour-is-visible\': tour.show, \'tabbing-active\':tabbingActive}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Umbraco.MainController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("umbracoMainPageBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
  
    bool.TryParse(Context.Request.Query["umbDebug"], out bool isDebug);
    var backOfficePath = globalSettings.GetBackOfficePath(hostingEnvironment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be6032e8bd3f11858ead24d03d9910db269d3d66200", async() => {
                WriteLiteral("\r\n    <base");
                BeginWriteAttribute("href", " href=\"", 813, "\"", 855, 1);
#nullable restore
#line 27 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
WriteAttributeValue("", 820, backOfficePath.EnsureEndsWith('/'), 820, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""robots"" content=""noindex, nofollow"">
    <meta name=""pinterest"" content=""nopin"" />

    <title ng-bind=""$root.locationTitle"">Umbraco</title>

    ");
#nullable restore
#line 37 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
Write(Html.Raw(await runtimeMinifier.RenderCssHereAsync(BackOfficeWebAssets.UmbracoInitCssBundleName)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be6032e8bd3f11858ead24d03d9910db269d3d68321", async() => {
                WriteLiteral(@"

    <noscript>
        <div style=""margin: 10px;"">
            <h3><img src=""assets/img/application/logo.png"" alt=""Umbraco logo"" style=""vertical-align: text-bottom;"" /> Umbraco</h3>
            <p>For full functionality of Umbraco CMS it is necessary to enable JavaScript.</p>
            <p>Here are the <a href=""https://www.enable-javascript.com/"" target=""_blank"" style=""text-decoration: underline;"">instructions how to enable JavaScript in your web browser</a>.</p>
        </div>
    </noscript>

    <div ng-hide=""!authenticated"" ng-cloak>

        <div style=""display: none;"" id=""mainwrapper"" class=""clearfix"">

            <umb-app-header></umb-app-header>

            <div class=""umb-app-content"">

                <umb-navigation></umb-navigation>

                <section id=""contentwrapper"">

                    <div id=""contentcolumn"">
                        <div class=""umb-editor"" ng-view></div>
                    </div>

                </section>

            </div>

  ");
                WriteLiteral(@"          <umb-notifications></umb-notifications>

        </div>

        <umb-tour ng-if=""tour.show""
                  model=""tour"">
        </umb-tour>

        <!-- help dialog controller by the help button - this also forces the backoffice UI to shift 400px  -->
        <umb-drawer data-element=""drawer"" ng-if=""drawer.show"" model=""drawer.model"" view=""drawer.view""></umb-drawer>

        <umb-search ng-if=""search.show"" on-close=""closeSearch()""></umb-search>

    </div>

    <umb-backdrop ng-if=""backdrop.show || infiniteMode""
                  backdrop-opacity=""backdrop.opacity""
                  highlight-element=""backdrop.element""
                  highlight-prevent-click=""backdrop.elementPreventClick""
                  disable-events-on-click=""backdrop.disableEventsOnClick"">
    </umb-backdrop>

    <umb-overlay ng-if=""overlay.show""
                 model=""overlay""
                 position=""{{overlay.position}}""
                 view=""overlay.view""
                 parent-scope=");
                WriteLiteral("\"overlay.parentScope\">\r\n    </umb-overlay>\r\n\r\n    <umb-editors ng-show=\"infiniteMode\"></umb-editors>\r\n\r\n    <umb-login ng-if=\"login.show\"\r\n               on-login=\"hideLoginScreen()\">\r\n    </umb-login>\r\n\r\n    ");
#nullable restore
#line 105 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
Write(await Html.BareMinimumServerVariablesScriptAsync(backOfficeServerVariables));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script>\r\n        document.angularReady = function(app) {\r\n            ");
#nullable restore
#line 109 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
       Write(await Html.AngularValueExternalLoginInfoScriptAsync(signInManager, ViewData.GetExternalSignInError()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 110 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
       Write(Html.AngularValueResetPasswordCodeInfoScript(ViewData["PasswordResetCode"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 111 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
       Write(await Html.AngularValueTinyMceAssetsAsync(runtimeMinifier));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            //required for the noscript trick\r\n            document.getElementById(\"mainwrapper\").style.display = \"inherit\";\r\n        }\r\n    </script>\r\n\r\n    <script src=\"lib/lazyload-js/LazyLoad.min.js\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4505, "\"", 4623, 1);
#nullable restore
#line 118 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
WriteAttributeValue("", 4511, Url.GetUrlWithCacheBust("Application", "BackOffice", null, hostingEnvironment, umbracoVersion, runtimeMinifier), 4511, 112, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
#nullable restore
#line 120 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
     if (isDebug)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
   Write(Html.Raw(profilerHtml.Render()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\UmbracoBackOffice\Default.cshtml"
                                        
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProfilerHtml profilerHtml { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRuntimeMinifier runtimeMinifier { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGlobalSettings globalSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment hostingEnvironment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUmbracoVersion umbracoVersion { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BackOfficeServerVariables backOfficeServerVariables { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BackOfficeSignInManager signInManager { get; private set; }
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
