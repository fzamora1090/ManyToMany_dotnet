#pragma checksum "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/Categories/AllCategoriesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14abf0cb4ceefdab736f1ee68e570e595c2ac5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_AllCategoriesPartial), @"mvc.1.0.view", @"/Views/Categories/AllCategoriesPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/AllCategoriesPartial.cshtml", typeof(AspNetCore.Views_Categories_AllCategoriesPartial))]
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
#line 1 "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories;

#line default
#line hidden
#line 2 "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14abf0cb4ceefdab736f1ee68e570e595c2ac5ab", @"/Views/Categories/AllCategoriesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3772dd1aab0a113eef9daa4fd8f7fdb8a407ef7", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_AllCategoriesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 122, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"\">\n        <h1>Existing Category</h1>\n        <ul style=\"list-style-type:None;\">\n");
            EndContext();
#line 7 "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/Categories/AllCategoriesPartial.cshtml"
             foreach (Category currentCategory in Model.allCategories)
            {

#line default
#line hidden
            BeginContext(224, 21, true);
            WriteLiteral("                <li> ");
            EndContext();
            BeginContext(245, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14abf0cb4ceefdab736f1ee68e570e595c2ac5ab4448", async() => {
                BeginContext(335, 20, false);
#line 9 "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/Categories/AllCategoriesPartial.cshtml"
                                                                                                         Write(currentCategory.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/Categories/AllCategoriesPartial.cshtml"
AddHtmlAttributeValue("", 305, currentCategory.CategoryId, 305, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(359, 7, true);
            WriteLiteral(" </li>\n");
            EndContext();
#line 10 "/Users/franciscozamora/Documents/Dojo2019/dotNET/ASP/ProductsAndCategories/Views/Categories/AllCategoriesPartial.cshtml"
                    
            }

#line default
#line hidden
            BeginContext(401, 31, true);
            WriteLiteral("        </ul>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
