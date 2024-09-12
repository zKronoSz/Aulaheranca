
	public class ContaBase
	{
		public string Numero { get; set; }
		public double Saldo { get; set; }

		public ContaBase(string numero, double saldo)
		{
			Numero = numero;
			Saldo = saldo;
		}

		public virtual void Depositar(double valor)
		{
			Saldo += valor;
			Console.WriteLine($"Depósito de {valor} realizado. Saldo atual: {Saldo}");
		}

		public virtual void Sacar(double valor)
		{
			if (Saldo >= valor)
			{
				Saldo -= valor;
				Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {Saldo}");
			}
			else
			{
				Console.WriteLine("Saldo insuficiente.");
			}
		}
	}
