using System;
using System.Globalization;
using System.Collections.Generic;

class MainClass {
  static Random randNum = new Random();
  static string comando;
  static List<string> comandos;
  static Loja             Interacao    = new Loja();
  public static void Main (  ) {
    Cliente          pessoa       = new Cliente();   
    
    CarrinhoDeCompra carrinho     = new CarrinhoDeCompra();
    List<Produto>    listaProduto = new List<Produto>();
    Interacao.mostraTabela(  );
    // Começa a pedir os dados
      
      Console.Write("B-ON: Digite seu nome-> ");
      pessoa.Nome       = Console.ReadLine();
      /*
      Console.Write("B-ON: Digite seu endereco-> ");
      pessoa.Endereco   = Console.ReadLine();

      Console.Write("B-ON: Digite seu email-> ");
      pessoa.Email      = Console.ReadLine();

      Console.Write("B-ON: Digite sua data de nascimento-> ");
      pessoa.Nascimento = Console.ReadLine();

      Console.Write("B-ON: Digite sua profissão-> ");
      pessoa.Profissao  = Console.ReadLine();

      Console.Write("B-ON: Digite seu telefone(Apenas número)-> ");
      pessoa.Telefone   = int.Parse(Console.ReadLine());

      Console.Write("B-ON: Digite seu CPF-> ");
      pessoa.Cpf        = Console.ReadLine();
      */
      Console.Write("B-ON: Digite seu sexo(M ou H)-> ");
      pessoa.Sexo       = char.Parse(Console.ReadLine());
    // Terminou de pedir dados
    string chamar = "";
    // Se usar ToLower() da erro
    if( pessoa.Sexo=='H' || pessoa.Sexo=='h') {
      chamar = "o";
    }else{
      chamar = "a";
    }
    int escolhaProduto, escolhaQuantidade, quantidade = 0;

    comandos = new List<string>{ "sair-> Sai do programa", "produtos-> Mostra os produtos", "continuar-> Continua comprando", "apagar-> Você escolhe a quantidade e qual produto deseja excluir" };
    
    Produto novoProduto = new Produto();
    double precoFinal = 0;
    bool condicao = false;
    do {
      
      Console.Write($"B-ON: Produto que {chamar} senhorit{chamar} deseja escolher-> ");
      escolhaProduto = int.Parse(Console.ReadLine());

      Console.Write($"B-ON: Ok {pessoa.Nome}, agora me diga a quantidade-> ");
      escolhaQuantidade = int.Parse(Console.ReadLine());

      Console.WriteLine($"{escolhaQuantidade} pedidos adicionados com sucesso");

      Console.WriteLine("Antes do erro");
      condicao = escolhaQuantidade > Interacao.Quantidade[escolhaProduto];
      int valorConta = 0;
      if( !condicao ) {
        
        for ( int i = 0; i < escolhaQuantidade; i++ ) {
          novoProduto.Descricao  = Interacao.Descricao[escolhaProduto];
          // Subtração
          Interacao.Quantidade[escolhaProduto] -= 1;
          
          
          novoProduto.Quantidade = Interacao.Quantidade[escolhaProduto];

          novoProduto.Preco      = Interacao.Preco[escolhaProduto];
          novoProduto.Id         = escolhaProduto;

          // Adicionando no carrinho
          listaProduto.Add( novoProduto );
          // Console.WriteLine("Tamanho listaProduto: "+listaProduto.Id);
          precoFinal += novoProduto.Preco;

          carrinho.ListaProdutos.Add( novoProduto );
          valorConta++;
        }
        // TODO continuar
        
        Console.WriteLine(carrinho.ListaProdutos);
    // Dando comandos pro B-ON
    Console.Write(@"B-ON: Me dê um comando (caso não lembre dos comandos, digite 'comandos') :)
-> ");
    comando = Console.ReadLine();
    enviaComando();
    
  } else{
    Console.WriteLine("Quantidade pedida maior do que no estoque...");
    Console.Write(@"B-ON: Me dê um comando (caso não lembre dos comandos, digite 'comandos') :)
-> ");
    comando = Console.ReadLine();
    enviaComando();
  }

  } while( comando.ToLower() != "sair" );
  if(!condicao) {
    int aleatorio = randNum.Next(100000000, 999999999);
  Console.WriteLine($@"DADOS DO SEU PEDIDO
Você pediu {carrinho.ListaProdutos.Count} produtos
O preço final é: {precoFinal}R$
Código para pagar: {aleatorio}");
  }
  }
  
  public static void enviaComando() {
    switch( comando.ToLower() ) {
        case ("comandos"):
          for(int i=0; i<comandos.Count; i++) {
            Console.WriteLine(comandos[i]);
          }
          break;
        case ("sair"):
          Console.WriteLine("Pressione qualquer tecla para sair...");
          Console.ReadKey( );
          Console.WriteLine("");
          break;
        case ("produtos"):
          Interacao.mostraTabela();
          break;
        case ("continuar"):
          Console.WriteLine("B-ON: Então vamos lá ;)");
          break;
        default:
          Console.WriteLine("B-ON: Vamos continuar então...");
          break;
      }
  }
}