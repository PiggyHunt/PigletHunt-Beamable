using System;
using Beamable.Server;

namespace Beamable.VersionDataMicroservice
{
	public partial class VersionDataMicroservice : Microservice
	{
		/*
		[Callable] > publicly accessible, no authentication required
		[ClientCallable] > require authentication
		[AdminOnlyCallable] > only Beamable admins/developers can call it
		*/
		[ClientCallable]
		public VersionInfoResponse GetVersionInfo(VersionInfoRequest request)
		{
			return new VersionInfoResponse
			{
				StoreLink = "https://github.com/PiggyHunt/PigletHunt-Beamable",
				ForceUpdate = false,
				Maintenance = false,
				InvalidPlatform = false,
				AgreementVersion = "1.0.7",
				MaintenanceItems = new string[] { }
			};
		}

		public int Add(int a, int b)
		{
			return a + b;
		}
	}

	[Serializable]
	public class VersionInfoRequest
	{
		public string ClientVersion;
		public string Platform;
		public string Id;
	}

	[Serializable]
	public class VersionInfoResponse
	{
		public string StoreLink;
		public bool ForceUpdate;
		public bool Maintenance;
		public bool InvalidPlatform;
		public string AgreementVersion;
		public string[] MaintenanceItems;
	}
}