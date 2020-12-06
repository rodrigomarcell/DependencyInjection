using System;

namespace DependencyInjection.Stage_3
{
	public class ProductRepository : IProductRepository
	{
		void IProductRepository.Save()
		{
			Console.Write("Product inventory updated.");
		}
	}

	public interface IProductRepository
	{
		void Save();
	}
}