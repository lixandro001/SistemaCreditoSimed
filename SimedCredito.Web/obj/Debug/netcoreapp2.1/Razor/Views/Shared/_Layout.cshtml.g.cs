#pragma checksum "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59d709c66fc15bd0a159cb8c758a53b0147788ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 7 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
using Simed.Entity;

#line default
#line hidden
#line 9 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59d709c66fc15bd0a159cb8c758a53b0147788ed", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
  

    var profileId = HttpContextAccessor.HttpContext.Session.GetInt32("PROFILE_ID");
 

#line default
#line hidden
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(234, 1325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4017419e15648d79e7f582f9792d5f7", async() => {
                BeginContext(240, 108, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>SIMED | ");
                EndContext();
                BeginContext(349, 13, false);
#line 17 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
              Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(362, 202, true);
                WriteLiteral(" </title>\r\n    <!-- Tell the browser to be responsive to screen width -->\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <!-- Font Awesome -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 564, "\"", 629, 1);
#line 21 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 571, Url.Content("~/plugins/fontawesome-free/css/all.min.css"), 571, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(630, 181, true);
                WriteLiteral(">\r\n    <!-- Ionicons -->\r\n    <link rel=\"stylesheet\" href=\"https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css\">\r\n    <!-- DataTables -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 811, "\"", 888, 1);
#line 25 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 818, Url.Content("~/plugins/datatables-bs4/css/dataTables.bootstrap4.css"), 818, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(889, 59, true);
                WriteLiteral(">\r\n\r\n\r\n    <!-- Theme style -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 948, "\"", 1002, 1);
#line 29 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 955, Url.Content("~/adminlte/css/adminlte.min.css"), 955, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1003, 29, true);
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1032, "\"", 1102, 1);
#line 30 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1039, Url.Content("~/plugins/jquery-loading/jquery.loading.min.css"), 1039, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1103, 33, true);
                WriteLiteral(" />\r\n\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1136, "\"", 1199, 1);
#line 32 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1143, Url.Content("~/plugins/sweetalert/dist/sweetalert.css"), 1143, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1200, 29, true);
                WriteLiteral(">\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1229, "\"", 1289, 1);
#line 33 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1236, Url.Content("~/plugins/select2/css/select2.min.css"), 1236, 53, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1290, 31, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1321, "\"", 1359, 1);
#line 34 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1328, Url.Content("~/css/style.css"), 1328, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1360, 159, true);
                WriteLiteral(">\r\n    <!-- Google Font: Source Sans Pro -->\r\n    <link href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700\" rel=\"stylesheet\">\r\n    ");
                EndContext();
                BeginContext(1520, 30, false);
#line 37 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("styles", false));

#line default
#line hidden
                EndContext();
                BeginContext(1550, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1559, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1561, 5850, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9670def546534a03990dfb7342e22da5", async() => {
                BeginContext(1604, 740, true);
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#""><i class=""fas fa-bars""></i></a>
                </li>
            </ul>

            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"">
                        Bienvenido(a) :   <strong id=""nombreUsuarioLayout""></strong>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2344, "\"", 2380, 1);
#line 57 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2351, Url.Action("Index", "Login"), 2351, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2381, 312, true);
                WriteLiteral(@">
                        Cerrar Sesión
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
            <!-- Brand Logo -->
            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2693, "\"", 2728, 1);
#line 67 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2700, Url.Action("Index", "Main"), 2700, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2729, 615, true);
                WriteLiteral(@" class=""brand-link"">
                
                <span class=""brand-text font-weight-light"">SIMED CREDITOS</span>
            </a>
            <!-- Sidebar -->
            <div class=""sidebar"">
                <!-- Sidebar Menu -->
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                        <!-- Add icons to the links using the .nav-icon class
        with font-awesome or any other icon font library -->

                        <li class=""nav-header"">OPCIONES</li>
");
                EndContext();
#line 80 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                         if (profileId == (int)Enums.Profile.ADMINISTRADOR)
                        {

#line default
#line hidden
                BeginContext(3448, 85, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3533, "\"", 3570, 1);
#line 83 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3540, Url.Action("Cliente", "Main"), 3540, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3571, 310, true);
                WriteLiteral(@" class=""nav-link"">
                                    <i class=""nav-icon far fa-file""></i>
                                    <p>
                                        Bandeja de Cliente
                                    </p>
                                </a>
                            </li>
");
                EndContext();
                BeginContext(3883, 85, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3968, "\"", 4015, 1);
#line 92 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3975, Url.Action("FormularioCliente", "Main"), 3975, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4016, 318, true);
                WriteLiteral(@" class=""nav-link"">
                                    <i class=""nav-icon far fa-file""></i>
                                    <p>
                                        Formulario credito Cliente
                                    </p>
                                </a>
                            </li>
");
                EndContext();
#line 99 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"

                        }
                        

#line default
#line hidden
                BeginContext(5166, 374, true);
                WriteLiteral(@"                    </ul>
                </nav>
                <!-- /.sidebar-menu -->
            </div>
            <!-- /.sidebar -->
        </aside>
        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">

            <!-- Main content -->
            <section class=""content"">
                <br />
                ");
                EndContext();
                BeginContext(5541, 12, false);
#line 136 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5553, 556, true);
                WriteLiteral(@"
            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->
        <footer class=""main-footer"">
            <div class=""float-right d-none d-sm-block"">
                <b>Version</b> 3.0.0
            </div>
        </footer>
        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6109, "\"", 6161, 1);
#line 154 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6115, Url.Content("~/plugins/jquery/jquery.min.js"), 6115, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6162, 55, true);
                WriteLiteral("></script>\r\n    <!-- jQuery Validation -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6217, "\"", 6285, 1);
#line 156 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6223, Url.Content("~/plugins/jquery-validation/jquery.validate.js"), 6223, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6286, 49, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap 4 -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6335, "\"", 6415, 1);
#line 158 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6341, Url.Content("~/plugins/jquery-validation/localization/messages_es_PE.js"), 6341, 74, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6416, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6439, "\"", 6492, 1);
#line 159 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6445, Url.Content("~/plugins/select2/js/select2.js"), 6445, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6493, 28, true);
                WriteLiteral("></script>\r\n   \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6521, "\"", 6589, 1);
#line 161 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6527, Url.Content("~/plugins/bootstrap/js/bootstrap.bundle.min.js"), 6527, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6590, 52, true);
                WriteLiteral("></script>\r\n\r\n    <!-- AdminLTE App -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6642, "\"", 6693, 1);
#line 164 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6648, Url.Content("~/adminlte/js/adminlte.min.js"), 6648, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6694, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6717, "\"", 6785, 1);
#line 165 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6723, Url.Content("~/plugins/jquery-loading/jquery.loading.min.js"), 6723, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6786, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6809, "\"", 6874, 1);
#line 166 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6815, Url.Content("~/plugins/sweetalert/dist/sweetalert.min.js"), 6815, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6875, 50, true);
                WriteLiteral("></script>\r\n\r\n    <script>\r\n        var appURL = \"");
                EndContext();
                BeginContext(6926, 17, false);
#line 169 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                 Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(6943, 374, true);
                WriteLiteral(@""";

        $(function () {

            Get(""Main/GetUserData"").done(function (response) {
                var result = response.data;
                if (response.code == 0) {
                    var nombre = result.Fullname;
                    $(""#nombreUsuarioLayout"").text(nombre);
                }
            });

        });
    </script>
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 7317, "\"", 7353, 1);
#line 183 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7323, Url.Content("~/js/global.js"), 7323, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7354, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(7371, 31, false);
#line 184 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(7402, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7411, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
