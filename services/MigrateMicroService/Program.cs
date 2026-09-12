using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.MigrateMicroService
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="MigrateMicroService"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<MigrateMicroService>(routePrefix: "")
				.RunForever();
		}
	}
}
