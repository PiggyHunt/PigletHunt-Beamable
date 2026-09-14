using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.RedeemableMicroservice
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="RedeemableMicroservice"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<RedeemableMicroservice>(routePrefix: "")
				.RunForever();
		}
	}
}
