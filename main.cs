using System;

class Cliente(){
	protected string nomeCliente= " ";
	protected string telefone= " ";
	protected string endereco= " ";
	protected int codigoCliente=0;
	protected string observacao= " ";

	codigoCliente++; //Calculo de codigo do cliente automatico.
	
	public void SetNomeCliente(string){
		//analisar dados passados se é válido!
	}
	public string GetNomeCliente(){
		return nomeCliente;
	}
	public int GetCodigoCliente(){
		return codigoCliente;
	}
	public void SetTelefoneCliente(string){
		//analisar dados passados se é válido!
	}
	public string GetTelefoneCliente(){
		return telefone;
	}
	public void SetEndereco(string rua, int numero, string bairro, string cidade){
		//analisar dados passados se é válido!
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
class PessoaJuridica:Cliente(){
	private string cnpj= " ";
	private string razaoSocial= " "; 

	public void SetCnpj(string novoCnpj){
		//analisar dados passados se é válido!
	}
	public string GetCnpj(){
		return cnpj;
	}
	public void SetRazaoSocial(string razao){
		//analisar dados passados se é válido!
	}
	public string GetRazaoSocial(){
		return razaoSocial
	}
}
class PessoaFisica:Cliente(){
	private string cpf= " ";
	
	public void SetCpf(string novoCpf){
		//analisar dados passados se é válido!
	}
	public string GetCpf(){
		return cpf;
	}
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}