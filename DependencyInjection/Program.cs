using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
	class Program
	{
		static void Main(string[] args)
		{
			bool exit = false;
			while (!exit)
			{
				Console.WriteLine();
				Console.WriteLine("1 - Stage 1");
				Console.WriteLine("1 - Stage 2");
				Console.WriteLine("1 - Stage 3");
				Console.WriteLine("0 - Exit");

				Console.WriteLine("Select demo: ");
				string choice = Console.ReadLine();
				if (choice == "0")
				{
					exit = true;
				}
				else
				{
					OrderInfo orderInfo = new OrderInfo()
					{
						CustomerName = "Rodrigo Marcel",
						Email = "rodrigomarcell@outlook.com",
						Product = "Laptop",
						Price = 1200,
						CreditCard = "1234567890"
					};

					Console.WriteLine();
					Console.WriteLine("Ordering Processing");
					Console.WriteLine();

					switch (choice)
					{
						case "1":
							#region Stage 1
							DependencyInjection.Commerce commerce1 = new DependencyInjection.Commerce();
							commerce1.ProcessOrder(orderInfo);
							#endregion	
							break;

						case "2":
							#region Stage 2
							DependencyInjection.Commerce commerce2 = new DependencyInjection.Commerce();
							commerce2.ProcessOrder(orderInfo);
							#endregion
							break;
						
						case "3":
							#region Stage 3
							DependencyInjection.Commerce commerce3 = new DependencyInjection.Commerce();
							commerce3.ProcessOrder(orderInfo);
							#endregion
							break;
					}

				}

			}
		}
	}
}




