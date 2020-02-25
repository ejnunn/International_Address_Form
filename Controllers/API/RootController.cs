using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace International_Web_Form.Controllers.API
{
    public class RootController : ApiController
    {
        [System.Web.Http.Route("~/")]
        [System.Web.Http.HttpGet]
        [Produces(Models.ContentTypes.Root)]
        [ProducesResponseType(typeof(IDictionary<Models.ApplicationRelationship, object>), 200)]
        public IDictionary<Models.ApplicationRelationship, object> Get()
        {
            return new Dictionary<Models.ApplicationRelationship, object>()
            {
                {
                    Models.ApplicationRelationship.Addresses, new List<Models.DocumentLink>()
                    {
                        new Models.DocumentLink()
                        {
                            Method = Models.Method.Get,
                            Type = Models.ContentTypes.Addresses,
                            Relationship = Models.DocumentRelationship.Addresses,
                            Reference = "/api/Addresses"
                        },

                        new Models.DocumentLink()
                        {
                            Method = Models.Method.Get,
                            Type = Models.ContentTypes.Address,
                            Relationship = Models.DocumentRelationship.Address,
                            Reference = "/api/Address/{id}"
                        }
                    }
                },
                {
                    //
                    // and, we need to bump the timesheet version, we can argue whether
                    // this is considered a breaking change or not. i'm saying it's not
                    // in this case because all of our existing clients will continue
                    // to work without fail
                    //
                    Models.ApplicationRelationship.Version, "0.1"
                }
            };
        }
    }

}
