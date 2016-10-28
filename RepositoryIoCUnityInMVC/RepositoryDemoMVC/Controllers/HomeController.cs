using RepositoryDemo.Model;
using RepositoryDemo.Repository;
using System.Web.Mvc;

namespace RepositoryDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository<CustomerModel> repository;

        public HomeController(IRepository<CustomerModel> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll();
            return View(data);
        }
    }
}