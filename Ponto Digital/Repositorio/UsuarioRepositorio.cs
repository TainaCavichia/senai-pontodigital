using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioModel CadastrarNoCSV (UsuarioModel usuario)
        {
            if(File.Exists("Database/Usuarios.csv"))
            {
                usuario.Id = File.ReadAllLines("Database/Usuarios.csv").Length + 1;
            }else
            {
                usuario.Id = 1;
            }
            StreamWriter sw = new StreamWriter("Database/Usuarios.csv", true);
            sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDeNascimento}");
            sw.Close();

            return usuario;
        }
        public List<UsuarioModel> Listar ()
        {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();

            string[] linhas = File.ReadAllLines ("Database/Usuarios.csv");
            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty (item))
                {
                    continue;
                }
                string[] linha = item.Split(";");
                var usuarioRecuperado = new UsuarioModel();

                usuarioRecuperado.Id = int.Parse(linha[0]);
                usuarioRecuperado.Nome = (linha[1]);
                usuarioRecuperado.Email = (linha[2]);
                usuarioRecuperado.Senha = (linha[3]);
                usuarioRecuperado.DataDeNascimento = DateTime.Parse((linha[4]));

                listaDeUsuarios.Add(usuarioRecuperado);
            }
            return listaDeUsuarios;
        }
    }
}