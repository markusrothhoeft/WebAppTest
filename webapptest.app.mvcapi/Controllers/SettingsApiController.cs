using System.Web.Mvc;
using System.Web.Http;
using webapptest.app.mvcapi.Models;

namespace webapptest.app.mvcapi.Controllers
{
    public class SettingsAPiController : ApiController
    {
        // Post api/SettingsAPi/ModuleSettingData
        public string PostModuleSettingData (HelpClass sendData)
        {
            string text = Newtonsoft.Json.JsonConvert.SerializeObject(sendData);
            var testObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ModuleSettingsViewModel>(text);

            if (ModelState.IsValid)
            {
                return "valid";
            }
            return text;
        }
    }
}
