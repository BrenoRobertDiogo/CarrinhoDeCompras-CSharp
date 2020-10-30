using System;
using System.Collections.Generic;
using System.Linq;

class CarrinhoDeCompra {

  List<Produto> listaProdutos = new List<Produto>();
  public List<Produto> ListaProdutos { get{ return listaProdutos; } set{ listaProdutos = value; } }

  List<int> quantidadeProduto;
  public List<int> QuantidadeProduto { get{ return QuantidadeProduto; } set{ 
      QuantidadeProduto = value; 
    } }

  
  public void mostraResultadoFinal( List<Produto> listaProdutos ) {
    for(int i=0; i<listaProdutos.Count; i++) {
      Console.WriteLine($@"
Produto: {listaProdutos[i].Descricao}
Quantidade: {listaProdutos[i].Quantidade}
==========================================
      ");

    }
  }

  public int conta(List<Produto> produtoAtual) {
    // Vai pegar os itens duplicados
    int quantidade = produtoAtual
        .GroupBy(valor => new { valor.Id })
        .Where(x => x.Count() > 1)
        .Sum(x => x.Count());
    return quantidade;
  }
  

}