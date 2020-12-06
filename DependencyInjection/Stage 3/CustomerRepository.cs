using System;

namespace DependencyInjection.Stage_3
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
