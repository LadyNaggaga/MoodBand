using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoodBandSite.Startup))]
namespace MoodBandSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
