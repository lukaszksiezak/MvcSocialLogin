using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web;
using System.IO;

[assembly: OwinStartup(typeof(SocialMediaLoginApp.App_Start.Startup))]

namespace SocialMediaLoginApp.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use((context, next) => {
                PrintCurrentIntegratedPipelineStage(context, "AppAuth has started");
                return next.Invoke();
            });
            //app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions()
            //{
            //    AuthenticationType = "secretcookie",
            //    LoginPath = new PathString("/Auth/Login")
            //});
            app.UseFacebookAuthentication(new Microsoft.Owin.Security.Facebook.FacebookAuthenticationOptions()
            {

                SignInAsAuthenticationType = "secretcookie"
            });
        }
        private void PrintCurrentIntegratedPipelineStage(IOwinContext context, string msg)
        {
            var currentIntegratedpipelineStage = HttpContext.Current.CurrentNotification;
            context.Get<TextWriter>("host.TraceOutput").WriteLine("Current IIS event: " + currentIntegratedpipelineStage + " Msg: " + msg);
        }
    }
}
