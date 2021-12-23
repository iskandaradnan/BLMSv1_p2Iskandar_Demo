#pragma checksum "D:\GITHUB\BLMS\Views\Authority\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4819831f2d9a9b5bc36230bf0104a667bb8a0661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authority_Index), @"mvc.1.0.view", @"/Views/Authority/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4819831f2d9a9b5bc36230bf0104a667bb8a0661", @"/Views/Authority/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935fafd0aa5610a1ac330bdda92ea4db0ded552", @"/Views/_ViewImports.cshtml")]
    public class Views_Authority_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BLMS.Models.SOP.Authority>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark tempting-azure-gradient btn-block text-white text-sm font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 12px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mdb/css/addons/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mdb/css/addons/datatables-select.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
  
    ViewData["Title"] = "Authority Link";
    Layout = "~/Views/Shared/_SOPLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid mt-5 mt-md-0 mb-0"">
    <!-- Grid row -->
    <div class=""row"" style=""margin-top: -100px;"">
        <!-- Grid column -->
        <div class=""col-md-12 px-lg-5"">
            <!-- Card -->
            <div class=""card pb-5 mx-md-3"">
                <div class=""card-body"">
                    <div class=""container text-center my-5"">
                        <h2 class=""title font-weight-bold my-3 wow fadeIn"" data-wow-delay=""0.2s"">
                            <strong>AUTHORITY LINK</strong>
                        </h2>

                        <p class=""grey-text w-responsive mx-auto mb-3 wow fadeIn"" data-wow-delay=""0.2s"">
                            In this gridview, user can track Authority Link recorded in BLMS system.
                        </p>

                        <div class=""row wow fadeIn"" data-wow-delay=""0.2s"" style=""font-size: 12px;"">
                            <div class=""col-12"">
                                <div class=""card"">
                 ");
            WriteLiteral("                   <div class=\"card-body\">\r\n                                        <div id=\"alert\" class=\"form-group text-left\" style=\"font-size: 14px;\">\r\n                                            ");
#nullable restore
#line 30 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                       Write(Html.Raw(@ViewBag.Alert));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>

                                        <table id=""AuthorityLink"" class=""table table-hover table-wrapper table-striped table-responsive-lg text-left"" cellspacing=""0"" width=""100%"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-sm font-weight-bold col-1"" style=""font-size: 12px;"">No.</th>
                                                    <th class=""text-sm font-weight-bold col-3"" style=""font-size: 12px;"">
                                                        ");
#nullable restore
#line 38 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.AuthorityName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </th>\r\n                                                    <th class=\"text-sm font-weight-bold\" style=\"font-size: 12px;\">\r\n                                                        ");
#nullable restore
#line 41 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.AuthorityLink));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </th>
                                                    <th class=""text-sm font-weight-bold text-center col-2"" style=""font-size: 12px;"">Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 47 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                   int i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr");
            BeginWriteAttribute("id", " id=\"", 2996, "\"", 3022, 2);
            WriteAttributeValue("", 3001, "row_", 3001, 4, true);
#nullable restore
#line 50 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
WriteAttributeValue("", 3005, item.AuthorityID, 3005, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <td class=\"text-sm text-center\" style=\"font-size: 12px;\">\r\n                                                            ");
#nullable restore
#line 52 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td class=\"text-sm\" style=\"font-size: 12px;\">\r\n                                                            ");
#nullable restore
#line 55 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.AuthorityName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </td>
                                                        <td class=""text-sm font-weight-bold text-break"" style=""font-size: 12px;"">
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3738, "\"", 3764, 1);
#nullable restore
#line 58 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
WriteAttributeValue("", 3745, item.AuthorityLink, 3745, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blanK\">");
#nullable restore
#line 58 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                                                                     Write(Html.DisplayFor(modelItem => item.AuthorityLink));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                        </td>
                                                        <td class=""text-center"" style=""font-size: 12px;"">
                                                            <a class=""btn btn-outline-dark winter-neva-gradient btn-rounded btn-sm px-2"" title=""Edit""");
            BeginWriteAttribute("href", " href=\"", 4156, "\"", 4222, 1);
#nullable restore
#line 61 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
WriteAttributeValue("", 4163, Url.Action("Edit", "Authority", new {id=item.AuthorityID}), 4163, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 12px;"">
                                                                <i class=""fas fa-pencil-alt mt-0""></i>
                                                            </a>
                                                            <a class=""btn btn-outline-dark young-passion-gradient btn-rounded btn-sm px-2"" title=""Delete"" href=""#""");
            BeginWriteAttribute("onclick", " onclick=\"", 4583, "\"", 4625, 3);
            WriteAttributeValue("", 4593, "ConfirmDelete(", 4593, 14, true);
#nullable restore
#line 64 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
WriteAttributeValue("", 4607, item.AuthorityID, 4607, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4624, ")", 4624, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: 12px;"">
                                                                <i class=""fas fa-trash-alt mt-0""></i>
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 69 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                                    i++;
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>

                                        <!--Delete bootstrap confirmation box-->
                                        <div class=""modal fade top"" id=""delete-conformation"" aria-labelledby=""delete-conformation"" aria-hidden=""true"" tabindex=""-1"" role=""dialog"">
                                            <div class=""modal-dialog modal-frame modal-top modal-notify modal-danger"">
                                                <div class=""modal-content"">
                                                    <div class=""modal-header flex-column"">
                                                        <div class=""icon-box"">
                                                            <i class=""material-icons"">&#xE5CD;</i>
                                                        </div>
                                                        <h4 class=""modal-title w-100 font-weight-bolder text-center text-wh");
            WriteLiteral(@"ite"">DELETE AUTHORITY LINK?</h4>
                                                        <br />
                                                        <p class=""mb-1 align-self-sm-center text-white"" style=""color: red;""><i class=""fas fa-exclamation-circle""></i> The saved data will be permanently deleted from BLMS database.</p>
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                                    </div>
                                                    <div class=""modal-footer justify-content-center"">
                                                        <button type=""button"" class=""btn btn-outline-dark winter-neva-gradient waves-effect"" data-dismiss=""modal"">Cancel</button>
                                                        <a href=""#"" class=""btn btn-outline-dark young-passion-gradient waves-effect"" onclick=""DeleteAuthority()"">Delete</a>
                           ");
            WriteLiteral(@"                         </div>
                                                </div>
                                            </div>
                                        </div>

                                        <input type=""hidden"" id=""hidAuthorityId"" />

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4819831f2d9a9b5bc36230bf0104a667bb8a066116335", async() => {
                WriteLiteral("Create Authority Link");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.11.2/css/all.css\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4819831f2d9a9b5bc36230bf0104a667bb8a066118130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4819831f2d9a9b5bc36230bf0104a667bb8a066119309", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <style>\r\n        .select-wrapper input.select-dropdown {\r\n            font-size: 12px;\r\n        }\r\n\r\n        .dropdown-content li > span {\r\n            font-size: 12px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        new WOW().init();

        var ConfirmDelete = function (AuthorityId) {

            $(""#hidAuthorityId"").val(AuthorityId);
            $(""#delete-conformation"").modal('show');
        }

        var DeleteAuthority = function () {
            var AuthorityId = $(""#hidAuthorityId"").val();

            $.ajax({
                type: ""POST"",
                url: '");
#nullable restore
#line 141 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                 Write(Url.Action("Delete", "Authority"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                dataType: ""json"",
                data: { Id: AuthorityId },
                success: function (result) {
                    $(""#delete-conformation"").modal(""hide"");
                    $(""#row_"" + AuthorityId).remove();
                    window.location.href =  '");
#nullable restore
#line 147 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
                                        Write(Url.Action("Index", "Authority"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                }
            })
        }

        $(document).ready(function () {
            $('#AuthorityLink').DataTable();
            $('#AuthorityLink_wrapper').find('label').each(function () {
                $(this).parent().append($(this).children());
            });
            $('#AuthorityLink_wrapper .dataTables_filter').find('input').each(function () {
                $('input').attr(""placeholder"", ""Search"");
                $('input').attr(""style"", 'font-size: 12px');
                $('input').removeClass('form-control-sm');
            });
            $('#AuthorityLink_wrapper .dataTables_length').addClass('d-flex flex-row');
            $('#AuthorityLink_wrapper .dataTables_filter').addClass('md-form');
            $('#AuthorityLink_wrapper select').removeClass(
                'custom-select custom-select-sm form-control form-control-sm');
            $('#AuthorityLink_wrapper select').addClass('mdb-select');
            $('#AuthorityLink_wrapper .mdb-select').materi");
                WriteLiteral(@"alSelect();
            $('#AuthorityLink_wrapper .dataTables_filter').find('label').remove();
        });

        //auto hide viewbag.alert
        $(document).ready(function () {
            setTimeout(function () {
                $(""#alert"").fadeOut();
            }, 3000);
        });
    </script>

");
#nullable restore
#line 179 "D:\GITHUB\BLMS\Views\Authority\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BLMS.Models.SOP.Authority>> Html { get; private set; }
    }
}
#pragma warning restore 1591
