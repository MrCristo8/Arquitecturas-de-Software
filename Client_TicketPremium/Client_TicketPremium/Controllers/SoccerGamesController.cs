using Client_TicketPremium.WSTicket;
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
            using (WSTicket.WSTicketClient client=new WSTicket.WSTicketClient())
            {
                List<SoccerGame> soccerGames = client.getAvailableSoccerGames().ToList();
                return View(soccerGames);
            }
        }
    }
}