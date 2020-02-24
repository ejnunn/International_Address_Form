using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace International_Web_Form.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            IEnumerable<International_Address_Form.Models.Form> forms = null;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57215/api/forms");
                //HTTP GET
                var responseTask = client.GetAsync("forms");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<International_Address_Form.Models.Form>>();
                    readTask.Wait();
                    forms = readTask.Result;
                }
                else
                {
                    forms = Enumerable.Empty<International_Address_Form.Models.Form>();
                    ModelState.AddModelError(string.Empty, "Server Error.");
                }
            }
            return View(forms);
        }
    }
}