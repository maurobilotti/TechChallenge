using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Southworks_TC.Startup))]
namespace Southworks_TC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
