using System;
using System.Globalization;
using System.Collections.Generic;

class MainClass {
  
  static Random randNum = new Random();
  static string comando;
  static List<string> comandos;
  static Loja Interacao = new Loja();
  public static void Main (  ) {
    Console.Clear(); // Limpa o terminal
    // Instanciando algumas variáveis
    Cliente          pessoa         = new Cliente();   
    CarrinhoDeCompra carrinho       = new CarrinhoDeCompra();
    List<Produto>    listaProduto   = new List<Produto>();
    Produto novoProduto = new Produto();
    double precoFinal = 0;
    bool condicao = false;
    int escolhaProduto, escolhaQuantidade;
    Loja.mostraTabela(  );
    Console.WriteLine
(@"||================Loja Future Now======================||
OBS.: Por medidas de segurança, entre com máscaras 😷
O B-ON irá te acompanhar e te ajudará a comprar seus produtos 🤜
");
    // Começa a pedir os dados
    Interacao.mostraAmarelo("🤖 B-ON:🤖 ");
    Console.Write("Digite seu nome-> ");
    pessoa.Nome       = Console.ReadLine();
    Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
    Console.Write("Digite seu telefone(Apenas número)-> ");
    pessoa.Telefone   = int.Parse(Console.ReadLine());
    Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
    Console.Write("Digite seu sexo(M / H / +)-> ");
    pessoa.Sexo       = char.Parse(Console.ReadLine());
      
    // Terminou de pedir dados
    // Se usar ToLower() em char da erro

    

    comandos = new List<string>{ "😢 sair😢 -> Sai do programa",
                                 "🔎  produtos🔍 -> Mostra os produtos",
                                 "🔁  continuar🔁 -> Continua comprando"
                                };
    
    
    // Loop onde vai pedir os dados
    do {
      // Vai pedir o produto de acordo com o sexo
      Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
      Cliente.analisaSexo(pessoa.Sexo);
      escolhaProduto = int.Parse(Console.ReadLine());
      // Agora pede a quantidade
      Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
      Console.Write($"Ok {pessoa.Nome}, agora me diga a quantidade-> ");
      escolhaQuantidade = int.Parse(Console.ReadLine());
      Console.WriteLine($"➕ {escolhaQuantidade} pedidos adicionados com sucesso ➕");
      // Condição guardada em variável para não ocupar muito espaço
      condicao = escolhaQuantidade > Interacao.Quantidade[escolhaProduto];
      int valorConta = 0;
      if( !condicao ) {
        
        for ( int i = 0; i < escolhaQuantidade; i++ ) {
          novoProduto.Descricao  = Interacao.Descricao[escolhaProduto];
          // Subtração
          Interacao.Quantidade[escolhaProduto] -= 1;
          // Adicionando a um novo produto
          novoProduto.Quantidade = Interacao.Quantidade[escolhaProduto];
          novoProduto.Preco      = Interacao.Preco[escolhaProduto];
          novoProduto.Id         = escolhaProduto;
          // Adicionando novoProduto no carrinho
          listaProduto.Add( novoProduto );
          // Soma o preço
          precoFinal += novoProduto.Preco;
          carrinho.ListaProdutos.Add( novoProduto );
          valorConta++;
        }

    // Dando comando
    Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
    Console.Write("Caso queira, me dê um comando (caso não lembre dos comandos, digite ");
    Interacao.mostraVermelho("'comandos'");
    Console.Write(" e depois do próximo produto pode escrever :)\n->");
    comando = Console.ReadLine();

  } else{
    Interacao.mostraVermelho("Quantidade pedida maior do que no estoque...\n");
    Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
    Console.Write(@"Me dê um comando (caso não lembre dos comandos, digite 'comandos') :)
-> ");
    comando = Console.ReadLine();
    
  }
  Console.Clear();
  enviaComando();
  } while( comando.ToLower() != "sair" );
  if(!condicao) {
    int aleatorio = randNum.Next(100000000, 999999999);
  Console.WriteLine($@"==========DADOS DO SEU PEDIDO==========
       Produtos   ~   Preço Final
Total:      {carrinho.ListaProdutos.Count}        | {precoFinal}R$
Código para pagar: {aleatorio}

OBS.: Caso ocorra algum problema e precisarmos ligá-lo, ligaremos para {pessoa.Telefone}");
  }
  }
  // Vai analisar a palavra que a pessoa digitou e vai mostrar o resultado
  public static void enviaComando() {
    switch( comando.ToLower() ) {
        case ("comandos"):
          for(int i=0; i<comandos.Count; i++) {
            Console.WriteLine(comandos[i]);
          }
          Console.Write(" Depois do próximo produto pode escrever o comando (caso só queira sair coloque a quantidade zero mesmo :)\n->");
          Console.WriteLine();
          break;
        case ("sair"):
          Console.WriteLine("Pressione qualquer tecla para sair...");
          Console.ReadKey( );
          Console.WriteLine("");
          break;
        case ("produtos"):
          Loja.mostraTabela();
          break;
        case ("continuar"):
        Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
          Console.WriteLine("Então vamos lá ;)");
          break;
        default:
        Interacao.mostraAmarelo("🤖 B-ON:🤖  ");
          Console.WriteLine("Vamos continuar então...");
          break;
      }
  }
}