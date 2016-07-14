using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListWithoutModelPass.Startup))]
namespace ListWithoutModelPass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
