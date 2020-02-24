using International_Address_Form.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace International_Address_Form.Controllers
{
    public class FormController : ApiController
    {
        Form[] TestForms = new Form[]
        {
            new Form {Id = 001, AddressLine0 = "901 12th Ave", Country = "United States", Region = "Washington", Locale = "Seattle", Code = 98122}, 
            new Form {Id = 002, AddressLine0 = "1200 E Pike st.", AddressLine1 = "Apt. 407", Country = "United States", Region = "Washington", Locale = "Seattle", Code = 98122}
        };

        [System.Web.Http.Route("~/Forms")]
        [System.Web.Http.HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Form>),200)]
        public IEnumerable<Form> GetAllForms()
        {
            return TestForms;
        }

        [System.Web.Http.Route("~/Forms/{id:long}")]
        [System.Web.Http.HttpGet]
        [ProducesResponseType(typeof(Form), 200)]
        public IHttpActionResult GetForm(long id)
        {
            var form = TestForms.FirstOrDefault((f) => f.Id == id);
            if (form == null)
            {
                return NotFound();
            }
            return Ok(form);
        }
    }
}