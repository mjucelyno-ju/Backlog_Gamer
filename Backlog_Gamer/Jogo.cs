using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backlog_Gamer
{
    public enum Plataforma { PC, PlayStation, Xbox, Switch, Mobile }
    public enum Genero { Acao, Aventura, RPG, FPS, Estrategia, Esporte, Outro }

    public class Jogo
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public Plataforma Plataforma { get; set; }
        public Genero Genero { get; set; }
        public decimal Nota { get; set; }
        public bool Zerado { get; set; }
        public DateTime DataAquisicao { get; set; }
        public int HorasJogadas { get; set; }
    }
}
