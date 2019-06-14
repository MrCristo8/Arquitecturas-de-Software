using System;
using Client_TicketPremium.WSTicket;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client_TicketPremium.Controllers
{
    public class ReportController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SoccerGamesAvailable()
        {
            using (WSTicket.WSTicketClient client = new WSTicket.WSTicketClient())
            {
                List<SoccerGame> soccerGamesAvailable = client.getAvailableSoccerGames().ToList();
                return View(soccerGamesAvailable);
            }
        }

        public ActionResult SoccerGamesNotAvailable()
        {
            using (WSTicket.WSTicketClient client = new WSTicket.WSTicketClient())
            {
                List<SoccerGame> soccerGamesNotAvailable = client.getNotAvailableSoccerGames().ToList();
                return View(soccerGamesNotAvailable);
            }
        }

        public ActionResult GetReport()
        {
            string codeSoccerGame = Request["code"];
            using (WSTicket.WSTicketClient client = new WSTicket.WSTicketClient())
            {
                SoccerGame soccerGame = client.getReportSoccerGame(codeSoccerGame);
                ViewBag.code = soccerGame.code_soccergame;
                return View(soccerGame);
            }
        }
    }
}