using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.VersionDataMicroservice
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="VersionDataMicroservice"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<VersionDataMicroservice>(routePrefix: "")
				.RunForever();
		}
	}
}
