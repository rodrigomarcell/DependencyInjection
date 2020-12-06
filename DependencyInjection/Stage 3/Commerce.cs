using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Stage_3
{
	public class Commerce
	{
		IBillingProcessor _BillingProcessor;
		ICustomerProcessor  _CustomerProcessor;
		INotifier _Notifier;

		public Commerce(IBillingProcessor billingProcessor, ICustomerProcessor customerProcessor, INotifier notifier)
		{
			_BillingProcessor = billingProcessor;
			_CustomerProcessor = customerProcessor;
			_Notifier = notifier;

		}

		public void ProcessOrder(OrderInfo orderInfo)
		{
			_BillingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Email, orderInfo.Price);
			_CustomerProcessor.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
			_Notifier.SendReceipt(orderInfo);
		}
	}
}
