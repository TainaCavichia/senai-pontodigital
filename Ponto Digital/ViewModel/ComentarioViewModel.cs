using System.Collections.Generic;
using Ponto_Digital.Models;

namespace Ponto_Digital.ViewModel
{
    public class ComentarioViewModel
    {
        public List<ComentarioModel> Comentarios {get;set;}

        public List<ComentarioModel> ComentariosAprovados {get;set;}
        
        public List<UsuarioModel> Usuarios {get;set;}
    }
}