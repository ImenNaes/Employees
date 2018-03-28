using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employees.Startup))]
namespace Employees
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
