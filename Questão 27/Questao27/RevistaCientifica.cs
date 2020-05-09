using System.Collections.Generic;

namespace Questao27
{
    public class RevistaCientifica
    {
        public string Titulo { get; set; }
        public string Issn { get; set; }
        public string Periodicidade { get; set; }
        public List<Edicao> Edicoes { get; set; } = new List<Edicao>();
    }
}