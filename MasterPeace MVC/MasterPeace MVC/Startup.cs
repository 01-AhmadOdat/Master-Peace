using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterPeace_MVC.Startup))]
namespace MasterPeace_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
