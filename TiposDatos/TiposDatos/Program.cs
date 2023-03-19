namespace ProgramaOperacionesBasicas
{
    class Program
    {
        static void Main (String[] Args)
        {
            int num1, num2, suma, resta, division, multiplicacion, residuo;

            Console.Write("PRIMER NÚMERO: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("SEGUNDO NÚMERO: ");
            num2 = int.Parse(Console.ReadLine());

            //SUMA
            suma = num1 + num2;
            Console.WriteLine("LA SUMA ES: " + suma);

            //RESTA
            resta = num1 - num2;
            Console.WriteLine("LA RESTA ES: " + resta);

            //MULTIPLICACION
            multiplicacion = num1 * num2;
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + multiplicacion);

            //DIVISIÓN
            if (num2 != 0)
            {
                division = num1 / num2;
                Console.WriteLine("LA DIVISIÓN ES: " + division);

            }

            //RESIDUO
            residuo = num1 % num2;
            Console.WriteLine("EL RESIDUO ES: " + residuo);


            Console.WriteLine("\n\n\tPresione una tecla para salir ...");
            Console.ReadKey();

        }
    }
}