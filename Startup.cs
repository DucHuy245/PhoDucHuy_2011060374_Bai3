using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoDucHuy_2011060374_Bai3.Startup))]
namespace PhoDucHuy_2011060374_Bai3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
