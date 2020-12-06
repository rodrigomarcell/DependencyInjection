using System;

namespace DependencyInjection.Stage_3
{
	class CustomerRepository : ICustomerRepository
	{
		ILogger _Logger;

		public CustomerRepository(ILogger logger)
		{
			_Logger = logger;
		}

		void ICustomerRepository.Save()
		{
			Console.WriteLine("Customer purchase saved.");
			_Logger.log("Customer purchase saved to log file.");
		}
				
	}

	interface ICustomerRepository
	{
		void Save();
	}
}
