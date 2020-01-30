using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaliSaha.Startup))]
namespace HaliSaha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
