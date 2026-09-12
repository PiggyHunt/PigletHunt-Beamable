using System;
using Beamable.Server;

namespace Beamable.AccountMicroService
{
    public partial class AccountMicroService : Microservice
    {
        /*
        [Callable] > publicly accessible, no authentication required
        [ClientCallable] > require authentication
        [AdminOnlyCallable] > only Beamable admins/developers can call it
        */
        [ClientCallable]
        public InitializeAccountResponse InitializeAccount()
        {
            return new InitializeAccountResponse
            {
                AccountInitialized = true
            };
        }

        [ClientCallable]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [Serializable]
    public class InitializeAccountResponse
    {
        public bool AccountInitialized;
    }
}