#pragma checksum "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f02da51793fbabb4f44b301c3152d65b4be07f31"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02da51793fbabb4f44b301c3152d65b4be07f31", @"/Views/Shared/_Layout.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08344794c59e433ea7b7590d302d8057", async() => {
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
            BeginContext(1561, 9637, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ab41497be54dc6b0f7de751a627400", async() => {
                BeginContext(1604, 767, true);
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
                        Bienvenido(a) :   <strong id=""nombreUsuarioLayout""></strong><input id=""perfil"" type="""">
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2371, "\"", 2407, 1);
#line 57 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2378, Url.Action("Index", "Login"), 2378, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2408, 312, true);
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
                BeginWriteAttribute("href", " href=\"", 2720, "\"", 2755, 1);
#line 67 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2727, Url.Action("Index", "Main"), 2727, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2756, 611, true);
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
                            /*<li class="nav-item">
                                <a href="@Url.Action("Cliente", "Main")" class="nav-link">
                                    <i class="nav-icon far fa-file"></i>
                                    <p>
                                        Bandeja de Cliente
                                    </p>
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="@Url.Action("FormularioCliente", "Main")" class="nav-link">
                                    <i class="nav-icon far fa-file"></i>
                                    <p>
                                        Formulario credito Cliente
                                    </p>
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="@Url.Action("FormularioPerfilFinanzas", "Main")" class="nav-link">
                                    <i class="nav-icon far fa-file"></i>
                                    <p>
                                        Formulario Finanzas
                                    </p>
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="@Url.Action("FormularioPerfilGerenteVentas", "Main")" class="nav-link">
                                    <i class="nav-icon far fa-file"></i>
                                    <p>
                                        Formulario Gerente Ventas
                                    </p>
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="@Url.Action("FormularioPerfilAnalistaCredito", "Main")" class="nav-link">
                                    <i class="nav-icon far fa-file"></i>
                                    <p>
                                        Formulario Analista Credito
                                    </p>
                                </a>
                            </li>*/
                        }
                        else if (profileId == (int)Enums.Profile.ASESORCOMERCIAL)
                        {

#line default
#line hidden
                BeginContext(5883, 85, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5968, "\"", 6015, 1);
#line 130 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5975, Url.Action("FormularioCliente", "Main"), 5975, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6016, 328, true);
                WriteLiteral(@" class=""nav-link"">
                                    <i class=""nav-icon far fa-file""></i>
                                    <p>
                                        Formulario credito Cliente Comercial
                                    </p>
                                </a>
                            </li>
");
                EndContext();
#line 137 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                        }
                        else if (profileId == (int)Enums.Profile.ANALISTACREDITO)
                        {

#line default
#line hidden
                BeginContext(6481, 85, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6566, "\"", 6603, 1);
#line 141 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6573, Url.Action("Cliente", "Main"), 6573, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6604, 318, true);
                WriteLiteral(@" class=""nav-link"">
                                    <i class=""nav-icon far fa-file""></i>
                                    <p>
                                        Bandeja de Cliente Credito
                                    </p>
                                </a>
                            </li>
");
                EndContext();
#line 148 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                        }
                        else if (profileId == (int)Enums.Profile.GERENTENEGOCIO)
                        {

#line default
#line hidden
                BeginContext(7058, 85, true);
                WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 7143, "\"", 7192, 1);
#line 152 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7150, Url.Action("BandejaGerenteVenta", "Main"), 7150, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7193, 316, true);
                WriteLiteral(@" class=""nav-link"">
                                    <i class=""nav-icon far fa-file""></i>
                                    <p>
                                        Bandeja de Cliente Venta
                                    </p>
                                </a>
                            </li>
");
                EndContext();
#line 159 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(7593, 69, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 7662, "\"", 7714, 1);
#line 163 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7669, Url.Action("BandejaGerenteFinanzas", "Main"), 7669, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7715, 271, true);
                WriteLiteral(@" class=""nav-link"">
                            <i class=""nav-icon far fa-file""></i>
                            <p>
                                Bandeja de Cliente Finanzas
                            </p>
                        </a>
                    </li>
");
                EndContext();
#line 170 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(8013, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(8814, 376, true);
                WriteLiteral(@"
                    </ul>
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
                BeginContext(9191, 12, false);
#line 206 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(9203, 556, true);
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
                BeginWriteAttribute("src", " src=\"", 9759, "\"", 9811, 1);
#line 224 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9765, Url.Content("~/plugins/jquery/jquery.min.js"), 9765, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9812, 55, true);
                WriteLiteral("></script>\r\n    <!-- jQuery Validation -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 9867, "\"", 9935, 1);
#line 226 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9873, Url.Content("~/plugins/jquery-validation/jquery.validate.js"), 9873, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9936, 49, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap 4 -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 9985, "\"", 10065, 1);
#line 228 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9991, Url.Content("~/plugins/jquery-validation/localization/messages_es_PE.js"), 9991, 74, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10066, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10089, "\"", 10142, 1);
#line 229 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 10095, Url.Content("~/plugins/select2/js/select2.js"), 10095, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10143, 28, true);
                WriteLiteral("></script>\r\n   \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10171, "\"", 10239, 1);
#line 231 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 10177, Url.Content("~/plugins/bootstrap/js/bootstrap.bundle.min.js"), 10177, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10240, 52, true);
                WriteLiteral("></script>\r\n\r\n    <!-- AdminLTE App -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10292, "\"", 10343, 1);
#line 234 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 10298, Url.Content("~/adminlte/js/adminlte.min.js"), 10298, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10344, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10367, "\"", 10435, 1);
#line 235 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 10373, Url.Content("~/plugins/jquery-loading/jquery.loading.min.js"), 10373, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10436, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10459, "\"", 10524, 1);
#line 236 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 10465, Url.Content("~/plugins/sweetalert/dist/sweetalert.min.js"), 10465, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10525, 50, true);
                WriteLiteral("></script>\r\n\r\n    <script>\r\n        var appURL = \"");
                EndContext();
                BeginContext(10576, 17, false);
#line 239 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
                 Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(10593, 511, true);
                WriteLiteral(@""";

        $(function () {

            Get(""Main/GetUserData"").done(function (response) {
                var result = response.data;
                console.log(result);
                if (response.code == 0) {
                    var nombre = result.Fullname;
                    var perfil = result.ProfileId;
                    $(""#nombreUsuarioLayout"").text(nombre);
                    $(""#perfil"").val(perfil);
                }
            });

        });
    </script>
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 11104, "\"", 11140, 1);
#line 256 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 11110, Url.Content("~/js/global.js"), 11110, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11141, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(11158, 31, false);
#line 257 "C:\Users\usuario\source\repos\.NET\SistemaCreditoSimed\SimedCredito.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(11189, 2, true);
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
            BeginContext(11198, 11, true);
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
