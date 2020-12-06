using System;
using DependencyInjection;

namespace DependencyInjection.Stage_1
{
	internal class Notifier
	{
		public void SendReceipt(OrderInfo orderInfo)
		{
			Console.WriteLine("Receipt sent to customer {0} via email", orderInfo.CustomerName);
		}
	}
}