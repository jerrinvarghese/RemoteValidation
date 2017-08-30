using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRemoteValidation.Startup))]
namespace MVCRemoteValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
