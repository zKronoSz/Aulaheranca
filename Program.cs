using System;

namespace Aulaheranca
{
    class Program
    {
        static void Main()
        {
            ContaEspecial conta = new ContaEspecial("12345", 1000.0, 500.0);

            conta.Depositar(200.0);
            conta.Sacar(150.0);

            conta.ConsultarLimite();
            conta.AumentarLimite(100.0);
            conta.DiminuirLimite(50.0);

            Console.ReadLine();
        }
    }
}