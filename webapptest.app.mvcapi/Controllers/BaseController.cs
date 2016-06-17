using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using webapptest.app.mvcapi.Logic;

namespace webapptest.app.mvcapi.Controllers
{
    /// <summary>
    /// Basisklasse für unsere Controller um JSON.Net zu verwenden
    /// </summary>
    public abstract class BaseController : Controller
    {
        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding)
//        public JsonResult JsonNet(object data, string contentType, System.Text.Encoding contentEncoding)
        {
            return new JsonNetResult
            {
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                Data = data
            };
        }

        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
  //      public JsonResult JsonNet(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult
            {
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                Data = data,
                JsonRequestBehavior = behavior
            };
        }
    }   
}
