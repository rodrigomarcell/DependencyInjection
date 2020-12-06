using System;

namespace DependencyInjection.Stage_2
{
	public class BillingProcessor : IBillingProcessor
	{
	
		void IBillingProcessor.ProcessPayment(string customerName, string creditCard, string email, double price)
		{
			Console.WriteLine("Payment processed for customer {0} on credit card {1} for {2}", customerName, creditCard, price);
		}
	}

	public interface IBillingProcessor
	{
		void ProcessPayment(string customerName, string creditCard, string email, double price);
	}
} 