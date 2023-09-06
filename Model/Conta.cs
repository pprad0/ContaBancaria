namespace ContaBancaria.Model
{
    public abstract class Conta
    {
        //atributos da classe
        private int numero;
        private int agencia;
        private int tipo;
        private string titular = string.Empty;
        private decimal saldo;


        //Construtor
        public Conta(int numero, int agencia, int tipo, string titular, decimal saldo) //entre parênteses = parâmetros
        {
            //a esquerda da igualdade é atributo da classe
            //a direita da igualdade é parâmetro
            this.numero = numero;
            this.agencia = agencia;
            this.tipo = tipo;
            this.titular = titular;
            this.saldo = saldo;
        }


        /*Métodos Get e Set*/
        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetAgencia()
        {
            return agencia;
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string titular)
        {
            this.titular = titular;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(decimal saldo)
        {
            this.saldo = saldo;
        }


        //Polimorfismo de sobrecarga
        public virtual bool Sacar(decimal valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("\nSaldo insuficiente!\n");
                return false;
            }

            this.SetSaldo(this.saldo - valor);
            return true;
        }

        public void Depositar(decimal valor)
        {
            this.SetSaldo(this.saldo + valor);
        }

        public virtual void Visualizar()
        {
            string tipo = "";

            switch (this.tipo)
            {
                case 1:
                    tipo = "Conta corrente";
                    break;

                case 2:
                    tipo = "Conta Poupança";
                    break;
            }

            Console.WriteLine("\n\n--------------------------------------");
            Console.WriteLine("\tDados da conta");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($" Número da conta: {this.numero}");
            Console.WriteLine($" Número da agência: {this.agencia}");
            Console.WriteLine($" Tipo de conta: {tipo}");
            Console.WriteLine($" Titular da conta: {this.titular}");
            Console.WriteLine($" Saldo: {this.saldo}");
        }

    }
}

