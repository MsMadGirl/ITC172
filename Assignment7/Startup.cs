using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorkAssignment7.Startup))]
namespace NorkAssignment7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
