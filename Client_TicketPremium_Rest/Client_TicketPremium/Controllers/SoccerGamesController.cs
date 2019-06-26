using Client_TicketPremiun.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Client_TicketPremium.Controllers
{
    public class SoccerGamesController : Controller
    {
        // GET: SoccerGames
        public async Task<ActionResult> SoccerGames()
        {
            string ip = "192.168.1.114";
            var httpClient = new HttpClient();
            string urlEnviada = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getAvailableSoccerGames";
            var json = await httpClient.GetStreamAsync(urlEnviada);
            var soccerGamesList = JsonConvert.DeserializeObject<List<SoccerGame>>(json.ToString());

            return View(soccerGamesList);
        }
    }
}