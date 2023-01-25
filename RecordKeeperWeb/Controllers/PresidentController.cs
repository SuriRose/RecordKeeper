using Microsoft.AspNetCore.Mvc;
using RecordKeeperBizObjects;
using CPUFramework;
using Microsoft.AspNetCore.Cors;

namespace RecordKeeperWeb.Controllers
{
    public class PresidentController : Controller
    {
        public IActionResult Index()
        {
            List<bizPresident> lst = bizPresident.GetAll();
            return View(lst);
        }

        [EnableCors("Policy1")]
        public IActionResult APIPresidentList()
        {
            List<bizPresident> lst = bizPresident.GetAll();
            return Json(lst);
        }
        public IActionResult President(string id)
        {
            bizPresident prez = bizPresident.Get("Code", id);
            //bizPresident prez = bizPresident.Get(Id);
            return View(prez);
        }
        public IActionResult Edit(string id)
        {
            bizPresident prez = bizPresident.Get("Code", id);
            //bizPresident prez = bizPresident.Get(Id);
            return View(prez);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(bizPresident prez)
        {
            try
            {
                prez.Save();
            }
            catch(CPUException ex)
            {
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                prez = bizPresident.Get(prez.PresidentId);
            }
            return View(prez);
        }
    }
}
