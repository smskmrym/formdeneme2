#pragma checksum "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\ders\tesekkur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65094250c65b765b5b2a8c8b3e90db93fde98a20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ders_tesekkur), @"mvc.1.0.view", @"/Views/ders/tesekkur.cshtml")]
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
#line 1 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\_ViewImports.cshtml"
using formdeneme2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\_ViewImports.cshtml"
using formdeneme2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65094250c65b765b5b2a8c8b3e90db93fde98a20", @"/Views/ders/tesekkur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0ffa6985f6bb012001f38addfdb3cbf3e7b0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_ders_tesekkur : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "liste", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\ders\tesekkur.cshtml"
   ViewData["Title"] = "tesekkur"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Teşekkürler</h1>\n<div class=\"container m-4\">\n    <div class=\"card mx-auto\" style=\"width:500px;\">\n        <div class=\"card-header\">\n            Merhaba, ");
#nullable restore
#line 9 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\ders\tesekkur.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"card-body\">\n");
#nullable restore
#line 12 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\ders\tesekkur.cshtml"
             if (Model.Confirm == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Kursa katılmış olduğunuzdan dolayı mutlu olduk.</span>\n                <div>\n                    Diğer katılımcıları ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65094250c65b765b5b2a8c8b3e90db93fde98a204512", async() => {
                WriteLiteral(" görüntüle.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div> ");
#nullable restore
#line 17 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\ders\tesekkur.cshtml"
                       }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Üzüldük. Umarım fikriniz değişir.</span>");
#nullable restore
#line 20 "C:\Users\meri\Documents\project\formdeneme2\formdeneme2\formdeneme2\Views\ders\tesekkur.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
