using System;
using Beamable.Server;

namespace Beamable.MigrateMicroService
{
    public partial class MigrateMicroService : Microservice
    {
		/*
		[Callable] > publicly accessible, no authentication required
		[ClientCallable] > require authentication
		[AdminOnlyCallable] > only Beamable admins/developers can call it
		*/
        [ClientCallable]
        public MigrateVersionResponse MigrateVersion(MigrateVersionRequest request)
        {
            return new MigrateVersionResponse
            {
                AgreementVersion = "1.0.7",
                HasMigrated = true
            };
        }

        [ClientCallable]
        public ClearAccountResponse ClearAccount()
        {
            return new ClearAccountResponse
            {
                Clear = false
            };
        }

        [ClientCallable]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [Serializable]
    public class MigrateVersionRequest
    {
        public string ClientVersion;
        public string Platform;
        public string Id;
    }

    [Serializable]
    public class MigrateVersionResponse
    {
        public string AgreementVersion;
        public bool HasMigrated;
    }

    [Serializable]
    public class ClearAccountResponse
    {
        public bool Clear;
    }
}