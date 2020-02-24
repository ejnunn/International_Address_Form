using International_Address_Form.Models;
using International_Web_Form.Models;
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
        [System.Web.Http.Route("~/api/addresses")]
        [System.Web.Http.HttpGet]
        [ProducesResponseType(typeof(IList<Form>),200)]
        public IHttpActionResult GetAllAddresses()
        {
            IList<Form> forms = null;
            using (var ctx = new WebFormEntity())
            {
                forms = ctx.TestAddresses.Select(s => new Form()
                {
                    Id = s.Id,
                    AddressLine0 = s.AddressLine0,
                    AddressLine1 = s.AddressLine1,
                    AddressLine2 = s.AddressLine2,
                    Country = s.Country,
                    Region = s.Region,
                    Locale = s.Locale,
                    Code = s.Code

                }).ToList<Form>();
            }
            if (forms == null)
            {
                return NotFound();
            }
            return Ok(forms);
        }
        [System.Web.Http.Route("~/api/address/{id:long}")]
        [System.Web.Http.HttpGet]
        [ProducesResponseType(typeof(Form), 200)]
        public IHttpActionResult GetAddress(long id)
        {
            Form form = null;

            using(var ctx = new WebFormEntity())
            {
                form = ctx.TestAddresses.Where(s => s.Id == id).Select(s => new Form()
                {
                    Id = s.Id,
                    AddressLine0 = s.AddressLine0,
                    AddressLine1 = s.AddressLine1,
                    AddressLine2 = s.AddressLine2,
                    Country = s.Country,
                    Region = s.Region,
                    Locale = s.Locale,
                    Code = s.Code
                }).FirstOrDefault<Form>();
            }
            if(form == null)
            {
                return NotFound();
            }
            return Ok(form);
        }
    
    }
}