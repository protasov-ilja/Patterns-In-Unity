using Patterns.Singleton;
using System;
using System.Collections.Generic;

namespace Patterns.ServiceLocator
{
	/// TODO: 
	/// 1. Encapsulate the registry and cache components into self-contained classes
	/// 2. Implement the cache with a combination of the Factory and Prototype patterns
	/// 3. Implement the ability for services to add themselves dynamically to the registry
	/// 4. Write a standard interface for your service providers so you can effectively manage them.
	public class ServiceLocator : Singleton<ServiceLocator>
	{
		private IDictionary<object, object> _services;

		public override void Awake()
		{
			base.Awake();
			FillRegistry();
		}

		// TODO: We need to be able to fill the registry dynamically. 
		private void FillRegistry()
		{
			_services = new Dictionary<object, object>();
			_services.Add(typeof(LobbyCoordinator), new LobbyCoordinator());
			_services.Add(typeof(CurrencyConverter), new CurrencyConverter());
			_services.Add(typeof(LightingCoordinator), new LightingCoordinator());
		}

		public T GetService<T>()
		{
			try
			{
				return (T)_services[typeof(T)];
			}
			catch
			{
				throw new ApplicationException("The requested service is not found.");
			}
		}
	}
}
