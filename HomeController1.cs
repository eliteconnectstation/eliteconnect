using Microsoft.AspNetCore.Mvc;

namespace InsuranceProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string role)
        {
            if (role == "Admin")
                return RedirectToAction("AdminDashboard");

            if (role == "Agent")
                return RedirectToAction("AgentDashboard");

            if (role == "Client")
                return RedirectToAction("ClientDashboard");

            return View();
        }

        public IActionResult AdminDashboard()
        {
            ViewBag.Role = "Admin";
            return View("Dashboard");
        }

        public IActionResult AgentDashboard()
        {
            ViewBag.Role = "Agent";
            return View("Dashboard");
        }

        public IActionResult ClientDashboard()
        {
            ViewBag.Role = "Client";
            return View("Dashboard");
        }
    }
}