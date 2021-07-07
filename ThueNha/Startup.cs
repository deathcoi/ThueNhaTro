using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThueNha.Startup))]
namespace ThueNha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
