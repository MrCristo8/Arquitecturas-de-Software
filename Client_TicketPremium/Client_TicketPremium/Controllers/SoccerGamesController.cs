using Client_TicketPremium.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client_TicketPremium.Controllers
{
    public class SoccerGamesController : Controller
    {
        // GET: SoccerGames
        public ActionResult SoccerGames()
        {
            using (ServiceReference1.IserviceClient client=new ServiceReference1.IserviceClient())
            {
                List<PARTIDO_FUTBOL> soccerGames = client.Partidos().ToList();
                return View(soccerGames);
            }
        }
    }
}