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


            DigitarOpcao.EscolherOperacao();

            Mensagens.ExibirCreditos();

        }
    }
}
