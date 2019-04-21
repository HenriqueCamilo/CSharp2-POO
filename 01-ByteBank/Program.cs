using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

                Console.WriteLine($"conta da gabriela{contaGabriela}");


            

            Console.ReadLine();
        }
    }
}
