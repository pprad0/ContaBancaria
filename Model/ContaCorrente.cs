namespace ContaBancaria.Model
{
    public class ContaCorrente : Conta
    {
        private decimal limite;

        public ContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo, decimal limite)
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }


        public decimal GetLimite()
        {
            return limite;
        }

        public void SetLimite(decimal limite)
        {
            this.limite = limite;
        }


        //Polimorfismo de sobrecarga
        // Override = sobrescrever
        public override bool Sacar(decimal valor)
        {

            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("\nSaldo insuficiente!\n");
                return false;
            }

            this.SetSaldo(this.GetSaldo() - valor);
            return true;

        }

        public override void Visualizar()
        {
            base.Visualizar();
            //console tudo o que tava na Conta

            Console.WriteLine($" Limite da conta: {this.limite}");
        }

    }
}
