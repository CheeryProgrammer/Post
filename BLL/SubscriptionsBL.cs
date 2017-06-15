using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Subscriprions;
using Entities;

namespace BLL
{
	public class SubscriptionsBL : IDisposable
	{
		private readonly ISubscriprionDAO _subscriptions;
		private int top = 1;

		public SubscriptionsBL()
		{
			_subscriptions = new SubscriprionsSQL();
		}

		public IEnumerable<Subscription> GetList()
		{
			var res = _subscriptions.GetList();
			if(res.Any())
				top = Convert.ToInt32(res.Select(a => a.Code).Max());
			return res;
		}

		public void Add(Subscription newSubscription)
		{
			newSubscription.Code = ++top;
			_subscriptions.Add(newSubscription);
		}

		public void Update(Subscription subscription)
		{
			_subscriptions.Update(subscription);
		}

		public void Remove(int code)
		{
			_subscriptions.Remove(code);
		}

		public void Dispose()
		{
			if (_subscriptions != null)
				(_subscriptions as SubscriprionsSQL).Dispose();
		}
	}
}
