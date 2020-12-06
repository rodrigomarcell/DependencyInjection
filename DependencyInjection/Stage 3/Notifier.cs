using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection;

namespace DependencyInjection.Stage_3
{
	public class Notifier : INotifier
	{
		void INotifier.SendReceipt(OrderInfo orderInfo)
		{
			Console.WriteLine("Receipt sent to customer {0} via email", orderInfo.CustomerName);
		}
	}

	public interface INotifier
	{
		void SendReceipt(OrderInfo orderInfo);
	}

	
}
