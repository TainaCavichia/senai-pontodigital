using System;

namespace Ponto_Digital.Models
{
    public class ComentarioModel
    {

        public int Id {get;set;}
        public string NomeUsuario {get;set;}
        public string Status{get;set;}
        public DateTime DataComentario {get;set;}
        public string Mensagem {get;set;}
    }
}