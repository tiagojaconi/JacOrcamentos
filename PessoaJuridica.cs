using System;

class PessoaJuridica:Cliente{
	private string cnpj= " ";
	private string razaoSocial= " "; 

	public bool SetCnpj(){
		
		bool verificacao = false;

		try{
		
			int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
			int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
			int soma, resto;
			string digito, tempCnpj, newCnpj;
		
			newCnpj = Console.ReadLine();
			newCnpj = newCnpj.Replace(".", "").Replace("/", "").Replace("-", "");

			if (newCnpj.Length != 14){
			 verificacao = false;
			}
			
			tempCnpj = newCnpj.Substring(0, 12);
			soma = 0;

			for(int i=0; i<12; i++){
			  soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			}
			resto = (soma % 11);

			if ( resto < 2){
			  resto = 0;
			}else{
			  resto = 11 - resto;
			}
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;

			for (int i = 0; i < 13; i++){
			  soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			}
			resto = (soma % 11);

			if (resto < 2){
			  resto = 0;
			}else{
			  resto = 11 - resto;
			}
			digito = digito + resto.ToString();
			if (newCnpj.EndsWith(digito)){
				cnpj = newCnpj;
			}
			verificacao= newCnpj.EndsWith(digito);
		}
		catch(FormatException letrasException){
			Console.WriteLine("Não digite letras!!!");
			verificacao = false;
		}catch (Exception){
			throw new Excecao ("Valores inválidos CNPJ!!!");
			verificacao = false;
		}
		return verificacao;	
	}
	public string GetCnpj(){
		return cnpj;
	}
	public void SetRazaoSocial(string razao){
		razaoSocial = razao;
	}
	public string GetRazaoSocial(){
		return razaoSocial;
	}
}