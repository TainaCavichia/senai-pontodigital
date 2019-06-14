using System.Collections.Generic;
using Ponto_Digital.Models;

namespace Ponto_Digital.ViewModel
{
    public class ComentarioViewModel
    {
        public List<ComentarioModel> Comentarios {get;set;}

        public List<ComentarioModel> ComentariosAprovados {get;set;}
        
        public List<UsuarioModel> Usuarios {get;set;}


        public List<ComentarioModel> UltimosComentarios {get;set;}
        public List<UsuarioModel> UltimosUsuarios {get;set;}
        public int QuantidadeUsuarios {get;set;}
        public int QuantidadeComentarios {get;set;}
        public int QuantidadeAprovados {get;set;}
        public int QuantidadeRejeitados {get;set;}
    }
}