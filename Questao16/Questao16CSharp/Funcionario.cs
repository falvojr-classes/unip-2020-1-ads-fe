namespace Questao16CSharp
{
    public class Funcionario : Pessoa
    {

        public double Salario { get; private set; }

        public Funcionario(int rg, string nome, double salario) : base(rg, nome)
        {
            Salario = salario;
        }

        public double ObterSalario(double percentualAcrescimo)
        {
            double salarioReajustado = Salario + Salario * percentualAcrescimo / 100;
            return salarioReajustado;
        }

        public double ObterSalario(double adicional, double desconto)
        {
            return Salario + adicional - desconto;
        }
    }
}