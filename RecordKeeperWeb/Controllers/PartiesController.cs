using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordKeeperBizObjects;

namespace RecordKeeperWeb.Controllers
{
    public class PartiesController : Controller
    {
        public ActionResult Index()
        {
            List<bizParty> lst = bizParty.GetAll();
            return View(lst);
        }
        [EnableCors("Policy1")]
        public ActionResult APIPartyList()
        {
            List<bizParty> lst = bizParty.GetAll();
            return Json(lst);
        }

        // GET: PartiesController/Details/5
        public ActionResult Details(string id)
        {
            bizParty p = bizParty.Get("Party", id);
            return View(p);
        }

        // GET: PartiesController/Edit/5
        public ActionResult Edit(string id)
        {
            bizParty p; 
            if (string.IsNullOrEmpty(id))
            {
                p = new();
            }
            p = bizParty.Get("Party", id);
            return View(p);
        }

        // POST: PartiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(bizParty partyobj)
        {
            try
            {
                partyobj.Save();
                return RedirectToAction(nameof(Index));
            }
            catch (CPUFramework.CPUException ex)
            {
                partyobj = bizParty.Get(partyobj.PartyId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(partyobj);
            }
        }

        // GET: PartiesController/Delete/5
        public ActionResult Delete(string id)
        {
            bizParty p = bizParty.Get("Party", id);
            return View(p);
        }

        // POST: PartiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(bizParty p)
        {
            try
            {
                p.Delete();
                return RedirectToAction(nameof(Index));
            }
            catch(CPUFramework.CPUException ex)
            {
                p = bizParty.Get(p.PartyId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(p);
            }
        }
    }
}
