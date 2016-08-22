using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMembership.Startup))]
namespace MyMembership
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
