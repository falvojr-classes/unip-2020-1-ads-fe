using System;
using System.Collections.Generic;

namespace Questao27
{
    public class Edicao
    {
        public int Numero { get; set; }
        public string Volume { get; set; }
        public DateTime Data { get; set; }
        public List<Artigo> Artigos { get; set; } = new List<Artigo>(15);
    }
}