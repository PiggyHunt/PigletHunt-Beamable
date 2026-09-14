using Beamable.Server;

namespace Beamable.RedeemableMicroservice
{
	public partial class RedeemableMicroservice : Microservice
	{
		[ClientCallable]
		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
