using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketPremium_SOAP.Facade;
using TicketPremium_SOAP.Model;

namespace TicketPremium_SOAP.DAO
{
    public class DAOService
    {
        public List<SoccerGame> getAvailableSoccerGames()
        {
            List<SoccerGame> list_result = new List<SoccerGame>();
            try
            {
                List <SoccerGame> gamelist = null;
                DateTime dateTime = DateTime.Now;
                using (ticketpremiumEntities db = new ticketpremiumEntities())
                {
                    gamelist = (from d in db.TEPAF_PARFUT
                                where d.TEPAF_FECHA > dateTime
                                orderby d.TEPAF_FECHA ascending
                                select new SoccerGame
                                {
                                    code_soccergame = d.TEPAF_CODIGO,
                                    local_team = d.TEPAF_LOCAL,
                                    visitor_team = d.TEPAF_VISITA,
                                    date_soccergame = d.TEPAF_FECHA.ToString(),
                                    place = d.TEPAF_LUGAR
                                }).ToList();
                }
                if(gamelist == null)
                {
                    list_result = null;
                }
                else
                {
                    list_result = gamelist;
                }
            } catch(Exception e)
            {
                list_result = null;
                Console.WriteLine(e.ToString());
            }
            return list_result;
        }

        public List<SoccerGame> getNotAvailableSoccerGames()
        {
            List<SoccerGame> list_result = new List<SoccerGame>();
            try
            {
                List<SoccerGame> gamelist = null;
                DateTime dateTime = DateTime.Now;
                using (ticketpremiumEntities db = new ticketpremiumEntities())
                {
                    gamelist = (from d in db.TEPAF_PARFUT
                                where d.TEPAF_FECHA < dateTime
                                orderby d.TEPAF_FECHA ascending
                                select new SoccerGame
                                {
                                    code_soccergame = d.TEPAF_CODIGO,
                                    local_team = d.TEPAF_LOCAL,
                                    visitor_team = d.TEPAF_VISITA,
                                    date_soccergame = d.TEPAF_FECHA.ToString(),
                                    place = d.TEPAF_LUGAR
                                }).ToList();
                }
                if (gamelist == null)
                {
                    list_result = null;
                }
                else
                {
                    list_result = gamelist;
                }
            }
            catch (Exception e)
            {
                list_result = null;
                Console.WriteLine(e.ToString());
            }
            return list_result;
        }

        public SoccerGame getSoccerGame(string code_soccergame)
        {
            SoccerGame soccergame = new SoccerGame();
            try
            {                
                using (ticketpremiumEntities db = new ticketpremiumEntities())
                {
                    var aux = db.TEPAF_PARFUT.Find(code_soccergame);
                    soccergame.code_soccergame = aux.TEPAF_CODIGO;
                    soccergame.date_soccergame = aux.TEPAF_FECHA.ToString();
                    soccergame.local_team = aux.TEPAF_LOCAL;
                    soccergame.visitor_team = aux.TEPAF_VISITA;
                    soccergame.place = aux.TEPAF_LUGAR;
                    var localities = aux.TELCP_LOCPTD;
                    List<Locality> list_localities = new List<Locality>();
                    foreach(TELCP_LOCPTD aux_locality in localities)
                    {
                        if((aux_locality.TELCP_CANBAS - aux_locality.TELCP_DISPON) > 0)
                        {
                            list_localities.Add(new Locality()
                            {
                                code_locality = aux_locality.TELCP_CODIGO,
                                code_soccergame = aux_locality.TEPAF_CODIGO,
                                availability = aux_locality.TELCP_CANBAS - aux_locality.TELCP_DISPON,
                                price = (float) aux_locality.TELCP_PRECIO
                            });
                        }
                    }
                    soccergame.localities = list_localities;
                }
            }
            catch (Exception e)
            {
                soccergame = null;
            }
            return soccergame;
        }

        public List<Client> getClients()
        {
            List<Client> list_result = new List<Client>();
            try
            {
                List<Client> clientlist = null;
                DateTime dateTime = DateTime.Now;
                using (ticketpremiumEntities db = new ticketpremiumEntities())
                {
                    clientlist = (from d in db.TECLI_CLIENT
                                select new Client
                                {
                                    code_client = d.TECLI_CODIGO,
                                    name_client = d.TECLI_NOMBRE
                                }).ToList();
                }
                if (clientlist == null)
                {
                    list_result = new List<Client>();
                }
                else
                {
                    list_result = clientlist;
                }
            }
            catch (Exception e)
            {
                list_result = new List<Client>();
            }
            return list_result;
        }

        private bool updateLocality(TELCP_LOCPTD obj)
        {
            try
            {
                using (var db = new ticketpremiumEntities())
                {
                    var locality = db.TELCP_LOCPTD.Find(obj.TELCP_CODIGO, obj.TEPAF_CODIGO);
                    locality.TELCP_DISPON = obj.TELCP_DISPON;
                    db.Entry(locality).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool createDetail(TEDEF_DETFAC obj)
        {
            try
            {
                using (var db = new ticketpremiumEntities())
                {
                    db.TEDEF_DETFAC.Add(obj);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private SoccerGame updateLocalitiesSoccerGame(SoccerGame client_soccergame)
        {
            SoccerGame result_soccergame = getSoccerGame(client_soccergame.code_soccergame);
            if(result_soccergame == null)
            {
                return null;
            }
            List<Locality> list_location = new List<Locality>();
            try
            {
                foreach (Locality aux in client_soccergame.localities)
                {
                    TELCP_LOCPTD telcpLocptd = null;
                    using (ticketpremiumEntities db = new ticketpremiumEntities())
                    {
                        telcpLocptd = db.TELCP_LOCPTD.Find(aux.code_locality, aux.code_soccergame);
                    }
                    if (telcpLocptd != null && ((telcpLocptd.TELCP_CANBAS - telcpLocptd.TELCP_DISPON) >= aux.availability) && aux.availability > 0)
                    {
                        TELCP_LOCPTD locality = telcpLocptd;
                        locality.TELCP_DISPON = locality.TELCP_DISPON + aux.availability;
                        if (updateLocality(locality))
                        {
                            list_location.Add(new Locality()
                            {
                                code_locality = locality.TELCP_CODIGO,
                                code_soccergame = locality.TEPAF_CODIGO,
                                availability = aux.availability,
                                price = (float)(aux.availability * locality.TELCP_PRECIO)
                            });
                        }
                    }
                }
                result_soccergame.localities = list_location;
            }catch(Exception e)
            {
                result_soccergame = null;
            }
            return result_soccergame;
        }

        public Bill generateBill(SoccerGame soccerGame, DateTime date_bill, string code_client, string mod_pag)
        {
            Bill bill = null;
            try
            {
                TECLI_CLIENT client = null;
                using (var db = new ticketpremiumEntities())
                {
                    client = db.TECLI_CLIENT.Find(code_client);                    
                }
                if (client != null)
                {
                    SoccerGame result_soccergame = updateLocalitiesSoccerGame(soccerGame);
                    if(result_soccergame != null)
                    {
                        int bill_code_saved = 0;
                        float total = 0;
                        using (var db = new ticketpremiumEntities())
                        {
                            TEFAC_FACTUR aux_bill = new TEFAC_FACTUR();
                            aux_bill.TECLI_CODIGO = client.TECLI_CODIGO;
                            aux_bill.TEFAC_FECHA = date_bill;
                            aux_bill.TEFAC_MODPAG = mod_pag;
                            foreach(Locality locality in result_soccergame.localities)
                            {
                                total += locality.price;
                            }
                            aux_bill.TEFAC_TOTAL = total;

                            db.TEFAC_FACTUR.Add(aux_bill);
                            db.SaveChanges();

                            
                            bill_code_saved = aux_bill.TEFAC_CODIGO;
                        }

                        if(bill_code_saved > 0)
                        {
                            List<Locality> localities_bill = new List<Locality>();
                            foreach(Locality locality in result_soccergame.localities)
                            {
                                TEDEF_DETFAC tedef_detfac = new TEDEF_DETFAC();
                                tedef_detfac.TELCP_CODIGO = locality.code_locality;
                                tedef_detfac.TEPAF_CODIGO = locality.code_soccergame;
                                tedef_detfac.TEFAC_CODIGO = bill_code_saved;
                                tedef_detfac.TEDEF_CANTID = locality.availability;
                                tedef_detfac.TEDEF_SUBTOT = locality.price;
                                if (createDetail(tedef_detfac))
                                {
                                    localities_bill.Add(locality);
                                }
                            }
                            result_soccergame.localities = localities_bill;
                            bill = new Bill();
                            bill.code_client = client.TECLI_CODIGO;
                            bill.name_client = client.TECLI_NOMBRE;
                            bill.code_bill = bill_code_saved;
                            bill.date_bill = date_bill.ToString();
                            bill.way_pay = mod_pag;
                            bill.total = total;
                            bill.soccer_game = result_soccergame;
                        }
                        else
                        {
                            bill = null;
                        }

                    }
                    else
                    {
                        bill = null;
                    }
                }
                else
                {
                    bill = null;
                }

            }
            catch(Exception e)
            {
                bill = null;
            }
            return bill;
        }

        public SoccerGame getReportSoccerGame(string code_soccergame)
        {
            SoccerGame soccergame = new SoccerGame();
            try
            {
                using (ticketpremiumEntities db = new ticketpremiumEntities())
                {
                    var aux = db.TEPAF_PARFUT.Find(code_soccergame);
                    soccergame.code_soccergame = aux.TEPAF_CODIGO;
                    soccergame.date_soccergame = aux.TEPAF_FECHA.ToString();
                    soccergame.local_team = aux.TEPAF_LOCAL;
                    soccergame.visitor_team = aux.TEPAF_VISITA;
                    soccergame.place = aux.TEPAF_LUGAR;
                    var localities = aux.TELCP_LOCPTD;
                    List<Locality> list_localities = new List<Locality>();
                    foreach (TELCP_LOCPTD aux_locality in localities)
                    {                        
                            list_localities.Add(new Locality()
                            {
                                code_locality = aux_locality.TELCP_CODIGO,
                                code_soccergame = aux_locality.TEPAF_CODIGO,
                                availability = aux_locality.TELCP_DISPON,
                                price = (float)(aux_locality.TELCP_PRECIO * aux_locality.TELCP_DISPON)
                            });
                        
                    }
                    soccergame.localities = list_localities;
                }
            }
            catch (Exception e)
            {
                soccergame = null;
            }
            return soccergame;
        }

        public List<Bill> getClientBills(string code_client)
        {
            List<Bill> list_result = new List<Bill>();
            try
            {
                List<Bill> billList = null;
                using (ticketpremiumEntities db = new ticketpremiumEntities())
                {
                    billList = (from d in db.TEFAC_FACTUR
                                where d.TECLI_CODIGO == code_client
                                select new Bill
                                {
                                    code_client = d.TECLI_CODIGO,
                                    name_client = d.TECLI_CLIENT.TECLI_NOMBRE,
                                    code_bill = d.TEFAC_CODIGO,
                                    date_bill = d.TEFAC_FECHA.ToString(),
                                    way_pay = d.TEFAC_MODPAG,
                                    total = (float) d.TEFAC_TOTAL
                                }).ToList();
                }
                if (billList != null)
                {
                    for(int i = 0; i < billList.Count; i++)
                    {
                        SoccerGame soccer_game = new SoccerGame();
                        List<TEDEF_DETFAC> list_detfac = new List<TEDEF_DETFAC>();
                        int aux_code_bill = billList[i].code_bill;
                        TEPAF_PARFUT aux_soccergame = new TEPAF_PARFUT();
                        using (ticketpremiumEntities db = new ticketpremiumEntities())
                        {
                            list_detfac = (from d in db.TEDEF_DETFAC
                                                              where d.TEFAC_CODIGO == aux_code_bill
                                                              select d).ToList();
                            aux_soccergame = db.TEPAF_PARFUT.Find(list_detfac[0].TEPAF_CODIGO);


                        }
                         
                        soccer_game = new SoccerGame()
                        {
                            code_soccergame = aux_soccergame.TEPAF_CODIGO,
                            local_team = aux_soccergame.TEPAF_LOCAL,
                            visitor_team = aux_soccergame.TEPAF_VISITA,
                            place = aux_soccergame.TEPAF_LUGAR,
                            date_soccergame = aux_soccergame.TEPAF_FECHA.ToString()
                        };
                        List<Locality> list_localities = new List<Locality>();
                        foreach(TEDEF_DETFAC aux in list_detfac)
                        {
                            Locality new_locality = new Locality()
                            {
                                code_locality = aux.TELCP_CODIGO,
                                code_soccergame = aux.TEPAF_CODIGO,
                                availability = aux.TEDEF_CANTID,
                                price = (float) aux.TEDEF_SUBTOT
                            };
                            list_localities.Add(new_locality);
                        }
                        soccer_game.localities = list_localities;
                        billList[i].soccer_game = soccer_game;
                    }

                    list_result = billList;
                }
                else
                {
                    list_result = null;
                }
            }
            catch (Exception e)
            {
                list_result = null;
            }
            return list_result;
        }
    }
}