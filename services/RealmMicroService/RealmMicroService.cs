using Beamable.Server;

namespace Beamable.RealmMicroService
{
	public partial class RealmMicroService : Microservice
	{
		[ClientCallable]
		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
