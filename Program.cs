using ContaBancaria.Controller;
using ContaBancaria.Model;

namespace ContaBancaria.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, agencia, tipo, aniversario, numero, numeroDestino;
            string? titular;
            decimal saldo, limite, valor;


            ContaController contas = new();
            //entre parênteses = expressão
            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero(), 1234, 1, "Dolores", 500.60M, 1200.00M);
            contas.Cadastrar(cc1);

            ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 1234, 2, "Dudu", 2400, 20);
            contas.Cadastrar(cp1);




            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string menu =
                    "\n---------------------------------------------------------\n" +
                    "\n\n\tO MELHOR BANCO DO MUNDO\n\n" +
                    "\n---------------------------------------------------------\n" +
                    "\n\t1 - Criar conta" +
                    "\n\t2 - Listar todas as contas" +
                    "\n\t3 - Buscar conta por número" +
                    "\n\t4 - Atualizar dados da conta" +
                    "\n\t5 - Apagar conta" +
                    "\n\t6 - Sacar" +
                    "\n\t7 - Depositar" +
                    "\n\t8 - Transferir valores entre contas" +
                    "\n\t9 - Sair" +
                    "\n\n---------------------------------------------------------\n";

                Console.WriteLine(menu);

                Console.WriteLine(" Entre com a opção desejada: ");

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nDigite um número entre 1 e 9.");
                    Console.ResetColor();
                    opcao = 0;
                }

                Console.ForegroundColor = ConsoleColor.Green;

                if (opcao == 9)
                    break;

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o Número da Agência");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Nome do titular");
                        titular = Console.ReadLine()!;

                        //titular ??= string.Empty;

                        Console.WriteLine("Digite o Tipo da Conta");
                        tipo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Saldo da Conta");
                        saldo = Convert.ToDecimal(Console.ReadLine());


                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o Limite da Conta");
                                limite = Convert.ToDecimal(Console.ReadLine());

                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
                                break;

                            case 2:
                                Console.WriteLine("Digite o Aniversário da Conta");
                                aniversario = Convert.ToInt32(Console.ReadLine());

                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));
                                break;
                        }

                        break;

                    case 2:
                        contas.ListarTodas();
                        break;

                    case 3:
                        Console.WriteLine("\nConsultar dados da Conta - por número");

                        Console.WriteLine("Digite o número da Conta: ");
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de conta válido.");
                            Console.ResetColor();
                            numero = 0;
                        }

                        contas.ProcurarPorNumero(numero);

                        break;

                    case 4:

                        Console.WriteLine("\nAtualizar dados da Conta - por número");

                        Console.WriteLine("Digite o número da Conta: ");
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de conta válido.");
                            Console.ResetColor();
                            numero = 0;
                        }


                        var conta = contas.BuscarNaCollection(numero);

                        if (conta is not null)
                        {
                            Console.WriteLine("Digite o Número da Agência");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o Nome do titular");
                            titular = Console.ReadLine()!;

                            //titular ??= string.Empty;

                            Console.WriteLine("Digite o Tipo da Conta");
                            tipo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o Saldo da Conta");
                            saldo = Convert.ToDecimal(Console.ReadLine());


                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o Limite da Conta");
                                    limite = Convert.ToDecimal(Console.ReadLine());

                                    contas.Atualizar(new ContaCorrente(numero, agencia, tipo, titular, saldo, limite));
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o Aniversário da Conta");
                                    aniversario = Convert.ToInt32(Console.ReadLine());

                                    contas.Atualizar(new ContaPoupanca(numero, agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }



                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Não existe conta com o número informado.");
                            Console.ResetColor();
                        }




                        break;

                    case 5:

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.Deletar(numero);




                        Console.WriteLine("\n Apagar conta - por número");

                        Console.WriteLine(" Digite o número da Conta: ");
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de conta válido.");
                            Console.ResetColor();
                            numero = 0;
                        }

                        contas.Deletar(numero);

                        break;

                    case 6:
                        //Saque
                        //dados necessários: Numero da Conta, valor do saque

                        Console.WriteLine(" Digite o número da Conta: ");
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de conta válido.");
                            Console.ResetColor();
                            numero = 0;
                        }

                        Console.WriteLine(" Digite o valor do Saque: ");
                        try
                        {
                            valor = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de valor válido.");
                            Console.ResetColor();
                            valor = 0;
                        }
                        //sacar

                        contas.Sacar(numero, valor);

                        break;

                    case 7:
                        //Deposito
                        Console.WriteLine(" Digite o número da Conta: ");
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de conta válido.");
                            Console.ResetColor();
                            numero = 0;
                        }

                        Console.WriteLine(" Digite o valor do Depósito: ");
                        try
                        {
                            valor = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de valor válido.");
                            Console.ResetColor();
                            valor = 0;
                        }

                        contas.Depositar(numero, valor);

                        break;

                    case 8:
                        //TransferenciaEntreContas();

                        //Saque
                        //dados necessários: Numero da Conta, valor do saque

                        Console.WriteLine(" Digite o número da sua Conta: ");
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de conta válido.");
                            Console.ResetColor();
                            numero = 0;
                            break;
                        }

                        Console.WriteLine(" Digite o valor da Transferência: ");
                        try
                        {
                            valor = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de valor válido.");
                            Console.ResetColor();
                            valor = 0;
                            break;
                        }

                        //Deposito
                        Console.WriteLine(" Digite o número da Conta Destino: ");
                        try
                        {
                            numeroDestino = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nDigite um número de Conta Destino válido.");
                            Console.ResetColor();
                            numeroDestino = 0;
                            break;
                        }


                        contas.Transferir(numero, numeroDestino, valor);

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção inválida!\n");
                        Console.ResetColor();
                        break;

                }
            }

            string creditos =
                " \n\nO Melhor Banco do Mundo - O seu Futuro começa aqui!" +
                "\n---------------------------------------------------------\n" +
                " Projeto desenvolvido por: Pedro Melo" +
                "\n Generation Brasil - generation@generation.org" +
                "\n github.com/conteudoGeneration" +
                "\n---------------------------------------------------------\n\n";

            Console.WriteLine(creditos);

        }
    }
}
