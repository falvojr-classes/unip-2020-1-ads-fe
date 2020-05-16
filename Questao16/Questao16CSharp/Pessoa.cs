namespace Questao16CSharp
{
    public class Pessoa
    {
        public int Rg { get; private set; }
        public string Nome { get; private set; }
        
        public Pessoa(int rg, string nome)
        {
            Rg = rg;
            Nome = nome;
        }

    }

}
