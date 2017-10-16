using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examen_01.Startup))]
namespace Examen_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
