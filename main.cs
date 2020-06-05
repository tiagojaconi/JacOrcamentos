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
class PessoaJuridica:Cliente{
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
		return razaoSocial;
	}
}
class PessoaFisica:Cliente{
	private string cpf= " ";
	
	public bool SetCpf(){
    //analisar dados passados se é válido!
		return true;
	}
	public string GetCpf(){
		return cpf;
	}
}
class Servicos{
	protected string tipoServico = " ";
	protected int qtdPontos = 0;
	protected float valorServico = 0.0f;

	public void SetTipoServico(int tipo){
		//validar dados de entrada.
	}
	public string GetTipoServico(){
		return tipoServico;
	}
	public void SetQtdPontos(int pontos){
		//validar dados de entrada.
	}
	public int GetQtdPontos(){
		return qtdPontos;
	}
}
class Camera:Servicos{
	private int qtdBnc = 0;
	private int qtdP4 = 0;
	private int qtdCaixaProtecao = 0;
	private int qtdCaboRede = 0;
	private int qtdCaboCoaxial = 0; 
	private string tamanhoHd = " ";
	private string modeloDvr = " ";
	private string tamanhoFonte = " ";

	public Camera(int pontos){
		int referencia =0;
		if(pontos<=4){
			referencia =1;
		}else if(pontos<=8){
			referencia=2;
		}else if (pontos<=12){
			referencia=3;
		}else if(referencia<=32){
			referencia=4;
		}else{
			referencia=0;
		}
		switch(referencia){
			case 1:
				tamanhoHd = "1 TB ";
				modeloDvr = "MHDX 1104 ";
				tamanhoFonte = "5 A";
			break;
			case 2:
				tamanhoHd = "1 TB ";
				modeloDvr = "MHDX 1108 ";
				tamanhoFonte = "10 A";
			break;
			case 3:
				tamanhoHd = "2 TB ";
				modeloDvr = "MHDX 1116 ";
				tamanhoFonte = "15 A";
			break;
			case 4:
				tamanhoHd = "4 TB ";
				modeloDvr = "MHDX 1132 ";
				tamanhoFonte = "30 A";
			break;
			default:
				//O codigo não chegará aqui se o valor informado ultrapassar 32 cameras. 
			break;
			qtdBnc = (pontos*2);
			qtdP4 = pontos;
			qtdCaixaProtecao = pontos;
			qtdCaboRede = (pontos*2);
			qtdCaboCoaxial = (pontos*50); 
		}
	}
	public void SetQtdBnc(int bnc){
		qtdBnc= bnc;
	}
	public int GetQtdBnc(){
		return qtdBnc;
	}
		public void SetQtdP4(int p4){
		qtdP4= p4;
	}
	public int GetQtdP4(){
		return qtdP4;
	}
		public void SetQtdCaixaProtecao(int caixa){
		qtdCaixaProtecao= caixa;
	}
	public int GetQtdCaixaProtecao(){
		return qtdCaixaProtecao;
	}
		public void SetQtdcaboRede(int rede){
		qtdCaboRede= rede;
	}
	public int GetQtdcaboRede(){
		return qtdCaboRede;
	}
	public void SetQtdcaboCoaxial(int coaxial){
		qtdCaboCoaxial= coaxial;
	}
	public int GetQtdcaboCoaxial(){
		return qtdCaboCoaxial;
	}
	public void SetTamanhoHd(string hd){
		tamanhoHd= hd;
	}
	public string GetTamanhoHd(){
		return tamanhoHd;
	}
	public void SetTamanhoFonte(string fonte){
		tamanhoFonte= fonte;
	}
	public string GetTamanhoFonte(){
		return tamanhoFonte;
	}
	public void SetModeloDvr(string dvr){
		modeloDvr= dvr;
	}
	public string GetModeloDvr(){
		return modeloDvr;
	}
}
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
					while (orcamento1.SetCpf()){
						Console.WriteLine("O valor informado não é válido, informe os 11 digitos:");
					}
				break;
					case 2: 
						PessoaJuridica orcamento2 = new PessoaJuridica();
				break;
				default:
					entrada = 0;
				break;
			}
		}
  }
}