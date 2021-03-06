﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Stage_3
{
	class CustomerProcessor  : ICustomerProcessor
	{
		ICustomerRepository _CustomerRepository;
		IProductRepository _ProductRepository;
		
		public CustomerProcessor(ICustomerRepository customerRepository, IProductRepository productRepository)
		{
			_CustomerRepository = customerRepository;
			_ProductRepository = productRepository;
		}
		
		void ICustomerProcessor.UpdateCustomerOrder(string customer, string product)
		{


			_CustomerRepository.Save();
			_ProductRepository.Save();

			Console.WriteLine(string.Format("Customer record for {0} update with purchase of product {1}", customer, product));
		}
	}

	public interface ICustomerProcessor
	{
		void UpdateCustomerOrder(string customer, string product);
	}
}
