class Cliente {

  // Dados que pode-se pedir para o cliente
  // Strings
  string nome       { get { return nome; } set{ nome = value; } }
  string endereco   { get { return endereco; }  set{ endereco = value; } }
  string email      { get { return email; } set{ email = value; } }
  string nascimento { get { return nascimento; } set{ nascimento = value; } }
  string profissao  { get { return profissao; } set{ profissao = value; } }
  // Inteiros
  int codigo        { get { return codigo; } set{ codigo = value; } }
  int telefone      { get { return telefone; } set{ telefone = value; } }
  int cpf           { get { return cpf; } set{ cpf = value; } }
  // Chars
  char sexo         { get { return sexo; } set{ sexo = value; } } 
  // H ou M
  


}