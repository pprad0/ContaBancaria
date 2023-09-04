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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }



        public void ProcurarPorNumero(int numero)
        {
            throw new NotImplementedException();
        }


        //
        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }


        //Métodos auxiliares

        public int GerarNumero()
        {
            return ++numero;
        }
    }
}
