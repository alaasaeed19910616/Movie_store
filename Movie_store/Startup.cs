using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_store.Startup))]
namespace Movie_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
