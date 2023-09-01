namespace ContaBancaria.Model
{
    public class ContaPoupanca : Conta
    {
        private int aniversario;
        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario)
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        public decimal GetDia()
        {
            return aniversario;
        }

        public void SetDia(int aniversario)
        {
            this.aniversario = aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($" Aniversário da conta: {this.aniversario}");
        }
    }
}
