using ContaBancaria.Model;
using ContaBancaria.Repository;

namespace ContaBancaria.Controller
{
    public class ContaController : IContaRepository
    {

        private readonly List<Conta> listaContas = new();
        int numero = 0;

        //Métodos do CRUD
        public void Atualizar(Conta conta)
        {

            var buscaConta = BuscarNaCollection(conta.GetNumero());

            if (buscaConta is not null)
            {
                var index = listaContas.IndexOf(buscaConta);
                listaContas[index] = conta;

                Console.WriteLine($" A conta de número {conta.GetNumero()} foi atualizada com sucesso!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }

        }

        public void Cadastrar(Conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($" A conta número {conta.GetNumero()} foi criada com sucesso!");
        }

        public void ListarTodas()
        {
            foreach (var conta in listaContas)
            {
                conta.Visualizar();
            }
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {

                if (listaContas.Remove(conta))
                    Console.WriteLine($" A conta número {numero} foi apagada com sucesso!");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" A conta número {numero} não foi encontrada!");
                    Console.ResetColor();
                }
            }
        }


        //Métodos Auxiliares
        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                conta.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nA conta número {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }


        //Métodos Bancários
        public void Depositar(int numero, decimal valor)
        {
            var contaDeposito = BuscarNaCollection(numero);

            if (contaDeposito != null)
                contaDeposito.SetSaldo(contaDeposito.GetSaldo() + valor);


        }

        public void Sacar(int numero, decimal valor)
        {
            var contaSaque = BuscarNaCollection(numero);

            if (contaSaque != null)
            {
                //Retirar dinheiro do saldo/limite;
                if (contaSaque.Sacar(valor) == true)
                    Console.Write($"Operação realizada com sucesso!");

            }
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            var contaOrigem = BuscarNaCollection(numeroOrigem);
            var contaDestino = BuscarNaCollection(numeroDestino);

            if (contaOrigem is not null && contaDestino is not null)
            {
                if (contaOrigem.Sacar(valor) == true)
                {
                    contaDestino.Depositar(valor);
                    Console.WriteLine($"A Transferência foi efetuada com sucesso!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Conta de Origem e/ou Conta de Destino não fora encontradas!");
                Console.ResetColor();
            }
        }


        //Métodos auxiliares

        public int GerarNumero()
        {
            return ++numero;
        }

        //Método para buscar um Objeto Conta específico
        public Conta? BuscarNaCollection(int numero)
        {
            foreach (var conta in listaContas)
            {
                if (conta.GetNumero() == numero)
                    return conta;
            }

            return null;
        }


    }
}
