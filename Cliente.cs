class Cliente {

  // Dados que pode-se pedir para o cliente
  // Strings
  string nome      ; 
  string endereco  ; 
  string email     ; 
  string nascimento; 
  string profissao ; 

  // Inteiros
  int codigo  ; 
  int telefone; 
  int cpf     ; 
  // Chars
  char sexo;// H ou M
  ////////GETTERS E SETTERS
  // STRINGS
  public string Nome       { get { return nome; }       set{ nome = value; } }
  public string Endereco   { get { return endereco; }   set{ endereco = value; } }
  public string Email      { get { return email; }      set{ email = value; } }
  public string Nascimento { get { return nascimento; } set{ nascimento = value; } } 
  public string Profissao  { get { return profissao; }  set{ profissao = value; } }
  // INTEIROS
  public int Codigo     { get { return codigo; }   set{ codigo = value; } }
  public int Telefone   { get { return telefone; } set{ telefone = value; } }
  public int Cpf        { get { return cpf; }      set{ cpf = value; } }
  // CHAR
  char Sexo         { get { return sexo; } set{ sexo = value; } } 

  

}