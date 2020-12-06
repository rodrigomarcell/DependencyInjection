using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Stage_1
{
	class CustomerRepository
	{
		public void Save()
		{
			Console.WriteLine("Customer purchase saved.");
		}
	}
}
