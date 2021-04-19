using System;

namespace RelembrandoArraysDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declaracao_array
            int[] a = new int[2];
            var a2 = new int[2];
            #endregion
            #region atribuindo_valores
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = i*5;
            }
            #endregion
            #region lendo_valores
            Console.WriteLine(a2[1]);

            foreach (var n in a2)
            {
                Console.WriteLine(n);
            }
            #endregion
        }
    }
}
