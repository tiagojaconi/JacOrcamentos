class Camera:Servicos{
	private int qtdBnc = 0;
	private int qtdP4 = 0;
	private int qtdCaixaProtecao = 0;
	private float qtdCaboRede = 0;
	private float qtdCaboCoaxial = 0; 
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
		}
		qtdBnc = (pontos*2);
		qtdP4 = pontos;
		qtdCaixaProtecao = pontos;
		qtdCaboRede = (pontos*2);
		qtdCaboCoaxial = (pontos*50); 
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
	public float GetQtdCaboRede(){
		return qtdCaboRede;
	}
	public void SetQtdCaboCoaxial(int coaxial){
		qtdCaboCoaxial= coaxial;
	}
	public float GetQtdCaboCoaxial(){
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