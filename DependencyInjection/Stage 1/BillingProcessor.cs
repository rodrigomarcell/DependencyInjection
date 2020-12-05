using System;

namespace DependencyInjection
{
	class BillingProcessor
	{
		public void ProcessPayment(string customerName, string creditCard, string email, double price)
		{
			Console.WriteLine("Payment processed for customer {0} on credit card {1} for {2}", customerName, creditCard, price);
		}
	}
}