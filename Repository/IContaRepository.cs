using ContaBancaria.Model;

namespace ContaBancaria.Repository
{
    public interface IContaRepository
    {
        //Métodos CRUD
        public void ProcurarPorNumero(int numero);
        public void ListarTodas();
        public void Cadastrar(Conta conta);
        public void Atualizar(Conta conta);
        public void Deletar(int numero);

        //Métodos bancários
        public void Sacar(int numero, decimal valor);
        public void Depositar(int numero, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);
        public void ListarTodasPorTitular(string titular);

    }
}
