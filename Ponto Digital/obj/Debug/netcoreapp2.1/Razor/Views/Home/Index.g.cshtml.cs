#pragma checksum "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c5cf71c3935501e2b41b23cb4a5bdfabe817ab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c5cf71c3935501e2b41b23cb4a5bdfabe817ab8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5796a0e5b745276a732d256555170b9a762a42f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ponto_Digital.ViewModel.ComentarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/Comentar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/Cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
  
var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(100, 3693, true);
            WriteLiteral(@"
    <main>
        <div>
            <br><br><br><br>
            <section id=""produto"">
                <h1>Ponto Digital</h1>
                <p>O Ponto Digital é uma ótima solução quando se trata de funcionários. Com o nosso site você pode
                    controlar o rendimento do trabalho de cada funcionário em tempo real, e principalmente, a qualquer
                    hora, no computador, tablet ou smartphone, otimizando assim tempo e dinheiro. </p>
            </section>
            <img class=""linha"" src=""images/linha descrição .png"" alt=""linha"">
            <section id=""funcionamento"">

                <div class=""bola"">
                    <img class=""imagens"" src=""images/Camada 0.png"" alt="""">
                    <h3>Eficiente</h3>
                    <p>Tenha acesso a todas as informações como a hora em que o funcionário começou o trabalho e
                        finalizou, onde ele bateu o ponto e algumas estatisticas sobre seu rendimento </p>
                </div>

  ");
            WriteLiteral(@"              <div class=""bola"">
                    <img class=""imagem"" src=""images/Camada 01.png"" alt="""">
                    <h3>Essencial</h3>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Sit at quae eligendi, voluptatum optio
                        facere debitis nisi ipsam iure qui harum, dolore culpa nihil consseudyewhyyrywe </p>
                </div>

                <div class=""bola"">
                    <img class=""imagemm"" src=""images/Camada 02.png"" alt="""">
                    <h3>Economico</h3>
                    <p>Economize tempo e dinheiro com acesso em qualquer lugar como computador, tablet e smartphone e a
                        qualquer hora com a disponibilidade de 100% da Agora vai para você!</p>
                </div>

            </section>

        </div>

        <h2 id=""plano"">Conheça nossos planos</h2>
        <section id=""planos"">
            <div class=""box"">
                <div class=""a1"">
                    <a href=""#");
            WriteLiteral(@"cadastro"">
                        <h4>Basic</h4>
                        <p>R$ <span id=""spn""> 29,90</span></p>
                        <p>Ideal para empresas de pequeno porte
                            <br> Permite gerenciar
                            até 5 funcionários</p>
                    </a>
                </div>
            </div>
            <div class=""box"">
                <div class=""a1"">
                    <a href=""#cadastro"">
                        <h4>Advanced</h4>
                        <p>R$ <span id=""spn"">149,90</span></p>
                        <p>Ideal para empresas de porte médio
                            <br> Permite gerenciar
                            até 50 funcionários</p>
                    </a>
                </div>
            </div>

            <div class=""box"">
                <div class=""a1"">
                    <a href=""#cadastro"">
                        <h4>Professional</h4>
                        <p>R$<span id=""spn"">299,90</span></p>");
            WriteLiteral(@"
                        <p>Ideal para empresas de grande porte
                            <br> Permite gerenciar
                            até 300 funcionários</p>
                    </a>
                </div>
            </div>
            <div class=""box"">
                <div class=""a1 a4"">
                    <a href=""#cadastro"">
                        <p> Teste grátis por 30 dias!</p>
                    </a>
                </div>
            </div>

        </section>
        
        <section id=""comentarios"">
            <h2>Comentários</h2>
            <div class=""COMENTARIO"">
");
            EndContext();
#line 93 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             foreach (var item in Model.Comentarios) {

#line default
#line hidden
            BeginContext(3849, 79, true);
            WriteLiteral("            <div class=\"caixa\">\r\n            <br>\r\n            <p class=\"nome\">");
            EndContext();
            BeginContext(3929, 16, false);
#line 96 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                       Write(item.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(3945, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(3967, 13, false);
#line 97 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
          Write(item.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(3980, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(4002, 19, false);
#line 98 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
          Write(item.DataComentario);

#line default
#line hidden
            EndContext();
            BeginContext(4021, 44, true);
            WriteLiteral("</p>\r\n            <br>\r\n            </div>\r\n");
            EndContext();
#line 101 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
            }                

#line default
#line hidden
            BeginContext(4096, 70, true);
            WriteLiteral("            </div>\r\n        </section>\r\n\r\n        <section id=\"SAC\">\r\n");
            EndContext();
#line 106 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if(string.IsNullOrEmpty(user)){

#line default
#line hidden
            BeginContext(4212, 99, true);
            WriteLiteral("                <h2>SAC</h2>\r\n                <p>Para deixar um comentário faça login no site</p>\r\n");
            EndContext();
#line 109 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4326, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 110 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if(!string.IsNullOrEmpty(user)){

#line default
#line hidden
            BeginContext(4373, 91, true);
            WriteLiteral("            <h2>Converse conosco! <br> Deixe seu comentário e tire suas dúvidas aqui</h2>\r\n");
            EndContext();
            BeginContext(4466, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(4478, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6136675fc7c6481798ab8d83afcfe30c", async() => {
                BeginContext(4534, 233, true);
                WriteLiteral("\r\n                <div class=\"bla\">\r\n                    <input type=\"text\" name=\"mensagem\" maxlength=\"500\" placeholder=\"Mensagem\" required>\r\n                </div>\r\n                <input class=\"submitt\" type=\"submit\">\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4774, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 119 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(4809, 1006, true);
            WriteLiteral(@"        </section>

        <section id=""quemsomos"">
            <h2>Quem somos?</h2>
            <img src=""images/Carlos.png"" alt=""Carlos Tsukamoto"">
            <img src=""images/César.png"" alt=""César Sportore"">
            <p>A Agora vai nasceu em 2012, com a iniciativa de gerenciar funcionários digitalmente, para acabar com as
                fraudes ao bater o ponto e ter mais controle, utilizando técnologias modernas. No início era apenas uma
                ideia sem força, e acabou sendo desenvolvida por dois empreendedores incríveis, César Sportore e Carlos
                Tsukamoto que foram, ao longo dos anos, construindo nossa equipe de profissionais, que hoje têm orgulho
                de dizer que são da Agora vai.</p>
        </section>

        <section id=""cadastro"">
            <h2>Faça seu pedido aqui</h2>
            <div>

                <div class=""amem"">
                    <div>
                        <h3>Cadastre-se</h3>
                        ");
            EndContext();
            BeginContext(5815, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bbc750ca5444501a92d122de3c73aef", async() => {
                BeginContext(5871, 590, true);
                WriteLiteral(@"
                            
                            <input type=""text"" name=""nome"" placeholder=""Nome Completo"" maxlength=""50"" required>
                            <input type=""e-mail"" name=""email"" placeholder=""E-mail"" maxlength=""50"" required>
                            <input type=""password"" name=""senha"" placeholder=""Senha"" maxlength=""10"" required>
                            <input type=""date"" placeholder= ""Data de Nascimento"" name=""data-nascimento""  required>
                            <input class=""submittt"" type=""submit"" value=""Cadastrar"">
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6468, 135, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div>\r\n                        <h3 id=\"login\">Login </h3>\r\n                        ");
            EndContext();
            BeginContext(6603, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5daf42829b1549b09a80f29d5f9bfc19", async() => {
                BeginContext(6672, 327, true);
                WriteLiteral(@"
                            <input type=""e-mail"" name=""email"" placeholder=""E-mail"" maxlength=""50"" required>
                            <input type=""password"" name=""senha"" placeholder=""Senha"" maxlength=""10"" required>
                            <input class=""submittt"" type=""submit"" value=""Logar"">
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 153 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6631, Url.Action("Login","Home"), 6631, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7006, 126, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n            </div>\r\n        </section>\r\n   </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ponto_Digital.ViewModel.ComentarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
