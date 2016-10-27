using RepositoryDemo.Data;
using RepositoryDemo.Repository;
using System.Web.Mvc;

namespace RepositoryDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository<Customer> repository;

        public HomeController(IRepository<Customer> repository)
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