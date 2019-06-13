﻿using System;
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
        public ActionResult Buy(string codeSoccerGame)
        {
            using (WSTicket.WSTicketClient client = new WSTicket.WSTicketClient())
            {
                SoccerGame soccerGame = client.getSoccerGame(codeSoccerGame);
                return View(soccerGame);
            }
            return View();
        }
    }
}