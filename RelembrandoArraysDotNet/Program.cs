using System;
using System.Collections.Generic;

namespace RelembrandoArraysDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region documentacao
            /*
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

            #region declaracao_lista
            List<string> nomes = new List<string>();
            #endregion
            #region atribuindo_valores
            nomes.Add("Lucas");
            nomes.Add("Taty");
            #endregion
            #region lendo_valores
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            #endregion*/
            #endregion
            var frutas = new List<string>();

            frutas.Add("Macã");
            frutas.Add("Morango");
            frutas.Add("Laranja");

            frutas.Clear();

            frutas.Add("Acerola");
            var contemLaranja = frutas.Contains("Laranja") ? "É verdade esse bilhete" : "Tudo errado isso aí"; //retorna false, lembrando que limpei a lista
            Console.WriteLine(contemLaranja);

            frutas.Find(e => e == "Acerola"); //Validando se encontra elemento dentro da lista;

            frutas.FindAll(e => e == "Ac");

            Console.WriteLine(frutas.RemoveAll(e => e == "Acerola")); 

            foreach(var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
