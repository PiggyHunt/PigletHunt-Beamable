using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.RealmMicroService
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="RealmMicroService"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<RealmMicroService>(routePrefix: "")
				.RunForever();
		}
	}
}
