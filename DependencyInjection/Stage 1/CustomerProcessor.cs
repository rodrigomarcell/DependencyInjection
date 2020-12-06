using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Stage_1
{
	class CustomerProcessor
	{
		public void UpdateCustomerOrder(string customer, string product)
		{
			CustomerRepository customerRepository = new CustomerRepository();
			ProductRepository productRepository = new ProductRepository();

			customerRepository.Save();
			productRepository.Save();

			Console.WriteLine(string.Format("Customer record for {0} update with purchase of product {1}", customer, product));
		}
	}
}
