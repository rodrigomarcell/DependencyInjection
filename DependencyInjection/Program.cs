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
				Console.WriteLine();

				Console.Write("Select demo: ");

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
							DependencyInjection.Stage_1.Commerce commerce1 = new DependencyInjection.Stage_1.Commerce();
							commerce1.ProcessOrder(orderInfo);
							#endregion
							break;

						case "2":
							#region Stage 2
							Stage_2.Commerce commerce2 =
								new Stage_2.Commerce(
									new Stage_2.BillingProcessor(),
									new Stage_2.CustomerProcessor(
										new Stage_2.CustomerRepository(),
										new Stage_2.ProductRepository()),
									new Stage_2.Notifier());
							commerce2.ProcessOrder(orderInfo);
							#endregion
							break;
						
						case "3":
							#region Stage 3
							DependencyInjection.Stage_1.Commerce commerce3 = new DependencyInjection.Stage_1.Commerce();
							commerce3.ProcessOrder(orderInfo);
							#endregion
							break;
					}

					Console.WriteLine();
					Console.WriteLine("Press 'Enter' for menu.");
					Console.ReadLine();
				}

			}
		}
	}
}




