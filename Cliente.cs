using System;

class Cliente{
	protected string nomeCliente= " ";
	protected string telefone= " ";
	protected string endereco= " ";
	protected int codigoCliente= 0;
	protected string observacao= " ";

	public Cliente(){
		codigoCliente++; //Calculo de codigo do cliente automatico.
	}
	public bool SetNomeCliente(){
		string nome;
		int condicao = 0;
		bool resposta = false;
		
		Console.WriteLine("Informe seu Nome: ");
		nome = Console.ReadLine();
		char [] verificacao = nome.ToCharArray();
		
		for(int i= 0; i<nome.Length;i++){
			switch (verificacao[i]){
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':{ condicao++; break;}
				default: {break;}
			}		
		}
		if (condicao ==0){
			nomeCliente= nome;
			resposta = true;
		}else{
			resposta = false;
		}
		return resposta;
	}
	public string GetNomeCliente(){
		return nomeCliente;
	}
	public int GetCodigoCliente(){
		return codigoCliente;
	}
	public bool SetTelefoneCliente(){
		string newTelefone;
		int condicao = 0;
		bool resposta = false;
		
		Console.WriteLine("Informe seu Telefone (dd)xxxxx-xxxx:  ");
		newTelefone = Console.ReadLine();
		newTelefone = newTelefone.Replace("(", "").Replace(")", "").Replace("-", "");

		if ((newTelefone.Length != 11)&&(newTelefone.Length != 10)){
			return false;
		}
		char [] verificacao = newTelefone.ToCharArray();
		
		for(int i= 0; i<newTelefone.Length;i++){
			switch (verificacao[i]){
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9': {break;}
				default: {condicao++; break;}
			}		
		}
		if (condicao ==0){
			telefone= newTelefone;
			resposta = true;
		}else{
			resposta = false;
		}
		return resposta;
	}
	public string GetTelefoneCliente(){
		return telefone;
	}
	public void SetEndereco(){
		string rua, bairro, cidade, numero;

		Console.WriteLine("Informe sua cidade: ");
		cidade = Console.ReadLine();
		Console.WriteLine("Informe seu bairro: ");
		bairro = Console.ReadLine();
		Console.WriteLine("Informe sua rua: ");
		rua = Console.ReadLine();
		Console.WriteLine("Informe seu numero: ");
		numero = Console.ReadLine();

		endereco = (rua+", "+numero+" - "+bairro+"/ "+cidade);
	}
	 public string GetEndereco(){
		return endereco;
	}
	public void SetObservacao(string novaObservacao){
		observacao = novaObservacao;
	}
	public string GetObservacao(){
		return observacao;
	}
}