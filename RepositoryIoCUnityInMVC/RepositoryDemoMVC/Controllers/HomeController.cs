using RepositoryDemo.Data;
using RepositoryDemo.Repository;
using System.Web.Mvc;

namespace RepositoryDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Customer, string> _customer;

        public HomeController(IRepository<Customer, string> customer)
        {
            _customer = customer;
        }

        public ActionResult Index()
        {
            var data = _customer.GetAll();
            return View(data);
        }
    }
}