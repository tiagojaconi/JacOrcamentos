class Cliente{
	protected string nomeCliente= " ";
	protected string telefone= " ";
	protected string endereco= " ";
	protected int codigoCliente= 0;
	protected string observacao= " ";

	public Cliente(){
		codigoCliente++; //Calculo de codigo do cliente automatico.
	}
	public void SetNomeCliente(string nome){
		//analisar dados passados se é válido!
	}
	public string GetNomeCliente(){
		return nomeCliente;
	}
	public int GetCodigoCliente(){
		return codigoCliente;
	}
	public void SetTelefoneCliente(string telefone){
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