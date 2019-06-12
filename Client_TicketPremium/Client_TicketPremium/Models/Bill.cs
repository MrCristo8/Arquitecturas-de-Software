using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client_TicketPremiun.Models
{
    public class Bill
    {
        public string code_client { get; set; }
        public string name_client { get; set; }
        public int code_bill { get; set; }
        public string date_bill { get; set; }
        public string way_pay { get; set; }
        public SoccerGame soccer_game { get; set; }
    }
}