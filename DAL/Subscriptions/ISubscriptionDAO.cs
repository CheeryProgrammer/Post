using System.Collections.Generic;

namespace DAL.Subscriprions
{
	public interface ISubscriprionDAO
	{
		int Add(Entities.Subscription subscription);
		void Update(Entities.Subscription editSubscription);
		void Remove(Entities.Subscription subscription);
		IEnumerable<Entities.Subscription> GetList();
		void Remove(int code);
	}
}
