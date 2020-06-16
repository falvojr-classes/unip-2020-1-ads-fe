using System;

namespace Questao04CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 2, -4, 7, 0, -1, 4 };
            int n = 6;

            int resultado = f(v, n);
            
            Console.WriteLine(resultado);
        }

        static int f(int[] v, int n)
        {
            if (n == 0)
                return 0;
            else
            {
                int s;
                s = f(v, n - 1);
                if (v[n - 1] > 0) s = s + v[n - 1];
                return s;
            }
        }
    }
}
