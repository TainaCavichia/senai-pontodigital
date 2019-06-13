using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorio {
    public class UsuarioRepositorio : BaseRepository {
         private const string PATH = "Database/Usuarios.csv";
         List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public UsuarioModel CadastrarNoCSV (UsuarioModel usuario) {
            if (File.Exists (PATH)) {
                usuario.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                usuario.Id = 1;
            }

            usuario.TipoDeUsuario = "Comum";

            StreamWriter sw = new StreamWriter (PATH, true);
            sw.WriteLine ($"id={usuario.Id};nome={usuario.Nome};email={usuario.Email};senha={usuario.Senha};data-nascimento={usuario.DataDeNascimento};tipousuario={usuario.TipoDeUsuario}");
            sw.Close ();

            return usuario;
        }
         private UsuarioModel ConverterEmObjeto (string registro) {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Id = int.Parse(ExtrairCampo("id", registro));
            usuario.Nome = ExtrairCampo("nome", registro);
            usuario.Email = ExtrairCampo("email", registro);
            usuario.Senha = ExtrairCampo("senha", registro);
            usuario.DataDeNascimento = DateTime.Parse(ExtrairCampo("data-nascimento", registro));
            usuario.TipoDeUsuario = ExtrairCampo("tipousuario", registro);

            return usuario;
        }

        public UsuarioModel ObterPor (string email) {
            foreach (var item in LerCSV (PATH:"Database/Usuarios.csv")) {
                if (email.Equals (ExtrairCampo ("email", item))) {

                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }
          public List<UsuarioModel> ListarUsuarios(){
                 var linhas = LerCSV (PATH);
                 foreach (var item in linhas)
                 {
                     UsuarioModel usuario = ConverterEmObjeto(item);
                    
                    this.listaDeUsuarios.Add(usuario);
                 }
                return listaDeUsuarios;
        }
    
    }
}