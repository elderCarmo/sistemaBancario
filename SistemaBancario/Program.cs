using System;


namespace SistemaBancario;

internal class Program

{
    private static double saldo = 0;
    private static void retirar()
    {
        Console.WriteLine("Quanto deseja retirar?");
        double valor = double.Parse(Console.ReadLine());
        if (valor <= saldo)
        {
            Console.WriteLine("Dinheiro retirado com sucesso");
            Console.WriteLine("=======================================================");
            saldo -= valor;


        }
        else { Console.WriteLine("Desculpe você não possui saldo suficiente");
            Console.WriteLine("=======================================================");
        }
    }
    private static void depositar()
    {
        Console.WriteLine("Quanto deseja depositar?");
        double deposito = double.Parse(Console.ReadLine());
        saldo =+deposito;
        Console.WriteLine("Deposito Realizado Com Sucesso");
        Console.WriteLine("======================================================="); ;

    }
    private static void tranferir()
    {
        Console.WriteLine("Quanto Deseja Tranferir?");
        double tranferencia = double.Parse(Console.ReadLine());
        if (saldo >= tranferencia)
        {
            Console.WriteLine("Tranferência Realizada Com Sucesso");
            Console.WriteLine("=======================================================");
            saldo -= tranferencia;
        }
        else { Console.WriteLine("Saldo Insuficiente");
            Console.WriteLine("=======================================================");
        }

    }
    private static void ConsultarSaldo()
    {
        Console.WriteLine("Saldo Atual: " + saldo);
        Console.WriteLine("======================================================="); ;

    }
    static void Main(string[] args)
    {
        int opcao;
        do
        {


            Console.WriteLine("Seja Bem Vindo,Escolha Uma Opçao Para Prosseguir");
            Console.WriteLine("1: Para Retirar!");
            Console.WriteLine("2: Para Depositar!");
            Console.WriteLine("3: Para Tranferir");
            Console.WriteLine("4: Para Consultar Saldo!");
            Console.WriteLine("5: Para Encerrar o Programa!");
            Console.WriteLine("=======================================================");
            opcao = int.Parse(Console.ReadLine());
            

            switch (opcao)
            {
                case 1:
                    retirar();
                    break;

                case 2:
                    depositar();
                    break;

                case 3:
                    tranferir();
                    break;


                case 4:
                    ConsultarSaldo();
                    break;

                default:
                    if (opcao > 5 ) { Console.WriteLine("insira uma opção valida");
                    }
                    break;
                    

            }
        } while (opcao != 5);
    }
     
}
