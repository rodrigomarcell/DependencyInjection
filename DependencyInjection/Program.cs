using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
	class Program
	{
		public static IContainer Container;

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
							ContainerBuilder builder = new ContainerBuilder();
							
							builder.RegisterType<Stage_3.Commerce>();
							builder.RegisterType<Stage_3.Notifier>().As<Stage_3.INotifier>();
							

							builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
								.Where(t => t.Name.EndsWith("Processor") && t.Namespace.EndsWith("Stage_3"))
								.As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

							builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
								.Where(t => t.Name.EndsWith("Repository") && t.Namespace.EndsWith("Stage_3"))
								.As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

							builder.RegisterType<Stage_3.Logger>().As<Stage_3.ILogger>();

							Container = builder.Build();
							Stage_3.Commerce commerce3 = Container.Resolve<Stage_3.Commerce>();
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




