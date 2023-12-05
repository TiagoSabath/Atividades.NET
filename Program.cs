//---------------------Atividade 1----------------------------
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string registroEmail, registroNome, registroSenha;

// Obtém o email e nome do usuário a partir da entrada do console
    Console.Write("Digite o email de cadastro: ");
    registroEmail = Console.ReadLine();
    Console.Write("Digite o Nome de cadastro: ");
    registroNome = Console.ReadLine();
    Console.Write("Digite a senha de cadastro: ");
    registroSenha = Console.ReadLine();

// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");
    }
}
//---------------------Atividade 2----------------------------


{
    static void Main()
    {

// TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
     string titulo, descricao, dataVencimento;
          
 // Obtém o titulo e a descricao a partir da entrada do console  
    titulo = Console.ReadLine();
    descricao = Console.ReadLine();

// TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
     if(descricao.Length > 50)
        Console.WriteLine("Descricao ultrapassa limite de caracteres.");
      else{

 // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
    dataVencimento = Console.ReadLine();

 // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
          Console.WriteLine($"{descricao} ate {dataVencimento}");
        }
    }
}
//---------------------Atividade 3----------------------------