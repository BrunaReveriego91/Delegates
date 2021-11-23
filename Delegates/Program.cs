using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {

        public delegate int MetodoDelegate(string Nome);
        public delegate void MetodoLambda(int idade);



        public static void UtilizaDelegate(MetodoDelegate metodoDelegate)
        {
            var letras = metodoDelegate("Maria");
            Console.WriteLine("Quantidade de letras: " + letras);

        }



        static void Main(string[] args)
        {
            /*Utilizando métodos anonimos */

            //UtilizaDelegate((string n) =>
            //{
            //    Console.WriteLine("Nome: " + n);
            //    return n.Length;
            //});

            MetodoLambda metodoLambda = (i) => { Console.WriteLine("O número é: " + i); };
            metodoLambda(23);

            //MetodoDelegate metodoDelegate = (string n) =>
            //{
            //    Console.WriteLine("Nome: " + n);
            //    return n.Length;
            //};

            //var letras = metodoDelegate("João");
            //Console.WriteLine("Quantidade de letras: " + letras);

            Console.ReadKey();


        }
    }
}
