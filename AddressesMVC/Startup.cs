using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressesMVC.Startup))]
namespace AddressesMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
