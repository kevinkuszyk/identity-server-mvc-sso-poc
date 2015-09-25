using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                Authority = "http://localhost:33841/identity",
                ClientId = "mvc",
                RedirectUri = "http://localhost:33881/",
                ResponseType = "id_token",
                
                SignInAsAuthenticationType = "Cookies"
            });

        }

        
    }
}