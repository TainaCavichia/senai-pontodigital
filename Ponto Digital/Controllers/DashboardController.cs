using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Repositorio;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers {
    public class DashboardController : Controller {
        ComentarioViewModel comentario = new ComentarioViewModel ();
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";


        public IActionResult Index () {
            comentario.Comentarios = comentarioRepositorio.ListarComentarios ();
            comentario.Usuarios = usuarioRepositorio.ListarUsuarios();

            ViewData["Controller"] = HttpContext.Session.GetString (SESSION_USUARIO);
            ViewData["Tipo"] = HttpContext.Session.GetString (SESSION_TIPO);
            ViewData["User"] = HttpContext.Session.GetString (SESSION_EMAIL);

            return View (comentario);
        }
    }
}