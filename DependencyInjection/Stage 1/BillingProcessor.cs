using System;

namespace DependencyInjection.Stage_1
{
	class BillingProcessor
	{
		public void ProcessPayment(string customerName, string creditCard, string email, double price)
		{
			Console.WriteLine("Payment processed for customer {0} on credit card {1} for {2}", customerName, creditCard, price);
		}
	}
}