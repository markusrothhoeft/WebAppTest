using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Newtonsoft.Json.Linq;
using webapptest.app.mvcapi.Models;

namespace webapptest.app.mvcapi.Controllers
{
    public class SettingsController : Controller
    {
        [HttpGet]
        public ActionResult ModuleSettings()
        {
            return View(new ModuleSettingsViewModel());
        }
        // POST: /Module/ModuleSettings
        [HttpPost]
        public ActionResult ModuleSettings(ModuleSettingsViewModel settings, string returnUrl)
        {

            string testJson = Newtonsoft.Json.JsonConvert.SerializeObject(new ModuleSettingsViewModel());
            var testObj = Newtonsoft.Json.JsonConvert.DeserializeObject<HelpClass>(testJson);


            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            var json = Json(settings);
            var view = View();
            return View(settings);
        }

        [HttpPost]
        public ActionResult SendData(HelpClass settings)
        {
            return Json(settings);
        }
    }
}
