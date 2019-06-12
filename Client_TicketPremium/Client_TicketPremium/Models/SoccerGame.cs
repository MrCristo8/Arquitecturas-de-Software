using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client_TicketPremiun.Models
{
    public class SoccerGame
    {
        public string code_soccergame { get; set; }
        public string local_team { get; set; }
        public string visitor_team { get; set; }
        public string place { get; set; }
        public string date_soccergame { get; set; }
        public List<Locality> localities { get; set; }

    }
}