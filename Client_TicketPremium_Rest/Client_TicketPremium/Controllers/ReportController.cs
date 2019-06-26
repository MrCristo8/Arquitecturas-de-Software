using Client_TicketPremiun.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client_TicketPremium.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> SoccerGamesAvailable()
        {
            string ip = "192.168.1.114";
            var httpClient = new HttpClient();
            string urlEnviada = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getAvailableSoccerGames";
            var json = await httpClient.GetStreamAsync(urlEnviada);
            var soccerGamesList = JsonConvert.DeserializeObject<List<SoccerGame>>(json.ToString());

            return View(soccerGamesList);
        }

        public async Task<ActionResult> SoccerGamesNotAvailable()
        {
            string ip = "192.168.1.114";
            var httpClient = new HttpClient();
            string urlEnviada = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getNotAvailableSoccerGames";
            var json = await httpClient.GetStreamAsync(urlEnviada);
            var soccerGamesList = JsonConvert.DeserializeObject<List<SoccerGame>>(json.ToString());

            return View(soccerGamesList);
        }

        public async Task<ActionResult> GetReport()
        {
            string codeSoccerGame = Request["code"];

            string ip = "192.168.1.114";
            var httpClient = new HttpClient();

            string urlEnviada = "http://" + ip + ":8080/TicketPremium_Server_REST/WSTicket/getReportSoccerGame/" + codeSoccerGame;
            var json = await httpClient.GetStreamAsync(urlEnviada);
            SoccerGame soccerGame = JsonConvert.DeserializeObject<SoccerGame>(json.ToString());

            ViewBag.code = soccerGame.code_soccergame;
            return View(soccerGame);

        }

    }
}