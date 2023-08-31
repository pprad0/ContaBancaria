namespace ContaBancaria.Classes
{
    internal class ClassDigitarOpcao
    {
        public static void EscolherOperacao()
        {
            int numeroDigitado;

            while (true)
            {
                ClassMensagens.ExibirMenu();

                Console.WriteLine(" Entre com a opção desejada: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (numeroDigitado == 9)
                    break;

                switch (numeroDigitado)
                {
                    case 1:
                        ClassOperacoes.CriarConta();
                        break;

                    case 2:
                        ClassOperacoes.ListarContas();
                        break;

                    case 3:
                        ClassOperacoes.BuscarContaPorNumero();
                        break;

                    case 4:
                        ClassOperacoes.AtualizarDadosConta();
                        break;

                    case 5:
                        ClassOperacoes.ApagarConta();
                        break;

                    case 6:
                        ClassOperacoes.Saque();
                        break;

                    case 7:
                        ClassOperacoes.Deposito();
                        break;

                    case 8:
                        ClassOperacoes.TransferenciaEntreContas();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!\n");
                        break;

                }
            }
        }
    }
}
