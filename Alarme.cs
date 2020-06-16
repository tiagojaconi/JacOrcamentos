class Alarme:Servicos{
	private int qtdSensor = 0;
	private int qtdSirene = 0;
	private int qtdBateria = 0;
	private float qtdCaboRede = 0;
	private float qtdCaboAlarme = 0; 
	private string modeloCentral = " ";
	

	public Alarme(int pontos){
		
		qtdSensor = pontos;
		qtdSirene = 2;
		qtdBateria = 1;
	  qtdCaboRede = 15;
	  qtdCaboAlarme = (pontos*50); 
	  modeloCentral = "Amt 2018 EG"; 
	}
	public void SetQtdSensor(int qtdPontos){
		qtdSensor= qtdPontos;
	}
	public int GetQtdSensor(){
		return qtdSensor;
	}
	public int GetQtdSirene(){
		return qtdSirene;
	}
	public int GetQtdBateria(){
		return qtdBateria;
	}
	public float GetQtdCaboRede(){
		return qtdCaboRede;
	}
	public float GetQtdCaboAlarme(){
		return qtdCaboAlarme;
	}
	public string GetModeloCentral(){
		return modeloCentral;
	}
}