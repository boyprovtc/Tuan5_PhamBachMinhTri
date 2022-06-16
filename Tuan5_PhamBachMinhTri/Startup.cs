using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan5_PhamBachMinhTri.Startup))]
namespace Tuan5_PhamBachMinhTri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
