#pragma checksum "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb44093cdb4b5e6706275e23c298b896ca542cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Operation_Views_Flight_Index), @"mvc.1.0.view", @"/Areas/Operation/Views/Flight/Index.cshtml")]
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
#line 1 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\_ViewImports.cshtml"
using Jdair;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\_ViewImports.cshtml"
using Jdair.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb44093cdb4b5e6706275e23c298b896ca542cb2", @"/Areas/Operation/Views/Flight/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879da76b0f06ed42401ad1add48d4558401730a3", @"/Areas/Operation/Views/_ViewImports.cshtml")]
    public class Areas_Operation_Views_Flight_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Flight>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""wrapper"">
    <div class=""main-content"">
        <br /><br />

        <div class=""row"">
            <div class=""col-6"">
                <h2 class=""text-info""> Flights List</h2>
            </div>
            <br />
            <div class=""col-6 text-right"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb44093cdb4b5e6706275e23c298b896ca542cb24030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"row row-inline-block small-spacing\">\r\n            <div class=\"col-lg-6 col-xs-12\">\r\n                <div class=\"box-content\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml"
                     if (Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 36 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <th scope=""row"">1</th>
                                       
                                        <td>EDIT | DElETE | DETAILS</td>
                                    </tr>
");
#nullable restore
#line 43 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <tr>
                                    <th scope=""row"">1</th>
                                    <td>Mark</td>
                                    <td>Otto</td>
                                    <td>mdo</td>
                                </tr>
                                <tr>
                                    <th scope=""row"">2</th>
                                    <td>Jacob</td>
                                    <td>Thornton</td>
                                    <td>fat</td>
                                </tr>
                                <tr>
                                    <th scope=""row"">3</th>
                                    <td>Larry</td>
                                    <td>the Bird</td>
                                    <td>twitter</td>
                                </tr>
                            </tbody>
                        </table>
");
#nullable restore
#line 65 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>No Categories Exist</p>\r\n");
#nullable restore
#line 69 "C:\Users\jcompany\Desktop\Dev\Jdair\Jdair\Areas\Operation\Views\Flight\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!-- /.box-content -->
                <!--</div>-->
                <!-- /.col-lg-6 col-xs-12 -->
                <!--</div>-->
                <!-- /.row row-inline-block small-spacing -->
                <!--<footer class=""footer"">
                    <ul class=""list-inline"">
                        <li>2016 © NinjaAdmin.</li>
                        <li><a href=""#"">Privacy</a></li>
                        <li><a href=""#"">Terms</a></li>
                        <li><a href=""#"">Help</a></li>
                    </ul>
                </footer>-->
            </div>

        </div>
    </div>
</div>

<!--<script src=""assets/scripts/jquery.min.js""></script>
<script src=""assets/scripts/modernizr.min.js""></script>
<script src=""assets/plugin/bootstrap/js/bootstrap.min.js""></script>
<script src=""assets/plugin/mCustomScrollbar/jquery.mCustomScrollbar.concat.min.js""></script>
<script src=""assets/plugin/nprogress/nprogress.js""></script>
<script src=""asset");
            WriteLiteral(@"s/plugin/sweet-alert/sweetalert.min.js""></script>
<script src=""assets/plugin/waves/waves.min.js""></script>-->
<!-- Full Screen Plugin -->
<!--<script src=""assets/plugin/fullscreen/jquery.fullscreen-min.js""></script>

<script src=""assets/scripts/main.min.js""></script>
<script src=""assets/color-switcher/color-switcher.min.js""></script>-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Flight>> Html { get; private set; }
    }
}
#pragma warning restore 1591