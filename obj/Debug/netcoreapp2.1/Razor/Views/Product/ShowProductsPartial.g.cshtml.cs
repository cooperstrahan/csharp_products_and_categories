#pragma checksum "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/Product/ShowProductsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de05766aed7cbdda63e7457f3399862012aac1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProductsPartial), @"mvc.1.0.view", @"/Views/Product/ShowProductsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ShowProductsPartial.cshtml", typeof(AspNetCore.Views_Product_ShowProductsPartial))]
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
#line 1 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories;

#line default
#line hidden
#line 2 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de05766aed7cbdda63e7457f3399862012aac1b", @"/Views/Product/ShowProductsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3772dd1aab0a113eef9daa4fd8f7fdb8a407ef7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProductsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MasterProduct>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1413bacf5a3b4edc9772ae7c14abc579", async() => {
                BeginContext(39, 161, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n");
                EndContext();
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
            EndContext();
            BeginContext(207, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(208, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f36ec493a3a34a4290046c32e467c962", async() => {
                BeginContext(214, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(240, 30, true);
                WriteLiteral("    <h3>Existing Product</h3>\n");
                EndContext();
#line 11 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/Product/ShowProductsPartial.cshtml"
     foreach (var product in @Model.Products)
    {

#line default
#line hidden
                BeginContext(322, 12, true);
                WriteLiteral("       <p><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 334, "\"", 369, 2);
                WriteAttributeValue("", 341, "/products/", 341, 10, true);
#line 13 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/Product/ShowProductsPartial.cshtml"
WriteAttributeValue("", 351, product.ProductId, 351, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(370, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(372, 19, false);
#line 13 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/Product/ShowProductsPartial.cshtml"
                                            Write(product.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(391, 9, true);
                WriteLiteral("</a></p>\n");
                EndContext();
#line 14 "/Users/cooperstrahan/Documents/Coding_Dojo/orm/ProductsAndCategories/Views/Product/ShowProductsPartial.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(413, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MasterProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591