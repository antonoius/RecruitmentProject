#pragma checksum "G:\Projects\RecruitmentProject\RecruitmentApp\Views\RecruiterOperations\ViewApplication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cefacd6b5193411ca382892c0fead3f5a824935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RecruiterOperations_ViewApplication), @"mvc.1.0.view", @"/Views/RecruiterOperations/ViewApplication.cshtml")]
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
#line 1 "G:\Projects\RecruitmentProject\RecruitmentApp\Views\_ViewImports.cshtml"
using RecruitmentApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cefacd6b5193411ca382892c0fead3f5a824935", @"/Views/RecruiterOperations/ViewApplication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473065ba4b7e17a6d4143c83e2c780ab865a3a33", @"/Views/_ViewImports.cshtml")]
    public class Views_RecruiterOperations_ViewApplication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cefacd6b5193411ca382892c0fead3f5a8249353822", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>AdminLTE 3 | General Form Elements</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""../../plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""../../dist/css/adminlte.min.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cefacd6b5193411ca382892c0fead3f5a8249354874", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n\r\n        $(document).ready(function () {\r\n            var candId = \'");
#nullable restore
#line 23 "G:\Projects\RecruitmentProject\RecruitmentApp\Views\RecruiterOperations\ViewApplication.cshtml"
                     Write(ViewBag.candId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            var appId=0

            $.ajax({
            url: '/RecruiterOperations/getApplicationData?candId=' + candId,
                success: function (result) {
                    $.each($(result), function (i, elem) {
                        appId = elem.appId;
                        $('#Posistion').val(elem.jobPos);
                        $('#Describtion').val(elem.jobDesc);
                        $('#DepartmentName').val(elem.jobDepart);
                        $('#phaseName').val(elem.phaseName);

                    })
                }
            })
            
            $(""#addPhase"").click(function () {
                
                var phaseTask = $('#phaseTask').val();
                var PhaseComment = $('#PhaseComment').val();
                var phaseId = $('#phases').find("":checked"").attr(""id"");
                
                $.ajax({
                    url: '/RecruiterOperations/addPhase?appId=' + appId + '&phaseId=' + phaseId + '&PhaseComment=' + ");
                WriteLiteral(@"PhaseComment + '&phaseTask=' + phaseTask,
                    success: function (result) {
                        alert(result);
                    }
                })
                
            })
            $(""#loadPhases"").click(function () {
                $.ajax({
                    url: '/RecruiterOperations/getPhasesForApp?appId=' + appId,
                    success: function (result) {
                        $(""tbody"").empty();
                        $.each($(result), function (i, elem) {
                            $(""tbody"").append('<tr><td>' + elem.phaseName + '</td><td>' + elem.phaseTask + ' </td> <td>' + elem.phaseComm + '</td> </tr>');
                        })
                    }
                })
            })
        })
        function getalldata() {
            var searchWord = $('#SearchWord').val();

        }


    </script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cefacd6b5193411ca382892c0fead3f5a8249359026", async() => {
                WriteLiteral(@"
    <br/><br />
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Application Data</h3>
                </div>

                <div class=""card-body"">
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Posistion</label>
                        <input type=""text"" class=""form-control"" id=""Posistion"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Describtion</label>
                        <input type=""text"" class=""form-control"" id=""Describtion"" placeholder=""Password"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">DepartmentName</label>
                        <input type=""text"" class=""form-control"" id=""DepartmentName"" placeholder");
                WriteLiteral(@"=""Password"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Current Phase</label>
                        <input type=""text"" class=""form-control"" id=""phaseName"" placeholder=""Password"">
                    </div>


                </div>



            </div>
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Phases</h3>
                </div>
                <div class=""card-footer"">
                    <button id=""loadPhases"" type=""submit"" class=""btn btn-primary"">Load Phase</button>
                </div>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Phase Name</th>
                            <th>Phase Task</th>
                            <th>Phase Comment</th>

                        </tr>
                    </thead>
                   ");
                WriteLiteral(@" <tbody>


                    </tbody>
                </table>
            </div>
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Add Phases</h3>
                </div>

                <div class=""card-body"">
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Phase Task</label>
                        <input type=""text"" class=""form-control"" id=""phaseTask"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Phase Comment</label>
                        <input type=""text"" class=""form-control"" id=""PhaseComment"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Phase Name </label>
                        <select name=""Phases"" id=""phases"" class=""form-control"">
");
#nullable restore
#line 146 "G:\Projects\RecruitmentProject\RecruitmentApp\Views\RecruiterOperations\ViewApplication.cshtml"
                             foreach (var phase in ViewBag.phases)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cefacd6b5193411ca382892c0fead3f5a82493512833", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 148 "G:\Projects\RecruitmentProject\RecruitmentApp\Views\RecruiterOperations\ViewApplication.cshtml"
                                                 Write(phase.Name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 148 "G:\Projects\RecruitmentProject\RecruitmentApp\Views\RecruiterOperations\ViewApplication.cshtml"
AddHtmlAttributeValue("", 6084, phase.Id, 6084, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 149 "G:\Projects\RecruitmentProject\RecruitmentApp\Views\RecruiterOperations\ViewApplication.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                        </select>
                    </div>
                    <div class=""card-footer"">
                        <button id=""addPhase"" type=""submit"" class=""btn btn-primary"">Add Phase</button>
                    </div>
                </div>
            </div>
        </div>
    </section>


        <script src=""../../plugins/jquery/jquery.min.js""></script>
        <!-- Bootstrap 4 -->
        <script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
        <!-- bs-custom-file-input -->
        <script src=""../../plugins/bs-custom-file-input/bs-custom-file-input.min.js""></script>
        <!-- AdminLTE App -->
        <script src=""../../dist/js/adminlte.min.js""></script>
        <!-- AdminLTE for demo purposes -->
        <script src=""../../dist/js/demo.js""></script>
");
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
            WriteLiteral("\r\n</html>");
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
