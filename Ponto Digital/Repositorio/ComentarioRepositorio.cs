using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorio
{
    public class ComentarioRepositorio : BaseRepository
    {
            List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
            List<ComentarioModel> listaDeAprovados = new List<ComentarioModel>();
            private const string PATH = "Database/Comentarios.csv";
         public ComentarioModel CadastrarNoCSV (ComentarioModel comentario) {
            if (File.Exists (PATH)) {
                comentario.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                comentario.Id = 1;
            }
            StreamWriter sw = new StreamWriter (PATH, true);
            sw.WriteLine ($"id={comentario.Id};nome={comentario.NomeUsuario};data-comentario={comentario.DataComentario};mensagem={comentario.Mensagem};status={comentario.Status}");
            sw.Close ();

            return comentario;
        }
            private ComentarioModel ConverterEmObjeto (string registro) {
            ComentarioModel comentario = new ComentarioModel();
            comentario.Id = int.Parse(ExtrairCampo("id", registro));
            comentario.NomeUsuario = ExtrairCampo("nome", registro);
            comentario.DataComentario = DateTime.Parse(ExtrairCampo("data-comentario", registro));
            comentario.Mensagem = ExtrairCampo("mensagem", registro);
            comentario.Status = ExtrairCampo("status", registro);
            
            return comentario;
            }
             public List<ComentarioModel> ListarComentarios(){
                 var linhas = LerCSV (PATH);
                 foreach (var item in linhas)
                 {
                     ComentarioModel comentario = ConverterEmObjeto(item);
                    
                    this.listaDeComentarios.Add(comentario);
                 }
                return listaDeComentarios;
        }
            public List<ComentarioModel> ListarComentariosAprovados(){
                foreach (var item in listaDeComentarios)
                {
                    if (item.Status.Equals("Aprovado"))
                    {
                       listaDeAprovados.Add(item); 
                    }
                }
                return listaDeAprovados;
            }
           public ComentarioModel ObterPor (int id) {

            foreach (var item in LerCSV (PATH)) {
                if (id.Equals (int.Parse(ExtrairCampo ("id", item)))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }
        public ComentarioModel EditarNoCSV(ComentarioModel comentario){

            string[] linhas = LerCSV(PATH);
            string comparadora = "id=";

            comparadora += comentario.Id.ToString();

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");


                if (comparadora.Equals(linha[0]))
                {
                    linhas[i] = $"id={comentario.Id};nome={comentario.NomeUsuario};data-comentario={comentario.DataComentario};mensagem={comentario.Mensagem};status={comentario.Status}";
                }
            }
            System.IO.File.WriteAllLines(PATH, linhas);
            return comentario;
        }
    }
}