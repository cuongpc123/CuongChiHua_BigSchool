using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChiCuong_bigschool.Startup))]
namespace ChiCuong_bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
