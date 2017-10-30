using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidRent.Startup))]
namespace vidRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
