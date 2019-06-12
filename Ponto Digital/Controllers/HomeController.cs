using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD_programado.Models;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorio;
using Ponto_Digital.ViewModel;

namespace PD_programado.Controllers {
    public class HomeController : Controller {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        ComentarioModel comentarioModel = new ComentarioModel();

        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";

        [HttpGet]
        public IActionResult Index () {

            ComentarioViewModel comentario = new ComentarioViewModel ();
            comentario.Comentarios = comentarioRepositorio.ListarComentarios();   

            ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            return View (comentario);
        }
        public IActionResult Cadastrar (IFormCollection form) {
            string Nome = form["nome"];
            string Email = form["email"];
            string Senha = form["senha"];
            DateTime DataDeNascimento = DateTime.Parse (form["data-nascimento"]);

            if (!string.IsNullOrEmpty (Nome) && Nome.Contains (" ") && Email.Contains ("@") && Email.Contains (".") && Senha.Length >= 6 && DataDeNascimento.AddYears (18) < DateTime.Now) {

                UsuarioModel usuario = new UsuarioModel ();
                usuario.Nome = Nome;
                usuario.Email = Email;
                usuario.Senha = Senha;
                usuario.DataDeNascimento = DataDeNascimento;
                usuarioRepositorio.CadastrarNoCSV (usuario);

                ViewData["Controller"] = "Cadastro";
                return View ("_Sucesso");

            } else {
                ViewData["Controller"] = "Cadastro";
                return View ("_Erro");
            }
        }
        public IActionResult Login (IFormCollection form) {
            var email = form["email"];
            var senha = form["senha"];

            var Usuario = usuarioRepositorio.ObterPor (email);

            if (Usuario != null && Usuario.Email.Equals (email) && Usuario.Senha.Equals (senha)) {
                HttpContext.Session.SetString (SESSION_EMAIL, email);
                HttpContext.Session.SetString (SESSION_USUARIO, Usuario.Nome);
                ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
                ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);

                if (Usuario.TipoDeUsuario.Equals("Administrador"))
                {
                    HttpContext.Session.SetString (SESSION_TIPO, "Administrador");
                    ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);
                    return View("_Sucesso");
                    
                }else if(Usuario.TipoDeUsuario.Equals("Comum")){
                    
                    return View("_Sucesso");
                }
            }
            return RedirectToAction("Index","Home");

        }
        public IActionResult Logout () {
            HttpContext.Session.Remove (SESSION_EMAIL);
            HttpContext.Session.Remove (SESSION_USUARIO);
            HttpContext.Session.Remove (SESSION_TIPO);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
        public IActionResult Comentar(IFormCollection form){
            string Mensagem = form["mensagem"];

            if (!string.IsNullOrEmpty(Mensagem)){
                comentarioModel.NomeUsuario = HttpContext.Session.GetString(SESSION_USUARIO);
                comentarioModel.DataComentario = DateTime.Now;
                comentarioModel.Mensagem = Mensagem;
                comentarioModel.Status = "Aguardando";
                comentarioRepositorio.CadastrarNoCSV(comentarioModel);

                ViewData["Controller"] = "Comentário";
                return View("_Sucesso");

            } else {
                ViewData["Controller"] = "Comentário";
                return View ("_Erro");
            }
        }
        [HttpGet]
        public IActionResult Aprovar(int id){
            ComentarioModel comentarioRecuperado = comentarioRepositorio.ObterPor(id);
            if(comentarioRecuperado != null && comentarioRecuperado.Equals(id)){
                comentarioModel.Status = "Aprovado";
            }
            comentarioRepositorio.EditarNoCSV(comentarioModel);
            return View();
        }
        [HttpGet]
         public IActionResult Rejeitar(int id){
             ComentarioModel comentarioRecuperado = comentarioRepositorio.ObterPor(id);
            if(comentarioRecuperado.Equals(id)){
                comentarioModel.Status = "Rejeitado";
            }
            comentarioRepositorio.EditarNoCSV(comentarioModel);
                
            return View();
        }
    }
}
