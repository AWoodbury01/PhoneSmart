#pragma checksum "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7124be303698f65eac9d2190cba44b6f5ff6ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phones_Details), @"mvc.1.0.view", @"/Views/Phones/Details.cshtml")]
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
#line 1 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\_ViewImports.cshtml"
using PhoneSmart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\_ViewImports.cshtml"
using PhoneSmart.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7124be303698f65eac9d2190cba44b6f5ff6ec8", @"/Views/Phones/Details.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8f365159892da2c58638197ba619c1fc8a5420", @"/Views/Phones/Details.cshtml")]
>>>>>>> master
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2bfe824138f8cf29853ab80e7b0f9010cc0eb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Phones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneSmart.Models.Phone>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
<<<<<<< HEAD
   ViewData["Title"] = "Details"; 
=======
  
    ViewData["Title"] = "Details";
>>>>>>> master

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Phone</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneModel.Manufacturer));
=======
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Phone</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));
>>>>>>> master

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneModel.Manufacturer));
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));
>>>>>>> master

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneModel.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneModel.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayNameFor(model => model.Storage));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayFor(model => model.Storage));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayNameFor(model => model.Condition));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayFor(model => model.Condition));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayNameFor(model => model.PhoneModelId));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
       Write(Html.DisplayFor(model => model.PhoneModelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7124be303698f65eac9d2190cba44b6f5ff6ec87906", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8f365159892da2c58638197ba619c1fc8a54207241", async() => {
>>>>>>> master
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 51 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
=======
#line 46 "C:\Users\Newforce\workspace\PhoneSmart\PhoneSmart\Views\Phones\Details.cshtml"
>>>>>>> master
                           WriteLiteral(Model.PhoneId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7124be303698f65eac9d2190cba44b6f5ff6ec810051", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8f365159892da2c58638197ba619c1fc8a54209386", async() => {
>>>>>>> master
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneSmart.Models.Phone> Html { get; private set; }
    }
}
#pragma warning restore 1591
