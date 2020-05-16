using System;

namespace Questao16CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(123, "Jãum", 1000);

            double salarioReajustado = funcionario.ObterSalario(100);
            Console.WriteLine(salarioReajustado);

            salarioReajustado = funcionario.ObterSalario(500, 100);
            Console.WriteLine(salarioReajustado);
        }
    }
}
