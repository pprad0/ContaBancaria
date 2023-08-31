namespace ContaBancaria.Classes
{
    internal class Mensagens
    {
        public static void ExibirMenu()
        {
            string menu;
            menu =
                "\n---------------------------------------------------------\n" +
                "\n\n\tO MELHOR BANCO DO MUNDO\n\n" +
                "\n---------------------------------------------------------\n" +
                "\n\t1 - Criar conta" +
                "\n\t2 - Listas todas as contas" +
                "\n\t3 - Buscar conta por número" +
                "\n\t4 - Atualizar dados da conta" +
                "\n\t5 - Apagar conta" +
                "\n\t6 - Sacar" +
                "\n\t7 - Depositar" +
                "\n\t8 - Transferir valores entre contas" +
                "\n\t9 - Sair" +
                "\n\n---------------------------------------------------------\n";


            Console.WriteLine(menu);
        }


        public static void ExibirCreditos()
        {
            string creditos;

            creditos =
                " \n\nO Melhor Banco do Mundo - O seu Futuro começa aqui!" +
                "\n---------------------------------------------------------\n" +
                " Projeto desenvolvido por: Pedro Melo" +
                "\n Generation Brasil - generation@generation.org" +
                "\n github.com/conteudoGeneration" +
                "\n---------------------------------------------------------\n\n";

            Console.WriteLine(creditos);
        }
    }
}
