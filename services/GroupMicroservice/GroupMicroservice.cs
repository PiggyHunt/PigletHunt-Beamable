using Beamable.Server;

namespace Beamable.GroupMicroservice
{
	public partial class GroupMicroservice : Microservice
	{
		[ClientCallable]
		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
