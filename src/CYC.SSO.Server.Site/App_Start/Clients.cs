using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace CYC.SSO.Server.Site.App_Start
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "MVC Client",
                    ClientId = "mvc",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:33881/"
                    },
                    
                    AllowAccessToAllScopes = true
                }
            };
        }
    }
}