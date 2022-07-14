using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddressBook.Web.Startup))]
namespace AddressBook.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
