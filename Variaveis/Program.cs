namespace Variaveis
{
    class Variaveis
    {
        static void Main()
        {
            /* Tabela de Variaveis
             * int -> -4,155,489...,482,689
             * uint -> 0,6,396,423,444
             * double -> -1.79769313486232e308...1.79769313486232e308
             * short -> -32,768...32,767
             * ushort -> 0...65,535
             * float -> -3,402823e38...3,402823e38
             * char -> U+0000...U+ffff
             */

            int x = 4;
            double y = 3.3;
            const double frequencia = 60;

            double area = x * y;

            Console.WriteLine("A área do quadrado é: " + area);
        }
    }
}
