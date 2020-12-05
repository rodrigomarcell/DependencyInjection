using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
		public class Commerce
	{

		public void ProcessOrder(OrderInfo orderInfo)
		{
			BillingProcessor billingProcessor = new BillingProcessor();
			CustomerProcessor customerProcessor = new CustomerProcessor();
			Notifier notifier = new Notifier();

			billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Email, orderInfo.Price);
			customerProcessor.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
			notifier.SendReceipt(orderInfo);



		}
	}
}
