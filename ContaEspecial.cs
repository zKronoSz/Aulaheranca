using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaheranca
{
          public class ContaEspecial : ContaCorrente
        {
            public double Limite { get; set; }

            public ContaEspecial(string numero, double saldo, double limite) : base(numero, saldo)
            {
                Limite = limite;
            }

            public void ConsultarLimite()
            {
                Console.WriteLine($"O limite atual é: {Limite}");
            }

            public void AumentarLimite(double valor)
            {
                Limite += valor;
                Console.WriteLine($"Limite aumentado em {valor}. Limite atual: {Limite}");
            }

            public void DiminuirLimite(double valor)
            {
                if (Limite >= valor)
                {
                    Limite -= valor;
                    Console.WriteLine($"Limite diminuído em {valor}. Limite atual: {Limite}");
                }
                else
                {
                    Console.WriteLine("Valor maior que o limite disponível.");
                }
            }
        }
}

