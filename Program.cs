using ContaBancaria.Model;

namespace ContaBancaria.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1, 123, 1, "Pedro", 1000.00M);
            c1.SetTitular("Pedrao");

            c1.Sacar(1000);
            c1.Depositar(55000.00M);
            c1.Visualizar();

            ContaCorrente cc1 = new ContaCorrente(2, 1234, 1, "Dolores", 500.60M, 1200.00M);
            cc1.Sacar(5000);
            cc1.Visualizar();

            ContaPoupanca cp1 = new ContaPoupanca(3, 1234, 2, "Dudu", 2400, 20);
            cp1.Visualizar();

            DigitarOpcao.EscolherOperacao();

            Mensagens.ExibirCreditos();

        }
    }
}
