using Beamable.Server;

namespace Beamable.DailyRewardMicroservice
{
	public partial class DailyRewardMicroservice : Microservice
	{
		[ClientCallable]
		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
