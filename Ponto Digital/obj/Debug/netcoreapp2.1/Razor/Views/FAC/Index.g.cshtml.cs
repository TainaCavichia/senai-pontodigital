#pragma checksum "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\FAC\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e61f1c037cf0f53691df0d522fb47a3f666f9bbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAC_Index), @"mvc.1.0.view", @"/Views/FAC/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FAC/Index.cshtml", typeof(AspNetCore.Views_FAC_Index))]
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
#line 1 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\_ViewImports.cshtml"
using PD_programado;

#line default
#line hidden
#line 2 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\_ViewImports.cshtml"
using PD_programado.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61f1c037cf0f53691df0d522fb47a3f666f9bbe", @"/Views/FAC/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5796a0e5b745276a732d256555170b9a762a42f", @"/Views/_ViewImports.cshtml")]
    public class Views_FAC_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 1 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\FAC\Index.cshtml"
   
var user = (string) ViewData["User"];
var tipo = (string) ViewData["Tipo"];

#line default
#line hidden
            BeginContext(86, 1658, true);
            WriteLiteral(@"  <h1>Perguntas Frequentes</h1>
    <section id=""perguntas"">
        <div>
            <img id=""foto"" src=""images/perguntas-png-3.png"" alt=""Duvidas"">  
        </div>
        <div class=""bla"">
            <div class=""qwer"">
                <img id=""seta"" src=""images/iconseta.png"" alt=""seta"">
                    <div>
                    <h2>Como funciona?</h2>
                    <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Hic perferendis inventore debitis animi architecto tempore voluptatibus, nam et est ipsam recusandae consectetur maxime illum repudiandae laborum consequuntur nostrum cum magnam!</p>
                </div>
            </div>
            <div class=""qwer"">
                <img id=""seta"" src=""images/iconseta.png"" alt=""seta"">
                    <div>
                    <h2>Quanto custa?</h2>
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quo aspernatur illo commodi eos dolores quidem autem. Soluta, assumenda voluptates ipsa ");
            WriteLiteral(@"fugiat non repellendus neque corrupti modi earum? Quidem, dolor fugiat.</p>
                </div>
            </div>
            <div class=""qwer"">
                <img id=""seta"" src=""images/iconseta.png"" alt=""seta"">
                    <div>
                    <h2>Tem acesso em smartphone?</h2>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam amet quis ut expedita temporibus at. Quibusdam totam doloribus consectetur quae excepturi ea corporis officia magni, placeat sunt, temporibus, et blanditiis.</p>
                </div>
            </div>
        </div>
    </section>");
            EndContext();
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
