#pragma checksum "C:\Users\usuario\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884cc88d207aa8fc3bc99a87a2175a143ebfd878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Rutas.Pages_Rutas_List), @"mvc.1.0.razor-page", @"/Pages/Rutas/List.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Rutas
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
#line 1 "C:\Users\usuario\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"884cc88d207aa8fc3bc99a87a2175a143ebfd878", @"/Pages/Rutas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rutas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 
<table class=""table table-hover"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">id</th>
      <th scope=""col"">Origen</th>
      <th scope=""col"">Destino</th>
      <th scope=""col"">Tiempo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope=""row"">1</th>
      <td>54526</td>
      <td>Centro</td>
      <td>Terminal</td>
      <td>2hrs</td>
    </tr>
    <tr>
      <th scope=""row"">2</th>
      <td>34584</td>
      <td>Estadio</td>
      <td>Centro</td>
      <td>1:30hrs</td>
    </tr>
    <tr>
      <th scope=""row"">3</th>
      <td>21458</td>
      <td>Estadio</td>
      <td>Terminal</td>
      <td>45min</td>
    </tr>
  </tbody>
</table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Rutas_List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Rutas_List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Rutas_List>)PageContext?.ViewData;
        public Pages_Rutas_List Model => ViewData.Model;
    }
}
#pragma warning restore 1591
