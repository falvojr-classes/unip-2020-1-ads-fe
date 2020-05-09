using System;

namespace Questao27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação das instâncias/objetos:

            RevistaCientifica revista = new RevistaCientifica();
            revista.Titulo = "Revista UNIP";

            Edicao edicao = new Edicao();
            edicao.Numero = 1;
            edicao.Volume = "v1";
            edicao.Data = DateTime.Now;

            Artigo artigo1 = new Artigo();
            artigo1.Titulo = "Primeiro Artigo";
            artigo1.NomeAutor = "Venilton";

            Artigo artigo2 = new Artigo();
            artigo2.Titulo = "Segundo Artigo";
            artigo2.NomeAutor = "João";

            Artigo artigo3 = new Artigo();
            artigo3.Titulo = "Estudando para o ENADE";
            artigo3.NomeAutor = "José";

            // Criação dos relacionamentos entre os objetos:

            edicao.Artigos.Add(artigo1);
            edicao.Artigos.Add(artigo2);
            edicao.Artigos.Add(artigo3);

            revista.Edicoes.Add(edicao);

            // Imprimir todos os artigos já publicados pela revista:
            
            foreach (Edicao edicaoIteracao in revista.Edicoes)
            {
                foreach (Artigo artigoIteracao in edicaoIteracao.Artigos)
                {
                    Console.WriteLine(artigoIteracao.Titulo);
                }
            }
        }
    }
}
