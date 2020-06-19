using System;
using System.IO;
using System.Text;

class MainClass {

  public static void Main (string[] args) {
		
		int entrada =0, submenu =0, qtdPontos=0;
		FileStream dados1 = new FileStream("OrdemServico1.txt", FileMode.Open, FileAccess.Write);//Arquivo pessoa Fisica
		StreamWriter dados1escrever = new StreamWriter(dados1,Encoding.UTF8);

		FileStream dados2 = new FileStream("OrdemServico2.txt", FileMode.Open, FileAccess.Write);//Arquivo Pessoa Juridica
		StreamWriter dados2escrever = new StreamWriter(dados2,Encoding.UTF8);

		Console.Clear();

		Console.WriteLine("\n*****Orçamento de Manutenção/ Instalação de Sistema de Segurança*****");
		Console.WriteLine("***Investir em Segurança, é investir em qualidade de vida... Parabéns!!!***");
		Console.WriteLine("\n**Dica: duvide sempre da qualidade do preço baixo, a dor de cabeça irá lhe acompanhar!!!**");

		while (entrada==0){
			Console.WriteLine("\nPreciso saber, quem é você? 1- Pessoa Fisica ou 2- Pessoa Juridica ");
			entrada = Convert.ToInt32(Console.ReadLine());

			switch (entrada){
				case 1:
					PessoaFisica orcamento1 = new PessoaFisica();
					Console.WriteLine("Agora preciso que me informe seu CPF:");
					while (!orcamento1.SetCpf()){
						Console.WriteLine("O valor informado não é válido, informe os 11 digitos:");
					}
					while (!orcamento1.SetNomeCliente()){
						Console.WriteLine("O nome informado é inválido, não use numeros. Digite novamente: ");
					}
					while (!orcamento1.SetTelefoneCliente()){
						Console.WriteLine("O telefone informado é inválido, não use letras. Digite novamente: ");
					}
					orcamento1.SetEndereco();
					Console.WriteLine("Informe o tipo de serviço que deseja? 1- Instalação de Câmeras ou 2- Instalação de Alarme.");
					submenu = Convert.ToInt32(Console.ReadLine());
					if(submenu==1){
						while((qtdPontos==0)||(qtdPontos>32)){
							Console.WriteLine("Informe quantos pontos de Câmeras quer instalar? Não deve ser superior a 32, neste caso contate o consultor!");
							qtdPontos = Convert.ToInt32(Console.ReadLine());
						}
						Camera servico1 = new Camera(qtdPontos);
						servico1.SetTipoServico(submenu);
						servico1.SetQtdPontos(qtdPontos);
						
						dados1escrever.WriteLine(entrada);
						dados1escrever.WriteLine(orcamento1.GetCpf());
						dados1escrever.WriteLine(orcamento1.GetNomeCliente());
						dados1escrever.WriteLine("");//Espaço Razão Social 
						dados1escrever.WriteLine(orcamento1.GetTelefoneCliente());
						dados1escrever.WriteLine(orcamento1.GetEndereco());
						dados1escrever.WriteLine(servico1.GetTipoServico());
						dados1escrever.WriteLine(servico1.GetQtdPontos());
						dados1escrever.WriteLine(servico1.GetQtdBnc());
						dados1escrever.WriteLine(servico1.GetQtdP4());
						dados1escrever.WriteLine(servico1.GetQtdCaixaProtecao());
						dados1escrever.WriteLine(servico1.GetQtdCaboRede());
						dados1escrever.WriteLine(servico1.GetQtdCaboCoaxial());
						dados1escrever.WriteLine(servico1.GetTamanhoHd());
						dados1escrever.WriteLine(servico1.GetModeloDvr());
						dados1escrever.WriteLine(servico1.GetTamanhoFonte());
						dados1escrever.Close();
						dados1.Close();

					}else if(submenu==2){
							while((qtdPontos==0)||(qtdPontos>18)){
							Console.WriteLine("Informe quantos pontos de Sensores quer instalar? Não deve ser superior a 18, neste caso contate o consultor!");
							qtdPontos = Convert.ToInt32(Console.ReadLine());
						}
						Alarme servico1 = new Alarme(qtdPontos);
						servico1.SetTipoServico(submenu);
						servico1.SetQtdPontos(qtdPontos);

						dados1escrever.WriteLine(entrada);
						dados1escrever.WriteLine(orcamento1.GetCpf());
						dados1escrever.WriteLine(orcamento1.GetNomeCliente());
						dados1escrever.WriteLine("");//Espaço Razão Social 
						dados1escrever.WriteLine(orcamento1.GetTelefoneCliente());
						dados1escrever.WriteLine(orcamento1.GetEndereco());
						dados1escrever.WriteLine(servico1.GetTipoServico());
						dados1escrever.WriteLine(servico1.GetQtdPontos());
						dados1escrever.WriteLine(servico1.GetQtdSirene());
						dados1escrever.WriteLine(servico1.GetQtdBateria());
						dados1escrever.WriteLine(servico1.GetQtdCaboRede());
						dados1escrever.WriteLine(servico1.GetQtdCaboAlarme());
						dados1escrever.WriteLine(servico1.GetModeloCentral());
						dados1escrever.Close();
						dados1.Close();
					}
				break;
				case 2:
					PessoaJuridica orcamento2 = new PessoaJuridica();
					Console.WriteLine("Agora preciso que me informe seu CNPJ:");
					while (!orcamento2.SetCnpj()){
						Console.WriteLine("O valor informado não é válido, informe os 14 digitos:");
					}
					while (!orcamento2.SetNomeCliente()){
						Console.WriteLine("O nome informado é inválido, não use numeros. Digite novamente: ");
					}
					while (!orcamento2.SetTelefoneCliente()){
						Console.WriteLine("O telefone informado é inválido, não use letras. Digite novamente: ");
					}
					orcamento2.SetEndereco();
					Console.WriteLine("Informe o tipo de serviço que deseja? 1- Instalação de Câmeras ou 2- Instalação de Alarme.");
					submenu = Convert.ToInt32(Console.ReadLine());
					if(submenu==1){
						while((qtdPontos==0)||(qtdPontos>32)){
							Console.WriteLine("Informe quantos pontos de Câmeras quer instalar? Não deve ser superior a 32, neste caso contate o consultor! ");
							qtdPontos = Convert.ToInt32(Console.ReadLine());
						}
						Camera servico2 = new Camera(qtdPontos);
						servico2.SetTipoServico(submenu);
						servico2.SetQtdPontos(qtdPontos);

						dados2escrever.WriteLine(entrada);
						dados2escrever.WriteLine(orcamento2.GetCnpj());
						dados2escrever.WriteLine(orcamento2.GetNomeCliente());
						dados2escrever.WriteLine(orcamento2.GetRazaoSocial());
						dados2escrever.WriteLine(orcamento2.GetTelefoneCliente());
						dados2escrever.WriteLine(orcamento2.GetEndereco());
						dados2escrever.WriteLine(servico2.GetTipoServico());
						dados2escrever.WriteLine(servico2.GetQtdPontos());
						dados2escrever.WriteLine(servico2.GetQtdBnc());
						dados2escrever.WriteLine(servico2.GetQtdP4());
						dados2escrever.WriteLine(servico2.GetQtdCaixaProtecao());
						dados2escrever.WriteLine(servico2.GetQtdCaboRede());
						dados2escrever.WriteLine(servico2.GetQtdCaboCoaxial());
						dados2escrever.WriteLine(servico2.GetTamanhoHd());
						dados2escrever.WriteLine(servico2.GetModeloDvr());
						dados2escrever.WriteLine(servico2.GetTamanhoFonte());
						dados2escrever.Close();
						dados2.Close();
						
					}else if(submenu==2){

						while((qtdPontos==0)||(qtdPontos>18)){
							Console.WriteLine("Informe quantos pontos de Sensores quer instalar? Não deve ser superior a 18, neste caso contate o consultor! ");
							qtdPontos = Convert.ToInt32(Console.ReadLine());
						}
						Alarme servico2 = new Alarme(qtdPontos);
						servico2.SetTipoServico(submenu);
						servico2.SetQtdPontos(qtdPontos);

						dados2escrever.WriteLine(entrada);
						dados2escrever.WriteLine(orcamento2.GetCnpj());
						dados2escrever.WriteLine(orcamento2.GetNomeCliente());
						dados2escrever.WriteLine(orcamento2.GetRazaoSocial());
						dados2escrever.WriteLine(orcamento2.GetTelefoneCliente());
						dados2escrever.WriteLine(orcamento2.GetEndereco());
						dados2escrever.WriteLine(servico2.GetTipoServico());
						dados2escrever.WriteLine(servico2.GetQtdPontos());
						dados2escrever.WriteLine(servico2.GetQtdSirene());
						dados2escrever.WriteLine(servico2.GetQtdBateria());
						dados2escrever.WriteLine(servico2.GetQtdCaboRede());
						dados2escrever.WriteLine(servico2.GetQtdCaboAlarme());
						dados2escrever.WriteLine(servico2.GetModeloCentral());
						dados2escrever.Close();
						dados2.Close();
					}
				break;
				default:
					entrada = 0;
				break;
			}
		}
		Console.WriteLine("Obrigado, já temos a informação necessária. Aguarde um momento para ver o valor do serviço...Tecle Enter para ver!!! ");
		Console.ReadKey();

		Orcamento meuOrcamento = new Orcamento();
		meuOrcamento.GerarOrcamento(entrada);

		Console.WriteLine ("\nValor correspondente apenas a mão de obra, quer proseguir para contato e orçamento completo?");
		
		entrada = 0;
		while((entrada!=1)&&(entrada!=2)){
			Console.WriteLine ("\n1- Sim, preciso muito. Ou 2- Não, ficou muito caro.");
			entrada = Convert.ToInt32(Console.ReadLine());
		}
		if(entrada==1){

			Console.WriteLine("***Parabéns, vamos entrar em contato... Vamos preparar um projeto especial para você!!!");
			
		}else{

			throw new ArgumentException("Cliente preocupado com valor e não com Segurança!!!");
		}
  }
}
	