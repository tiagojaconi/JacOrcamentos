using System;

class Excecao : Exception
{
  public Excecao(string mensagem):base(mensagem)
  {
    //Construtor que chama o construtor da classe genérica
  }
}