using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TicketPremium_SOAP.Facade;

namespace TicketPremium_SOAP.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSTicket" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSTicket
    {

        [OperationContract]
        List<SoccerGame> getAvailableSoccerGames();

        [OperationContract]
        List<SoccerGame> getNotAvailableSoccerGames();

        [OperationContract]
        SoccerGame getSoccerGame(string code_soccergame);

        [OperationContract]
        List<Client> getClients();

        [OperationContract]
        Bill updateLocalitiesSoccerGame(string code_client, DateTime date_bill, string way_pay, List<Locality> localities);

        [OperationContract]
        SoccerGame getReportSoccerGame(string code_soccergame);

        [OperationContract]
        List<Bill> getClientBills(string code_client);
    }
}
