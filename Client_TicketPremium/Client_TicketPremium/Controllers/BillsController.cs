using System;
using Client_TicketPremium.WSTicket;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client_TicketPremium.Controllers
{
    public class BillsController : Controller
    {
        // GET: Bills
        public ActionResult Buy()
        {
            string codeSoccerGame = Request["code"];
            using (WSTicket.WSTicketClient client = new WSTicket.WSTicketClient())
            {
                SoccerGame soccerGame = client.getSoccerGame(codeSoccerGame);
                ViewBag.clients = new SelectList(client.getClients().ToList(), "code_client", "name_client");
                ViewBag.code = soccerGame.code_soccergame;
                return View(soccerGame);
            }
        }

        [HttpPost]
        public ActionResult Bill()
        {
            string codeClient = Request["clients"];
            string codePayway = Request["payway"];
            int quantityGeneral = 0;
            int quantityPalco = 0;
            int quantityTribuna = 0;
            if (Int32.TryParse(Request["GENERAL"], out int auxGeneral))
            {
                quantityGeneral = auxGeneral;
            }
            if (Int32.TryParse(Request["PALCO"], out int auxPalco))
            {
                quantityPalco = auxPalco;
            }
            if (Int32.TryParse(Request["TRIBUNA"], out int auxTribuna))
            {
                quantityTribuna = auxTribuna;
            }

            string codeSoccerGame = Request["code"];
            using (WSTicket.WSTicketClient client = new WSTicket.WSTicketClient())
            {
                SoccerGame soccerGame = client.getSoccerGame(codeSoccerGame);
                List<Locality> listLocalities = soccerGame.localities.ToList();
                foreach (Locality l in listLocalities)
                {
                    if (l.code_locality.Equals("GENERAL"))
                    {
                        l.availability = quantityGeneral;
                    }
                    if (l.code_locality.Equals("PALCO"))
                    {
                        l.availability = quantityPalco;
                    }
                    if (l.code_locality.Equals("TRIBUNA"))
                    {
                        l.availability = quantityTribuna;
                    }
                }
                Bill billCreated = client.updateLocalitiesSoccerGame(codeClient, DateTime.Now, codePayway, listLocalities.ToArray());
                return View(billCreated);
            }



        }

    }
}