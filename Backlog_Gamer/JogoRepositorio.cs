using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Backlog_Gamer
{
    public class JogoRepositorio
    {
        private readonly string caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "BacklogGamer", "jogos.json");

        public List<Jogo> Carregar()
        {
            if (!File.Exists(caminho)) return new List<Jogo>();
            try
            {
                var lista = JsonConvert.DeserializeObject<List<Jogo>>(File.ReadAllText(caminho));
                return lista ?? new List<Jogo>();
            }
            catch (JsonException)
            {
                MessageBox.Show("O arquivo de jogos está corrompido.");
                return new List<Jogo>();
            }
        }

        public void Salvar(List<Jogo> lista)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(caminho));
            File.WriteAllText(caminho, JsonConvert.SerializeObject(
                lista, Formatting.Indented, new StringEnumConverter()));
        }
    }
}