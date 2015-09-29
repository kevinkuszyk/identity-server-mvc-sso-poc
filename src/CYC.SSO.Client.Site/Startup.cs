using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;

namespace CYC.SSO.Client.Site
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = "https://localhost:44306/identity",
                ClientId = "mvc",
                RedirectUri = "https://localhost:44300/",
                ResponseType = "id_token",
                
                SignInAsAuthenticationType = "Cookies",
                AuthenticationMode = AuthenticationMode.Active
            });
        }
    }
}