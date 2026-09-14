using Beamable.Server;

namespace Beamable.VictoryMicroService
{
	public partial class VictoryMicroService : Microservice
	{
		[ClientCallable]
		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
