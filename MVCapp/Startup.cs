using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCapp.Startup))]
namespace MVCapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
