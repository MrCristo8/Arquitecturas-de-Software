using Client_TicketPremiun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace Client_TicketPremium.Controllers
{
    public class BillsController : Controller
    {
        // GET: Bills
        public async Task<ActionResult> Buy()
        {
            string ip = "192.168.1.114";
            var httpClient = new HttpClient();
            string codeSoccerGame = Request["code"];

            string urlEnviada = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getSoccerGame/"+codeSoccerGame;
            var json = await httpClient.GetStreamAsync(urlEnviada);
            SoccerGame soccerGame = JsonConvert.DeserializeObject<SoccerGame>(json.ToString());

            string urlEnviada2 = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getClients/";
            var json2 = await httpClient.GetStreamAsync(urlEnviada2);
            List<Client> clientList = JsonConvert.DeserializeObject<List<Client>>(json2.ToString());

            ViewBag.clients = new SelectList(clientList, "code_client", "name_client");
            ViewBag.code = soccerGame.code_soccergame;
            return View(soccerGame);

        }

        [HttpPost]
        public async Task<ActionResult> Bill()
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
            string ip = "192.168.1.114";
            var httpClient = new HttpClient();

            string urlEnviada = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getSoccerGame/" + codeSoccerGame;
            var json = await httpClient.GetStreamAsync(urlEnviada);
            SoccerGame soccerGame = JsonConvert.DeserializeObject<SoccerGame>(json.ToString());
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

            string urlEnviada2 = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/updateLocalitiesSoccerGame/";

            HttpClient client = new HttpClient();


            Bill billCreated = await httpClient.PostAsync("AddNewArticle", new SoccerGame
            {
                code_soccergame = "",
                code_payway=codePayway,
                localities = listLocalities
            });

            float subTotal = billCreated.total/1.12f;
            ViewBag.subtotal = subTotal;
            ViewBag.iva = billCreated.total-subTotal;
            return View(billCreated);
 
        }

    }
}