using System;

class MainClass {
  public static void Main (string[] args) {
		
		int entrada =0;

		Console.WriteLine("\n*****Orçamento de Manutenção/ Instalação de Sistema de Segurança*****");
		Console.WriteLine("***Investir em Segurança, é investir em qualidade de vida... Parabéns!!!***");
		Console.WriteLine("\n**Dica: duvide sempre da qualidade do preço baixo, a dor de cabeça irá lhe acompanhar!!!**");

		while (entrada==0){
			Console.WriteLine("Preciso saber, quem é você? 1- Pessoa Fisica ou 2- Pessoa Juridica ");
			entrada = Convert.ToInt32(Console.ReadLine());
			switch (entrada){
				case 1:
					PessoaFisica orcamento1 = new PessoaFisica();
					Console.WriteLine("Agora preciso que me informe seu CPF:");
					while (!orcamento1.SetCpf()){
						Console.WriteLine("O valor informado não é válido, informe os 11 digitos:");
					}
				break;
					case 2: 
						PessoaJuridica orcamento2 = new PessoaJuridica();
						Console.WriteLine("Agora preciso que me informe seu CNPJ:");
					while (!orcamento2.SetCnpj()){
						Console.WriteLine("O valor informado não é válido, informe os 14 digitos:");
					}
				break;
				default:
					entrada = 0;
				break;
			}
		}
  }
}