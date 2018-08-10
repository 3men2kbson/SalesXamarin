using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesXamarin.BackEnd.Startup))]
namespace SalesXamarin.BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
