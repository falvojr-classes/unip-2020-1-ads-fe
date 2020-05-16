
public class Funcionario extends Pessoa {

	private double salario;

	public Funcionario(int rg, String nome, double salario) {
		super(rg, nome);
		this.salario = salario;
	}

	public double getSalario() {
		return salario;
	}

	public double obterSalario(double percentualAcrescimo) {
		double salarioReajustado = salario + salario * percentualAcrescimo / 100;
		return salarioReajustado;
	}

	public double obterSalario(double adicional, double desconto) {
		return this.getSalario() + adicional - desconto;
	}
}
