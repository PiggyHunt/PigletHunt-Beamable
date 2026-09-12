using Beamable.Server;
using System.Threading.Tasks;

namespace Beamable.AccountMicroService
{
	public class Program
	{
		/// <summary>
		/// The entry point for the <see cref="AccountMicroService"/> service.
		/// </summary>
		public static async Task Main()
		{
			await BeamServer
				.Create()
				.IncludeRoutes<AccountMicroService>(routePrefix: "")
				.RunForever();
		}
	}
}
