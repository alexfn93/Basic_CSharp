namespace Conversao
{
    class Program
    {
        static void Main()
        {
            /*------- Conversão Implícita -----------*/

            int x = 4;
            double y = x; // Conversão Implícita
            Console.WriteLine(y);

            /*------- Conversão Explícita -----------*/

            double nota = 8.6;
            int notaConvertida =
                (int)nota; // Conversão Explícita
            Console.WriteLine(notaConvertida);

            /*------ Conversão com a classe Convert ---------*/
            Console.WriteLine("Digite qual número é sua casa: ");
            string numeroCasa = Console.ReadLine();
            int numero = int.Parse(numeroCasa);
            Console.WriteLine("Número da sua casa é: ", numero);

            numero = Convert.ToInt32(numeroCasa);

            Console.WriteLine(numero);
        }
    }
}
