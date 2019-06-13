using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketPremium_SOAP.Facade
{
    public class Locality
    {
        public string code_locality { get; set; }
        public string code_soccergame { get; set; }
        public int availability { get; set; }
        public float price { get; set; }
    }
}