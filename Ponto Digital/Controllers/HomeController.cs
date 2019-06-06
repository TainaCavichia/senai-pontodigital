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

namespace PD_programado.Controllers {
    public class HomeController : Controller {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        [HttpGet]
        public IActionResult Index () {
            return View ();
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
        public IActionResult Logar (IFormCollection form, UsuarioModel usuario)
        {
            var email = form["email"];
            var senha = form["senha"];

            if (email.Equals() && senha.Equals())
            {
                
            }
        }

    }
}