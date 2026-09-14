using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.GroupMicroservice
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="GroupMicroservice"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<GroupMicroservice>(routePrefix: "")
				.RunForever();
		}
	}
}
