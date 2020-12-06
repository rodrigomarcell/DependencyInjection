using System;

namespace DependencyInjection.Stage_2
{
	class CustomerRepository : ICustomerRepository
	{

		void ICustomerRepository.Save()
		{
			Console.WriteLine("Customer purchase saved.");
		}
				
	}

	interface ICustomerRepository
	{
		void Save();
	}
}
