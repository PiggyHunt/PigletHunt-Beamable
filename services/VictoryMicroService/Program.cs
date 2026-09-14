using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.VictoryMicroService
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="VictoryMicroService"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<VictoryMicroService>(routePrefix: "")
				.RunForever();
		}
	}
}
