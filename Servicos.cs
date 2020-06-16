class Servicos{
	protected int tipoServico = 0;
	protected int qtdPontos = 0;
	protected float valorServico = 0.0f;

	public void SetTipoServico(int tipo){
		tipoServico = tipo;
	}
	public int GetTipoServico(){
		return tipoServico;
	}
	public void SetQtdPontos(int pontos){
		qtdPontos = pontos;
	}
	public int GetQtdPontos(){
		return qtdPontos;
	}
}