using System;
using System.IO;
using System.Text;

class Orcamento{

	public string  nome, razaoSocial, cpf, cnpj, telefone, endereco, tamanhoHd, tamanhoFonte, modeloDvr, modeloCentral;
	public string cliente, servico, qtdPontos, qtdBnc, qtdP4, qtdCaixaProtecao, qtdCaboRede, qtdCabo, qtdBateria, qtdSirene;
	public int tipoPessoa, tipoServico;

	public void GerarOrcamento(int tipoPessoa){

		if (tipoPessoa==1){
			FileStream dados1 = new FileStream("OrdemServico1.txt", FileMode.Open, FileAccess.Read);
			StreamReader dados1ler = new StreamReader(dados1,Encoding.UTF8);

			 cliente = dados1ler.ReadLine();
			 cpf = dados1ler.ReadLine();
			 nome = dados1ler.ReadLine();
			 razaoSocial = dados1ler.ReadLine(); 
			 telefone = dados1ler.ReadLine();
			 endereco = dados1ler.ReadLine();
			 qtdPontos = dados1ler.ReadLine();
			 servico = dados1ler.ReadLine();
			 tipoServico = Convert.ToInt32(servico);
			
			if (tipoServico ==1){
				qtdBnc = dados1ler.ReadLine();
				qtdP4 = dados1ler.ReadLine();
				qtdCaixaProtecao = dados1ler.ReadLine();	
				qtdCaboRede = dados1ler.ReadLine();
				qtdCabo = dados1ler.ReadLine();
				tamanhoHd = dados1ler.ReadLine();
				modeloDvr = dados1ler.ReadLine();
				tamanhoFonte = dados1ler.ReadLine();
			}else{
				qtdSirene = dados1ler.ReadLine();
				qtdBateria = dados1ler.ReadLine();
				qtdCaboRede = dados1ler.ReadLine();
				qtdCabo = dados1ler.ReadLine();
				modeloCentral = dados1ler.ReadLine();
			}
			dados1ler.Close();
			dados1.Close();
		}else{
			FileStream dados2 = new FileStream("OrdemServico2.txt", FileMode.Open, FileAccess.Read);
			StreamReader dados2ler = new StreamReader(dados2,Encoding.UTF8);

			cliente = dados2ler.ReadLine();
			cnpj = dados2ler.ReadLine();
			nome = dados2ler.ReadLine();
			razaoSocial = dados2ler.ReadLine(); 
			telefone = dados2ler.ReadLine();
			endereco = dados2ler.ReadLine();
			qtdPontos = dados2ler.ReadLine();
			servico = dados2ler.ReadLine();
			tipoServico = Convert.ToInt32(servico);
		
			if (tipoServico ==1){
				qtdBnc = dados2ler.ReadLine();
				qtdP4 = dados2ler.ReadLine();
				qtdCaixaProtecao = dados2ler.ReadLine();	
				qtdCaboRede = dados2ler.ReadLine();
				qtdCabo = dados2ler.ReadLine();
				tamanhoHd = dados2ler.ReadLine();
				modeloDvr = dados2ler.ReadLine();
				tamanhoFonte = dados2ler.ReadLine();
			}else{
				qtdSirene = dados2ler.ReadLine();
				qtdBateria = dados2ler.ReadLine();
				qtdCaboRede = dados2ler.ReadLine();
				qtdCabo = dados2ler.ReadLine();
				modeloCentral = dados2ler.ReadLine();
			}
			dados2ler.Close();
			dados2.Close();
		}

		Console.WriteLine("***ORÇAMENTO SOLICITADO***");
		Console.WriteLine("");
		Console.WriteLine("Nome: "+nome);
		if (tipoPessoa==1){
			Console.WriteLine("CPF: "+cpf);
		}else{
			Console.WriteLine("Razão Social: "+razaoSocial);
			Console.WriteLine("CNPJ: "+cnpj);
		}
		Console.WriteLine("Telefone: "+telefone);
		Console.WriteLine("Endereço: "+endereco);
		
		Console.WriteLine("Produtos necessários:");
	


	}	
}