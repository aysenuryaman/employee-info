#pragma checksum "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Partials\EmployeeUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7580122a5dd1e456e0cd4cba5ca41337cb819f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials_EmployeeUpdate), @"mvc.1.0.view", @"/Views/Shared/Partials/EmployeeUpdate.cshtml")]
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
#line 1 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\_ViewImports.cshtml"
using Kipas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\_ViewImports.cshtml"
using Kipas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7580122a5dd1e456e0cd4cba5ca41337cb819f3", @"/Views/Shared/Partials/EmployeeUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8a97133eef3ad4640a029fed10dd00354e1409", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Partials_EmployeeUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kipas.Models.Employee>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal"" id=""modal-Guncelle"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h4 class=""modal_title"">Employee Info</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7580122a5dd1e456e0cd4cba5ca41337cb819f35336", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""Id"" id=""G_Id"" class=""form-control"" />
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group "">
                                <label> First Name:</label>
                                <input type=""text"" name=""FirstName"" id=""G_FirstName"" class=""form-control"" required/>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group "">
                                <label> Last Name:</label>
                                <input type=""text"" name=""LastName"" id=""G_LastName"" class=""form-control"" required/>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group "">
                                <label>");
                WriteLiteral(@"   Title:</label>

                                <input type=""text"" name=""Title"" id=""G_Title"" class=""form-control"" required/>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group "">
                                Birth Date:
                                <input type=""date"" name=""BirthDate"" id=""G_BirthDate"" class=""form-control"" min=""1950-01-01"" max=""2007-01-01"" required  />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group "">
                                Position:
                                <input type=""text"" name=""Position"" id=""G_Position"" class=""form-control"" required/>
                            </div>
                        </div>
                        <div class=""col-6"">
                   ");
                WriteLiteral(@"         <div class=""form-group "">
                                Hire Date:
                                <input type=""date"" name=""HireDate"" id=""G_HireDate"" class=""form-control"" required/>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group "">
                        Notes:
                        <textarea name=""Notes"" id=""G_Notes"" class=""form-control"" required></textarea>
                    </div>

                    <h4>Home Address</h4>
                    <hr />
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group "">
                                State:
                                ");
#nullable restore
#line 73 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Partials\EmployeeUpdate.cshtml"
                           Write(Html.DropDownListFor(a => a.StateId, (List<SelectListItem>)ViewBag.state, new { @class = "form-control", @id = "G_StateId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group "">
                                Address:
                                <input type=""text"" name=""Address"" id=""G_Address"" class=""form-control"" required/>
                            </div>
                        </div>
                    </div>




                    <div class=""d-flex justify-content-end"">

                        <button type=""submit"" class=""btn btn-info  mr-2"">Save</button>
                        <button type=""button"" class=""btn btn-light"" data-dismiss=""modal"">Cancel</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kipas.Models.Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
