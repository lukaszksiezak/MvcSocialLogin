using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SocialMediaLoginApp.App_Start.Startup))]

namespace SocialMediaLoginApp.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions()
            {
                AuthenticationType = "",
                LoginPath = new PathString("/Auth/Login")
            });
            app.UseFacebookAuthentication(new Microsoft.Owin.Security.Facebook.FacebookAuthenticationOptions()
            {
                AppId = "",
                AppSecret = "",
                SignInAsAuthenticationType = ""
            });
        }
    }
}
