using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerLoggerSupport.Startup))]
namespace CustomerLoggerSupport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
