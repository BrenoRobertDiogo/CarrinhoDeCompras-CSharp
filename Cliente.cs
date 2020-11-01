using System;
class Cliente {

  // Dados que pode-se pedir para o cliente
  // Strings
    string nome      ; 
    string endereco  ; 
    string email     ; 
    string nascimento; 
    string profissao ; 
  // Inteiros
    int telefone; 
    string cpf     ; 
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
    public int Telefone   { get { return telefone; }      set{ telefone = value; } }
    public string Cpf     { get {   return cpf;    }      set{ cpf = value; } }
  // CHAR
    public char Sexo { get { return sexo; } set{ sexo = value; } } 

  public static void analisaSexo(char input){
    switch (input){
        case('M'):
          Console.Write($"👩‍🦰  Produto que a senhorita deseja escolher-> ");
          break;
        case('H'):
          Console.Write($"🧑  Produto que o senhorio deseja escolher-> ");
          break;
        default:
          Console.Write($"👨‍🦲  Produto você deseja escolher-> ");
          break;
      }
  }
  
  

}