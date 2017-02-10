using IServices;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class BaseController : Controller
    {
        public IMainServices Services { get; set; }

        public BaseController()
        {
            Services = DependencyResolver.Current.GetService<IMainServices>();
        }
        
    }
}