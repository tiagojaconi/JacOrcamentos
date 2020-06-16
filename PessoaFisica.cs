using System;

class PessoaFisica:Cliente{
	private string cpf= " ";
	
	public bool SetCpf(){
  
		bool verificacao = false;

		try{

			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf, digito, newCpf;
			int soma, resto;
			
			newCpf = Console.ReadLine();
			newCpf = newCpf.Replace(".", "").Replace("-", "");

			if (newCpf.Length != 11){
		  	return false;
			}
			tempCpf = newCpf.Substring(0, 9);
			soma = 0;

			for(int i=0; i<9; i++){
		    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			}
			resto = soma % 11;

			if ( resto < 2 ){
		  	resto = 0;
			}else{
		  	resto = 11 - resto;
			}

			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;

			for(int i=0; i<10; i++){
		    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			}
			resto = soma % 11;
			if (resto < 2){
		  	resto = 0;
			}else{
				resto = 11 - resto;
			}

			digito = digito + resto.ToString();
			verificacao= newCpf.EndsWith(digito);

			if (verificacao==true){
				cpf = newCpf;
			}

		}catch (FormatException letrasException){
			Console.WriteLine("Não digite letras!!!");
			verificacao = false;
		}catch (Exception){
			throw new Excecao ("Valores inválidos Cpf!!!");
			verificacao = false;
		}
		return verificacao;
	}

	public string GetCpf(){
		return cpf;
	}
}