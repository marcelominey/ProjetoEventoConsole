using System;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            
            do{
                //Menu de seoleção
                Console.WriteLine("Opções");
                Console.WriteLine("1 - Teatro");
                Console.WriteLine("2 - Show");
                Console.WriteLine("3 - Cimena");
                Console.WriteLine();
                Console.WriteLine("9 - Sair");
                Console.WriteLine();
                Console.Write("Digite a opção desejada:");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        
                        break;

                    case "2":
                        MenuShow();
                        break;

                    case "3":

                        break;

                    case "9":

                        break;
                    
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }while(opcao != "9");
        }

        static void MenuShow(){

            string opcao = "";

            do{
                //Menu de seoleção
                Console.WriteLine("Opções");
                Console.WriteLine("1 - Cadastrar Show");
                Console.WriteLine("2 - Pesquisar Show por DATA");
                Console.WriteLine("3 - Pesquisar Show por TÍTULO");
                Console.WriteLine();
                Console.WriteLine("9 - Sair");
                Console.WriteLine();
                Console.Write("Digite a opção desejada:");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Informe o Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Informe o Local: ");
                        string local = Console.ReadLine();
                        Console.Write("Informe a Duração: ");
                        string duracao = Console.ReadLine();
                        Console.Write("Informe a Data: ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Informe a Lotação: ");
                        int lotacao = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Informe a Classificação: ");
                        int classificacao = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Informe o Artista: ");
                        string artista = Console.ReadLine();
                        Console.Write("Informe o Gênero Musical: ");
                        string generomusical = Console.ReadLine();

                        Show novoshow = new Show(titulo,local,lotacao,duracao,classificacao,data,artista,generomusical);

                        bool ShowCadastrado = novoshow.Cadastrar();

                        if(ShowCadastrado == true){
                            Console.WriteLine();
                            Console.WriteLine("Ação realizada com sucesso");
                            Console.WriteLine();
                        }
                        
                        break;

                    case "2":

                        break;

                    case "3":

                        break;
                    case "9":

                        break;
                    
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }while(opcao != "9");
        
        }

    }
}
