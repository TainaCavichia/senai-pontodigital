#pragma checksum "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8d1cf4b0925e7d11c203c2f83787045f41d40e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8d1cf4b0925e7d11c203c2f83787045f41d40e", @"/Views/Home/Index.cshtml")]
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
var tipo = (string) ViewData["Tipo"];

#line default
#line hidden
            BeginContext(139, 3655, true);
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
");
            EndContext();
#line 93 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if(string.IsNullOrEmpty(tipo)){

#line default
#line hidden
            BeginContext(3840, 42, true);
            WriteLiteral("                <div class=\"COMENTARIO\">\r\n");
            EndContext();
#line 95 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                     foreach (var item in Model.ComentariosAprovados) {

#line default
#line hidden
            BeginContext(3955, 115, true);
            WriteLiteral("                        <div class=\"caixa\">\r\n                        <br>\r\n                        <p class=\"nome\">");
            EndContext();
            BeginContext(4071, 16, false);
#line 98 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                                   Write(item.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(4087, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(4121, 13, false);
#line 99 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                      Write(item.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(4134, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(4168, 19, false);
#line 100 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                      Write(item.DataComentario);

#line default
#line hidden
            EndContext();
            BeginContext(4187, 68, true);
            WriteLiteral("</p>\r\n                        <br>\r\n                        </div>\r\n");
            EndContext();
#line 103 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4278, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 105 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                }else if(!string.IsNullOrEmpty(tipo)){

#line default
#line hidden
            BeginContext(4358, 42, true);
            WriteLiteral("                <div class=\"COMENTARIO\">\r\n");
            EndContext();
#line 107 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                     foreach (var item in Model.Comentarios) {

#line default
#line hidden
            BeginContext(4464, 103, true);
            WriteLiteral("                    <div class=\"caixa\">\r\n                    <br>\r\n                    <p class=\"nome\">");
            EndContext();
            BeginContext(4568, 16, false);
#line 110 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                               Write(item.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(4584, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(4614, 13, false);
#line 111 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                  Write(item.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(4627, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(4657, 19, false);
#line 112 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                  Write(item.DataComentario);

#line default
#line hidden
            EndContext();
            BeginContext(4676, 28, true);
            WriteLiteral("</p>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4704, "\"", 4735, 2);
            WriteAttributeValue("", 4711, "Home/Aprovar?id=", 4711, 16, true);
#line 113 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
WriteAttributeValue("", 4727, item.Id, 4727, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4736, 36, true);
            WriteLiteral(">Aprovar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4772, "\"", 4804, 2);
            WriteAttributeValue("", 4779, "Home/Rejeitar?id=", 4779, 17, true);
#line 114 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
WriteAttributeValue("", 4796, item.Id, 4796, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4805, 43, true);
            WriteLiteral(">Rejeitar</a>\r\n                    </div>\r\n");
            EndContext();
#line 116 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4871, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 118 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
            }                

#line default
#line hidden
            BeginContext(4926, 50, true);
            WriteLiteral("        </section>\r\n\r\n        <section id=\"SAC\">\r\n");
            EndContext();
#line 122 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if(string.IsNullOrEmpty(user)){

#line default
#line hidden
            BeginContext(5022, 99, true);
            WriteLiteral("                <h2>SAC</h2>\r\n                <p>Para deixar um comentário faça login no site</p>\r\n");
            EndContext();
#line 125 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5136, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 126 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if(!string.IsNullOrEmpty(user)){

#line default
#line hidden
            BeginContext(5183, 91, true);
            WriteLiteral("            <h2>Converse conosco! <br> Deixe seu comentário e tire suas dúvidas aqui</h2>\r\n");
            EndContext();
            BeginContext(5276, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(5288, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c30a507f90b451baa050f25a81409c3", async() => {
                BeginContext(5344, 233, true);
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
            BeginContext(5584, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 135 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
                
            }

#line default
#line hidden
            BeginContext(5619, 809, true);
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
");
            EndContext();
#line 151 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if(!string.IsNullOrEmpty(user)){

#line default
#line hidden
            BeginContext(6475, 66, true);
            WriteLiteral("                <h2>Obrigado por se cadastrar em nosso site</h2>\r\n");
            EndContext();
#line 153 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6556, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 154 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
             if (string.IsNullOrEmpty(user))
            {

#line default
#line hidden
            BeginContext(6617, 195, true);
            WriteLiteral("            <h2>Faça seu pedido aqui</h2>\r\n            <div>\r\n                <div class=\"amem\">\r\n                    <div>\r\n                        <h3>Cadastre-se</h3>\r\n                        ");
            EndContext();
            BeginContext(6812, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91bf8b73d4314ce8889c098502754a78", async() => {
                BeginContext(6868, 590, true);
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
            BeginContext(7465, 135, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div>\r\n                        <h3 id=\"login\">Login </h3>\r\n                        ");
            EndContext();
            BeginContext(7600, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73161e8af1f641389106bfd2273c0be1", async() => {
                BeginContext(7669, 327, true);
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
#line 173 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7628, Url.Action("Login","Home"), 7628, 27, false);

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
            BeginContext(8003, 76, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 182 "C:\Users\46748080819\Documents\coisas-velhas\Ponto Digital_ferrou\projeto\senai-pontodigital\Ponto Digital\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(8094, 30, true);
            WriteLiteral("        </section>\r\n   </main>");
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
