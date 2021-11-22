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

        //public static int Qualquer(string Pessoa)
        //{
        //    Console.WriteLine("Seu Nome: " + Pessoa);
        //    Console.ReadKey();
        //    return Pessoa.Length;
        //}

        public static void UtilizaDelegate(MetodoDelegate metodoDelegate)
        {
            var letras = metodoDelegate("Maria");
            Console.WriteLine("Quantidade de letras: " + letras);
            
        }



        static void Main(string[] args)
        {
            /*Utilizando métodos anonimos */

            UtilizaDelegate(delegate (string n) {
                Console.WriteLine("Nome: " + n);
                return n.Length;
            });

            MetodoDelegate metodoDelegate = delegate(string n) { 
                Console.WriteLine("Nome: " + n);
                return n.Length;
            };

            var letras = metodoDelegate("João");
            Console.WriteLine("Quantidade de letras: " + letras);

            Console.ReadKey();


        }
    }
}
