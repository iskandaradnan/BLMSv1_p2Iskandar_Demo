#pragma checksum "D:\GITHUB\BLMS\Views\Error\NoPermission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce4c63068d467e7d523870f4e85cfc8dc41bdd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_NoPermission), @"mvc.1.0.view", @"/Views/Error/NoPermission.cshtml")]
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
#line 1 "D:\GITHUB\BLMS\Views\_ViewImports.cshtml"
using BLMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GITHUB\BLMS\Views\_ViewImports.cshtml"
using BLMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce4c63068d467e7d523870f4e85cfc8dc41bdd60", @"/Views/Error/NoPermission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935fafd0aa5610a1ac330bdda92ea4db0ded552", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_NoPermission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GITHUB\BLMS\Views\Error\NoPermission.cshtml"
  
    ViewData["Title"] = "NoPermission";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
    </section>
    <section class=""content"">
        <div class=""card"">
            <div class=""card-header text-white bg-danger"">
                <h3 class=""card-title font-weight-bold""><i class=""fas fa-times-circle""></i> ERROR 401 - UNAUTHORIZED ACCESS </h3>
            </div>
            <div class=""card-body"">
                <div class=""col-md-12"">
                </div>
            </div>
        </div>
    </section>
</div>");
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
