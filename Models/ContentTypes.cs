using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace International_Web_Form.Models
{
    public class ContentTypes
    {
        private ContentTypes() { }

        public const string Root = "application/com.my-company.my-product.root+json";

        public const string Address = "application/com.my-company.my-product.address+json";

        public const string Addresses = "application/com.my-company.my-product.addresses+json";
    }
}