using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Backlog_Gamer
{
    public class JogoRepositorio
    {
        private readonly string caminho =
            Path.Combine(Application.StartupPath, "jogos.json");

        public List<Jogo> Carregar()
        {
            // primeira execução: o arquivo ainda não existe
            if (!File.Exists(caminho))
                return new List<Jogo>();

            string json = File.ReadAllText(caminho);
            var lista = JsonConvert.DeserializeObject<List<Jogo>>(json);

            // arquivo vazio: devolve lista vazia em vez de null
            return lista ?? new List<Jogo>();
        }

        public void Salvar(List<Jogo> lista)
        {
            string json = JsonConvert.SerializeObject(
                lista,
                Formatting.Indented,
                new StringEnumConverter());   // grava os enums como texto

            File.WriteAllText(caminho, json);
        }
    }
}
