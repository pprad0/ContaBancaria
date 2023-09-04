using ContaBancaria.Controller;
using ContaBancaria.Model;

namespace ContaBancaria.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, agencia, tipo, aniversario;
            string? titular;
            decimal saldo, limite;


            ContaController contas = new();

            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero(), 1234, 1, "Dolores", 500.60M, 1200.00M);
            contas.Cadastrar(cc1);

            ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 1234, 2, "Dudu", 2400, 20);
            contas.Cadastrar(cp1);




            while (true)
            {
                string menu =
                    "\n---------------------------------------------------------\n" +
                    "\n\n\tO MELHOR BANCO DO MUNDO\n\n" +
                    "\n---------------------------------------------------------\n" +
                    "\n\t1 - Criar conta" +
                    "\n\t2 - Listas todas as contas" +
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
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

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
                        //BuscarContaPorNumero();
                        break;

                    case 4:
                        //AtualizarDadosConta();
                        break;

                    case 5:
                        //ApagarConta();
                        break;

                    case 6:
                        //Saque();
                        //c1.Saque();
                        break;

                    case 7:
                        //Deposito();
                        break;

                    case 8:
                        //TransferenciaEntreContas();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!\n");
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
