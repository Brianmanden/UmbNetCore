#pragma checksum "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3617588a28cbff96f49e9e01cd106d01dcc872ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_ListDescendantsFromCurrentPage), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/ListDescendantsFromCurrentPage.cshtml")]
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
#line 1 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Core.Models.PublishedContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Web.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3617588a28cbff96f49e9e01cd106d01dcc872ee", @"/umbraco/PartialViewMacros/Templates/ListDescendantsFromCurrentPage.cshtml")]
    public class umbraco_PartialViewMacros_Templates_ListDescendantsFromCurrentPage : Umbraco.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 12 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
   var selection = Model.Content.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
 if (selection.Length > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                                                            
    var naviLevel = selection[0].Level;

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul");
            BeginWriteAttribute("class", " class=\"", 823, "\"", 849, 2);
            WriteAttributeValue("", 831, "level-", 831, 6, true);
#nullable restore
#line 21 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 837, naviLevel, 837, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 23 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
         foreach (var item in selection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 984, "\"", 1022, 1);
#nullable restore
#line 26 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 991, item.Url(PublishedUrlProvider), 991, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 29 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                  
                    var children = item.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray();
                    if (children.Length > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                                         
                        ChildPages(children);
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n");
#nullable restore
#line 38 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 40 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
  
    void ChildPages(IPublishedContent[] selection)
    {
        //Ensure that we have a collection of pages
        if (selection.Length > 0)
        {
            // Get the first page in pages and get the level
            var naviLevel = selection[0].Level;

            // Add in level for a CSS hook

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul");
            BeginWriteAttribute("class", " class=\"", 1891, "\"", 1917, 2);
            WriteAttributeValue("", 1899, "level-", 1899, 6, true);
#nullable restore
#line 52 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 1905, naviLevel, 1905, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 53 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                 foreach (var item in selection)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2042, "\"", 2080, 1);
#nullable restore
#line 56 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 2049, item.Url(PublishedUrlProvider), 2049, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 59 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                          
                            var children = item.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray();
                            if (children.Length > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                                                                    
                                ChildPages(children);
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </li>\r\n");
#nullable restore
#line 68 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 70 "d:\PROJEKTER\UmbNetCore\MyCustomUmbracoSolution\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
        }
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
