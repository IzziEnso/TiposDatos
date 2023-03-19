namespace ProgramaFuncionesBasicas
{
    class Program
    {
        static void Main(String[] Args)
        {
            double num1, num2;

            Console.Write("DIGITE UN PRIMER NÚMERO: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("DIGITE UN SEGUNDO NÚMERO: ");
            num2 = double.Parse(Console.ReadLine());

            //VALOR ABSOLUTO
            Console.WriteLine($"VALOR ABSOLUTO PRIMER NÚMERO: {Math.Abs(num1)}");
            Console.WriteLine($"VALOR ABSOLUTO SEGUNDO NÚMERO: {Math.Abs(num2)}");

            //POTENCIA
            Console.WriteLine($"POTENCIA PRIMER NÚMERO: {Math.Pow(num1, 3)}");
            Console.WriteLine($"POTENCIA SEGUNDO NÚMERO: {Math.Pow(num2, 3)}");

            //RAIZ CUADRADA
            Console.WriteLine($"RAIZ CUADRADA PRIMER NÚMERO: {Math.Sqrt(num1)}");
            Console.WriteLine($"RAIZ CUADRADA SEGUNDO NÚMERO: {Math.Sqrt(num2)}");

            //SENO
            Console.WriteLine($"SENO PRIMER NÚMERO: {Math.Sin(num1 * Math.PI / 180)}");
            Console.WriteLine($"SENO SEGUNDO NÚMERO: {Math.Sin(num2 * Math.PI / 180)}");

            //COSENO
            Console.WriteLine($"COSENO PRIMER NÚMERO: {(num1 * Math.PI / 180)}");
            Console.WriteLine($"COSENO SEGUNDO NÚMERO: {(num2 * Math.PI / 180)}");

            //NÚMERO MÁXIMO 
            Console.WriteLine($"NÚMERO MÁXIMO PRIMER NÚMERO: {Math.Max(num1, 50)}");
            Console.WriteLine($"NÚMERO MÁXIMO SEGUNDO NÚMERO: {Math.Max(num2, 50)}");

            //NÚMERO MÍNIMO
            Console.WriteLine($"NÚMERO MÍNIMO PRIMER NÚMERO: {Math.Min(num1, 50)}");
            Console.WriteLine($"NÚMERO MÍNIMO SEGUNDO NÚMERO: {Math.Min(num2, 50)}");

            //PARTE ENTERA
            Console.WriteLine($"PARTE ENTERA PRIMER NÚMERO: {Math.Truncate(num1)}");
            Console.WriteLine($"PARTE ENTERA SEGUNDO NÚMERO: {Math.Truncate(num2)}");

            //REDONDEO
            Console.WriteLine($"REDONDEO PRIMER NÚMERO: {Math.Round(num1)}");
            Console.WriteLine($"REDONDEO SEGUNDO NÚMERO: {Math.Round(num2)}");

            Console.WriteLine("\n\n\tPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
