#pragma checksum "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7bdd75d4f330ef42f4fc18e92e28b12f6ca2184"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_View_Int_Job_Application_Number), @"mvc.1.0.view", @"/Views/Request/View_Int_Job_Application_Number.cshtml")]
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
#line 1 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\_ViewImports.cshtml"
using MoveOn_Relocation_Company_Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\_ViewImports.cshtml"
using MoveOn_Relocation_Company_Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bdd75d4f330ef42f4fc18e92e28b12f6ca2184", @"/Views/Request/View_Int_Job_Application_Number.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127b14cbc9b8625a1c1f2d272feb1d1829cf33e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_View_Int_Job_Application_Number : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoveOn_Relocation_Company_Mvc.Models.Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View_International_Requests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("moveon_back_button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
  
    ViewData["Title"] = "Job Application Number";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"moveon_singleview_container\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
   Write(Html.DisplayFor(model => model.JobApplicationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <div class=""moveon_singleview_split_cols"">
        <div class=""moveon_singleview_rows basic"" style=""border:none;"">
            <div class=""moveon_singleview_item"">
                <h3 class=""moveon_key"">Name:</h3>&nbsp;&nbsp;<h3 class=""moveon_value"">");
#nullable restore
#line 12 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div><br />\r\n            <div class=\"moveon_singleview_item\">\r\n                <h3 class=\"moveon_key\">Phone:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 15 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div><br />\r\n            <div class=\"moveon_singleview_item\">\r\n                <h3 class=\"moveon_key\">E-mail:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 18 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div><br />\r\n            <div class=\"moveon_singleview_item\">\r\n                <h3 class=\"moveon_key\">Item Category:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 21 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.ItemCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div><br />\r\n");
#nullable restore
#line 23 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
             if (@Model.ItemDescription != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">Item Description:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 26 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n");
#nullable restore
#line 28 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"moveon_singleview_item_caption\">\r\n                <h2 class=\"moveon_key\">Pickup Date:</h2>&nbsp;&nbsp;<h2 class=\"moveon_value\">");
#nullable restore
#line 30 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.PickupDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            </div><br />
        </div>
        <div class=""moveon_singleview_rows"" style=""border:none; margin:0;"">
            <div class=""moveon_singleview_rows"">
                <div class=""moveon_singleview_item_caption"">
                    <h2 class=""moveon_key"">Moving From</h2>
                </div><br />
                <div class=""moveon_singleview_item"">
                    <h3 class=""moveon_key"">Country:</h3>&nbsp;&nbsp;<h3 class=""moveon_value"">");
#nullable restore
#line 39 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.FromCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">State:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 42 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.FromState));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">City:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 45 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                     Write(Html.DisplayFor(model => model.FromCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">Address:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 48 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.FromAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div><br />
            </div>
            <div class=""moveon_singleview_rows"">
                <div class=""moveon_singleview_item_caption"">
                    <h2 class=""moveon_key"">Moving To</h2>
                </div><br />
                <div class=""moveon_singleview_item"">
                    <h3 class=""moveon_key"">Country:</h3>&nbsp;&nbsp;<h3 class=""moveon_value"">");
#nullable restore
#line 56 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.ToCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">State:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 59 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.ToState));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">City:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 62 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                     Write(Html.DisplayFor(model => model.ToCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n                <div class=\"moveon_singleview_item\">\r\n                    <h3 class=\"moveon_key\">Address:</h3>&nbsp;&nbsp;<h3 class=\"moveon_value\">");
#nullable restore
#line 65 "C:\Users\Merit\source\repos\MoveOn_Relocation_Company\MoveOn_Relocation_Company_Mvc\Views\Request\View_Int_Job_Application_Number.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.ToAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div><br />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bdd75d4f330ef42f4fc18e92e28b12f6ca218414172", async() => {
                WriteLiteral("<i class=\"fas fa-arrow-left\"></i>&nbsp;&nbsp;Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoveOn_Relocation_Company_Mvc.Models.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591
