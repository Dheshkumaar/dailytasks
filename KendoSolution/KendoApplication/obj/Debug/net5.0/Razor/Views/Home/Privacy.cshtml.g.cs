#pragma checksum "C:\Users\DHESH KUMAAR A\Desktop\Task\KendoSolution\KendoApplication\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e3b677a492502e10ec93952fc7d30c397119479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\DHESH KUMAAR A\Desktop\Task\KendoSolution\KendoApplication\Views\_ViewImports.cshtml"
using KendoApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DHESH KUMAAR A\Desktop\Task\KendoSolution\KendoApplication\Views\_ViewImports.cshtml"
using KendoApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e3b677a492502e10ec93952fc7d30c397119479", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f169101445e52b4f700c5215c38529c1fbe8d41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DHESH KUMAAR A\Desktop\Task\KendoSolution\KendoApplication\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Task 1</h2>

<div class=""form-group row"">
    <label for=""date"" class=""col-sm-2 col-form-label"">Select Date</label>
    <div class=""col-sm-10"">
        <input class=""form-control-plaintext"" id=""date"" />
    </div>
</div>

<h2>Task 2</h2>

<div class=""form-group row"">
    <label for=""StartDate"" class=""col-sm-2 col-form-label"">Start Date</label>
    <div class=""col-sm-10"">
        <input class=""form-control-plaintext"" id=""startdate"" onchange=""onstart()""/>
    </div>
</div>

<div class=""form-group row"">
    <label for=""EndDate"" class=""col-sm-2 col-form-label"">End Date</label>
    <div class=""col-sm-10"">
        <input class=""form-control-plaintext"" id=""enddate"" disabled/>
    </div>
</div>

<script>
    $(document).ready(function () {
        var Todaydate = new Date();
        var firstDay = new Date(Todaydate.getFullYear(), Todaydate.getMonth(), 1);
        var lastDay = new Date(Todaydate.getFullYear(), Todaydate.getMonth() + 1, 0);
        $(""#date"").kendoDatePicker({
     ");
            WriteLiteral(@"       min: firstDay,
            value: Todaydate,
            max: lastDay,
        });

        $(""#startdate"").kendoDatePicker({
            value: Todaydate,
        });

        var newDate = kendo.date.addDays(new Date($(""#startdate"").val()), 7);
        $(""#enddate"").kendoDatePicker({
            value: newDate
        });
    });
    function onstart() {
        var newDate = kendo.date.addDays(new Date($(""#startdate"").val()), 7);
        var enddate = $(""#enddate"").data(""kendoDatePicker"");
        enddate.value(newDate);
    }
</script>
");
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