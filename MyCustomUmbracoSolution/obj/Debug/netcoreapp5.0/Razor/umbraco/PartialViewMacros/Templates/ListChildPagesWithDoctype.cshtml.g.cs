#pragma checksum "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c2f55c7c8eeec6789cabacd047f748a07adc108"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_ListChildPagesWithDoctype), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/ListChildPagesWithDoctype.cshtml")]
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
#line 1 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
using Umbraco.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
using Umbraco.Core.Models.PublishedContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
using Umbraco.Web.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c2f55c7c8eeec6789cabacd047f748a07adc108", @"/umbraco/PartialViewMacros/Templates/ListChildPagesWithDoctype.cshtml")]
    public class umbraco_PartialViewMacros_Templates_ListChildPagesWithDoctype : Umbraco.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 15 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
   var selection = Model.Content.Children<IPublishedContent>(VariationContextAccessor).Where(x => x.IsVisible(PublishedValueFallback)).ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
 if (selection.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 20 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
         foreach (var item in selection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 881, "\"", 919, 1);
#nullable restore
#line 22 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
WriteAttributeValue("", 888, item.Url(PublishedUrlProvider), 888, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 23 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 25 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListChildPagesWithDoctype.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedUrlProvider PublishedUrlProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedValueFallback PublishedValueFallback { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IVariationContextAccessor VariationContextAccessor { get; private set; }
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
