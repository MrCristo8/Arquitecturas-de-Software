using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TicketPremium_SOAP.DAO;
using TicketPremium_SOAP.Facade;
using TicketPremium_SOAP.Model;

namespace TicketPremium_SOAP.Service
{
    public class WSTicket : IWSTicket
    {
        
        public List<SoccerGame> getAvailableSoccerGames()
        {
            List<SoccerGame> list;
            try
            {
                DAOService service = new DAOService();
                list = service.getAvailableSoccerGames();
            } catch(Exception e)
            {
                list = new List<SoccerGame>();
            }
            return list;
        }

        public List<SoccerGame> getNotAvailableSoccerGames()
        {
            List<SoccerGame> list;
            try
            {
                DAOService service = new DAOService();
                list = service.getNotAvailableSoccerGames();
            }
            catch (Exception e)
            {
                list = new List<SoccerGame>();
            }
            return list;
        }

        public SoccerGame getSoccerGame(string code_soccergame)
        {
            SoccerGame soccerGame;
            try
            {
                DAOService service = new DAOService();
                soccerGame = service.getSoccerGame(code_soccergame);
            }
            catch (Exception e)
            {
                soccerGame = new SoccerGame();
            }
            return soccerGame;
        }

        public List<Client> getClients()
        {
            List<Client> list;
            try
            {
                DAOService service = new DAOService();
                list = service.getClients();
            }
            catch (Exception e)
            {
                list = new List<Client>();
            }
            return list;
        }

        public Bill updateLocalitiesSoccerGame(string code_client, DateTime date_bill, string way_pay, List<Locality> localities)
        {
            Bill bill = new Bill();
            try
            {
                DAOService service = new DAOService();
                List<Locality> list_loc = localities;
                if(list_loc != null && list_loc.Count >= 0 && code_client != null && !code_client.Equals(""))
                {
                    SoccerGame soccerGame = new SoccerGame()
                    {
                        code_soccergame = list_loc[0].code_soccergame,
                        localities = list_loc

                    };
                    bill = service.generateBill(soccerGame, date_bill, code_client, way_pay);
                }
                else
                {
                    bill = new Bill();
                }
                
            }
            catch (Exception e)
            {
                bill = new Bill();
            }
            return bill;
        }

        public SoccerGame getReportSoccerGame(string code_soccergame)
        {
            SoccerGame soccerGame;
            try
            {
                DAOService service = new DAOService();
                soccerGame = service.getReportSoccerGame(code_soccergame);
            }
            catch (Exception e)
            {
                soccerGame = new SoccerGame();
            }
            return soccerGame;
        }

        public List<Bill> getClientBills(string code_client)
        {
            List<Bill> list_bill;
            try
            {
                DAOService service = new DAOService();
                list_bill = service.getClientBills(code_client);
            }
            catch (Exception e)
            {
                list_bill = new List<Bill>();
            }
            return list_bill;
        }
    }
}
