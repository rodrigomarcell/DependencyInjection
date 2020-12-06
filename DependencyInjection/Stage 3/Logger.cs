using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Stage_3
{
	class Logger : ILogger
	{
		public void log(string message)
		{
			Console.WriteLine("Message logged: {0}", message);
		}
	}

	public interface ILogger
	{
		void log(string message);
	}
}
