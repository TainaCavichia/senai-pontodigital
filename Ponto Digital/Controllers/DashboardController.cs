using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorio;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers {
    public class DashboardController : Controller {
        ComentarioViewModel dados = new ComentarioViewModel ();
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";
        List<ComentarioModel> comentarios = new List<ComentarioModel>();
        List<ComentarioModel> aprovados = new List<ComentarioModel>();
        List<ComentarioModel> rejeitados = new List<ComentarioModel>();
        List<UsuarioModel> usuarios = new List<UsuarioModel>();
        List<ComentarioModel> listaComentariosRecentes = new List<ComentarioModel>();
        List<UsuarioModel> listaUsuariosRecentes = new List<UsuarioModel>();

        public IActionResult Index () {
            comentarios = comentarioRepositorio.ListarComentarios ();
            usuarios = usuarioRepositorio.ListarUsuarios();

            foreach(var item in comentarios){

            if(item.Status == "Aprovado"){
                    aprovados.Add(item);
                    }
            else if(item.Status == "Rejeitado"){
                    rejeitados.Add(item);
            }
            }
            comentarios.Reverse();
            usuarios.Reverse();
            
            int count = 0;
            foreach (var item in comentarios)
            { 
                if (count < 10)
                {
                    listaComentariosRecentes.Add(item);
                    count++;    
                }
            }
            count = 0;
            foreach (var item in usuarios)
            {
                if (count < 10)
                {
                    listaUsuariosRecentes.Add(item);
                    count++;
                }
            }

            ViewData["Controller"] = HttpContext.Session.GetString (SESSION_USUARIO);
            ViewData["Tipo"] = HttpContext.Session.GetString (SESSION_TIPO);
            ViewData["User"] = HttpContext.Session.GetString (SESSION_EMAIL);

            dados.QuantidadeAprovados = aprovados.Count;
            dados.QuantidadeRejeitados = rejeitados.Count;
            dados.QuantidadeUsuarios = usuarios.Count;
            dados.QuantidadeComentarios = comentarios.Count;

            dados.UltimosUsuarios = listaUsuariosRecentes;
            dados.UltimosComentarios = listaComentariosRecentes;
            
            return View (dados);
        }
    }
}