#pragma checksum "C:\Users\14235\Desktop\Projects\HisandHers\Views\ActiveCustomer\MakeAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37552d8ec245487d24d741203596c4aed6280a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActiveCustomer_MakeAppointment), @"mvc.1.0.view", @"/Views/ActiveCustomer/MakeAppointment.cshtml")]
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
#line 1 "C:\Users\14235\Desktop\Projects\HisandHers\Views\_ViewImports.cshtml"
using HisandHers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\14235\Desktop\Projects\HisandHers\Views\_ViewImports.cshtml"
using HisandHers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37552d8ec245487d24d741203596c4aed6280a3b", @"/Views/ActiveCustomer/MakeAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6770b972179e4f09f0c116d78b131b83591c876f", @"/Views/_ViewImports.cshtml")]
    public class Views_ActiveCustomer_MakeAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\14235\Desktop\Projects\HisandHers\Views\ActiveCustomer\MakeAppointment.cshtml"
  
    ViewData["Title"] = "Make Appointment Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37552d8ec245487d24d741203596c4aed6280a3b3884", async() => {
                WriteLiteral(@"
        <div class=""input"">
            <div style=""margin: auto; color: rgba(0,0,0,0.6);"">
                <h3 style=""text-align:center"">Request Appointment</h3>
                <p>Want to restart our services? </p> 
                <p>Fill out some basic information and submit your request. If you have not recieved 
                    an estimate for a property, we can not create your appointment. Please see the estimate page. 
                    Our team works hard to provide exceptional services to our customers. We will notify you when 
                    your request has been processed by email. If there are any problems with the date and time 
                    scheduled we will give you a call. Otherwise we will send an email with instructions and
                    begin services based on the information in the request. </p>
            </div> 
        </div>
        <!-- Name -->
        <div class=""input""> 
            <input class=""input"" type=""text"" id=""fname"" name=""firstnam");
                WriteLiteral(@"e"" placeholder=""First Name"">
                
            <input class=""input"" type=""text"" id=""lname"" name=""lastname"" placeholder=""Last Name"">
        </div>
        <!-- Contact -->
        <div class=""input""> 
            <input class=""input"" type=""text"" id=""phone"" name=""phone"" placeholder=""Phone Number"">

            <input class=""input"" type=""text"" id=""email"" name=""email"" placeholder=""Email"">
        </div>

        <div class=""input"" style=""justify-content: flex-start""> 
            <p>Select Property:</p>
        </div>
        <!-- Address -->
        <div class=""input""> 
                    
            <!-- dropdown -->
            <select id=""property"" placeholder=""Property"" style=""width: 100%"">
                        
            </select>
        </div>

        <!-- Cleaning Type/ frequency -->
        <div class=""input"" style=""justify-content: flex-start""> 
            <p>Select Frequency and Type of Service:</p>
        </div>
        <div class=""input""> 
          ");
                WriteLiteral(@"  <!-- dropdown -->

            <select id=""frequency"" placeholder=""Frequency"">
                        
            </select>
            <!-- dropdown -->
            <select id=""type"" placeholder=""Type"">
                        
            </select>
        </div>
                
        <!-- Date/Time -->
        <div class=""input"" style=""justify-content: flex-start""> 
            <p>Select Date and Time:</p>
        </div>
        <div class=""input"">

            <input type=""date"" id=""date"" name=""date"" class=""input"">

            <select id=""time"" placeholder=""Time"">
                        
            </select>
        </div>
        <!-- Special Requests -->
        <div class=""input"">
            <textarea type=""text"" id=""requests"" name=""requests"" placeholder=""Special Requests"" style=""height:100px""></textarea>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <!-- Submit Button -->\r\n    <div class=\"input\">\r\n        <input type=\"submit\" value=\"Submit\">\r\n    </div>\r\n    <br>\r\n</div>");
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
