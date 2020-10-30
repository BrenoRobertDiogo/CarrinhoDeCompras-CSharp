class Produto {
  // Definindo atributos
  string descricao;
  double preco;
  int id, quantidade;
  
  public string Descricao { get { return descricao; }  set{ descricao = value; } }
  public double Preco { get { return preco; }  set{ preco = value; } }
  public int    Id { get { return id; }  set{ id = value; } }
  public int    Quantidade { get { return quantidade; }  set{ quantidade = value; } }
}