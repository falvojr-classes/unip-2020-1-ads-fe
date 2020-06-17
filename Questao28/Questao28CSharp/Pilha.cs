using System;

namespace Questao28CSharp
{
    public class Pilha
    {
        const int TAMANHO_MAXIMO = 50;

        public char[] Itens { get; } = new char[TAMANHO_MAXIMO];
        public int Topo { get; private set; } = 0;

        public void Push(char caractere)
        {
            if (Topo >= TAMANHO_MAXIMO)
            {
                Console.WriteLine("Erro: Pilha Cheia");
            }
            else
            {
                Itens[Topo] = caractere;
                Topo += 1;
            }
        }

        public char Pop()
        {
            // https://stackoverflow.com/a/9909357/3072570
            char retorno = '\u0000';
            if (Topo <= 0)
            {
                Console.WriteLine("Erro: Pilha Vazia");
            }
            else
            {
                Topo -= 1;
                retorno = Itens[Topo];
            }
            return retorno;
        }

        public void Iverter(string palavra)
        {
            foreach (char letra in palavra.ToCharArray())
            {
                Push(letra);
            }
            for (int i = 0; i < palavra.Length; i++)
            {
                char letra = Pop();
                Console.Write(letra);
            }
            Console.WriteLine();
        }
    }
}