
public class Program {

	public static void main(String[] args) {
		Funcionario funcionario = new Funcionario(123, "Jãum", 1000);
		
		double salarioReajustado = funcionario.obterSalario(100);
		System.out.println(salarioReajustado);
		
		salarioReajustado = funcionario.obterSalario(500, 100);
		System.out.println(salarioReajustado);
	}

}
