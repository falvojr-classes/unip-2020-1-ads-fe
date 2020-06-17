namespace Questao28CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste "Inverter Palavra"
            Pilha pilha = new Pilha();
            pilha.Iverter("FELICIDADE");

            // Teste "Pilha Vazia"
            pilha.Pop();

            // Teste "Pilha Cheia"
            for (int i = 0; i < 51; i++)
            {
                pilha.Push('A');
            }
        }
    }
}
