using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá usuário, por favor, digite sua senha: ");
            string _senha = Console.ReadLine();

            if(_senha == "1234abcd"){
                Console.WriteLine("Acesso permitido.");
            }
            else{
                Console.WriteLine("Acesso negado.");
            }
        }
    }
}
