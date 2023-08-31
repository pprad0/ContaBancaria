namespace ContaBancaria.Classes
{
    internal class DigitarOpcao
    {
        public static void EscolherOperacao()
        {
            int numeroDigitado;

            while (true)
            {
                Mensagens.ExibirMenu();

                Console.WriteLine(" Entre com a opção desejada: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (numeroDigitado == 9)
                    break;

                switch (numeroDigitado)
                {
                    case 1:
                        Operacoes.CriarConta();
                        break;

                    case 2:
                        Operacoes.ListarContas();
                        break;

                    case 3:
                        Operacoes.BuscarContaPorNumero();
                        break;

                    case 4:
                        Operacoes.AtualizarDadosConta();
                        break;

                    case 5:
                        Operacoes.ApagarConta();
                        break;

                    case 6:
                        Operacoes.Saque();
                        //c1.Saque();
                        break;

                    case 7:
                        Operacoes.Deposito();
                        break;

                    case 8:
                        Operacoes.TransferenciaEntreContas();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!\n");
                        break;

                }
            }
        }
    }
}
