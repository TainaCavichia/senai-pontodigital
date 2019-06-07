using System.IO;

namespace Ponto_Digital.Repositorio
{
    public abstract class BaseRepository
    {
        protected string[] LerCSV (string PATH){
        return File.ReadAllLines(PATH);
        }
        protected string ExtrairCampo (string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";

            if (indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else{
                valor = linha.Substring(indiceChave);
            }
            return valor.Replace(nomeCampo + "=","");
        }
    }
}