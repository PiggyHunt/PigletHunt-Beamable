using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.DailyRewardMicroservice
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="DailyRewardMicroservice"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<DailyRewardMicroservice>(routePrefix: "")
				.RunForever();
		}
	}
}
