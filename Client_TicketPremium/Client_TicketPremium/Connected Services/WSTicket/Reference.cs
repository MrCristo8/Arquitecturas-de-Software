﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_TicketPremium.WSTicket {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SoccerGame", Namespace="http://schemas.datacontract.org/2004/07/TicketPremium_SOAP.Facade")]
    [System.SerializableAttribute()]
    public partial class SoccerGame : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string code_soccergameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string date_soccergameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string local_teamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_TicketPremium.WSTicket.Locality[] localitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string placeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string visitor_teamField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code_soccergame {
            get {
                return this.code_soccergameField;
            }
            set {
                if ((object.ReferenceEquals(this.code_soccergameField, value) != true)) {
                    this.code_soccergameField = value;
                    this.RaisePropertyChanged("code_soccergame");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string date_soccergame {
            get {
                return this.date_soccergameField;
            }
            set {
                if ((object.ReferenceEquals(this.date_soccergameField, value) != true)) {
                    this.date_soccergameField = value;
                    this.RaisePropertyChanged("date_soccergame");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string local_team {
            get {
                return this.local_teamField;
            }
            set {
                if ((object.ReferenceEquals(this.local_teamField, value) != true)) {
                    this.local_teamField = value;
                    this.RaisePropertyChanged("local_team");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_TicketPremium.WSTicket.Locality[] localities {
            get {
                return this.localitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.localitiesField, value) != true)) {
                    this.localitiesField = value;
                    this.RaisePropertyChanged("localities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string place {
            get {
                return this.placeField;
            }
            set {
                if ((object.ReferenceEquals(this.placeField, value) != true)) {
                    this.placeField = value;
                    this.RaisePropertyChanged("place");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string visitor_team {
            get {
                return this.visitor_teamField;
            }
            set {
                if ((object.ReferenceEquals(this.visitor_teamField, value) != true)) {
                    this.visitor_teamField = value;
                    this.RaisePropertyChanged("visitor_team");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Locality", Namespace="http://schemas.datacontract.org/2004/07/TicketPremium_SOAP.Facade")]
    [System.SerializableAttribute()]
    public partial class Locality : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int availabilityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string code_localityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string code_soccergameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float priceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int availability {
            get {
                return this.availabilityField;
            }
            set {
                if ((this.availabilityField.Equals(value) != true)) {
                    this.availabilityField = value;
                    this.RaisePropertyChanged("availability");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code_locality {
            get {
                return this.code_localityField;
            }
            set {
                if ((object.ReferenceEquals(this.code_localityField, value) != true)) {
                    this.code_localityField = value;
                    this.RaisePropertyChanged("code_locality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code_soccergame {
            get {
                return this.code_soccergameField;
            }
            set {
                if ((object.ReferenceEquals(this.code_soccergameField, value) != true)) {
                    this.code_soccergameField = value;
                    this.RaisePropertyChanged("code_soccergame");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/TicketPremium_SOAP.Facade")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string code_clientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string name_clientField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code_client {
            get {
                return this.code_clientField;
            }
            set {
                if ((object.ReferenceEquals(this.code_clientField, value) != true)) {
                    this.code_clientField = value;
                    this.RaisePropertyChanged("code_client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name_client {
            get {
                return this.name_clientField;
            }
            set {
                if ((object.ReferenceEquals(this.name_clientField, value) != true)) {
                    this.name_clientField = value;
                    this.RaisePropertyChanged("name_client");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bill", Namespace="http://schemas.datacontract.org/2004/07/TicketPremium_SOAP.Facade")]
    [System.SerializableAttribute()]
    public partial class Bill : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int code_billField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string code_clientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string date_billField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string name_clientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_TicketPremium.WSTicket.SoccerGame soccer_gameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float totalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string way_payField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int code_bill {
            get {
                return this.code_billField;
            }
            set {
                if ((this.code_billField.Equals(value) != true)) {
                    this.code_billField = value;
                    this.RaisePropertyChanged("code_bill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code_client {
            get {
                return this.code_clientField;
            }
            set {
                if ((object.ReferenceEquals(this.code_clientField, value) != true)) {
                    this.code_clientField = value;
                    this.RaisePropertyChanged("code_client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string date_bill {
            get {
                return this.date_billField;
            }
            set {
                if ((object.ReferenceEquals(this.date_billField, value) != true)) {
                    this.date_billField = value;
                    this.RaisePropertyChanged("date_bill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name_client {
            get {
                return this.name_clientField;
            }
            set {
                if ((object.ReferenceEquals(this.name_clientField, value) != true)) {
                    this.name_clientField = value;
                    this.RaisePropertyChanged("name_client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_TicketPremium.WSTicket.SoccerGame soccer_game {
            get {
                return this.soccer_gameField;
            }
            set {
                if ((object.ReferenceEquals(this.soccer_gameField, value) != true)) {
                    this.soccer_gameField = value;
                    this.RaisePropertyChanged("soccer_game");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string way_pay {
            get {
                return this.way_payField;
            }
            set {
                if ((object.ReferenceEquals(this.way_payField, value) != true)) {
                    this.way_payField = value;
                    this.RaisePropertyChanged("way_pay");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSTicket.IWSTicket")]
    public interface IWSTicket {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getAvailableSoccerGames", ReplyAction="http://tempuri.org/IWSTicket/getAvailableSoccerGamesResponse")]
        Client_TicketPremium.WSTicket.SoccerGame[] getAvailableSoccerGames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getAvailableSoccerGames", ReplyAction="http://tempuri.org/IWSTicket/getAvailableSoccerGamesResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame[]> getAvailableSoccerGamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getNotAvailableSoccerGames", ReplyAction="http://tempuri.org/IWSTicket/getNotAvailableSoccerGamesResponse")]
        Client_TicketPremium.WSTicket.SoccerGame[] getNotAvailableSoccerGames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getNotAvailableSoccerGames", ReplyAction="http://tempuri.org/IWSTicket/getNotAvailableSoccerGamesResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame[]> getNotAvailableSoccerGamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getSoccerGame", ReplyAction="http://tempuri.org/IWSTicket/getSoccerGameResponse")]
        Client_TicketPremium.WSTicket.SoccerGame getSoccerGame(string code_soccergame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getSoccerGame", ReplyAction="http://tempuri.org/IWSTicket/getSoccerGameResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame> getSoccerGameAsync(string code_soccergame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getClients", ReplyAction="http://tempuri.org/IWSTicket/getClientsResponse")]
        Client_TicketPremium.WSTicket.Client[] getClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getClients", ReplyAction="http://tempuri.org/IWSTicket/getClientsResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.Client[]> getClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/updateLocalitiesSoccerGame", ReplyAction="http://tempuri.org/IWSTicket/updateLocalitiesSoccerGameResponse")]
        Client_TicketPremium.WSTicket.Bill updateLocalitiesSoccerGame(string code_client, System.DateTime date_bill, string way_pay, Client_TicketPremium.WSTicket.Locality[] localities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/updateLocalitiesSoccerGame", ReplyAction="http://tempuri.org/IWSTicket/updateLocalitiesSoccerGameResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.Bill> updateLocalitiesSoccerGameAsync(string code_client, System.DateTime date_bill, string way_pay, Client_TicketPremium.WSTicket.Locality[] localities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getReportSoccerGame", ReplyAction="http://tempuri.org/IWSTicket/getReportSoccerGameResponse")]
        Client_TicketPremium.WSTicket.SoccerGame getReportSoccerGame(string code_soccergame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getReportSoccerGame", ReplyAction="http://tempuri.org/IWSTicket/getReportSoccerGameResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame> getReportSoccerGameAsync(string code_soccergame);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getClientBills", ReplyAction="http://tempuri.org/IWSTicket/getClientBillsResponse")]
        Client_TicketPremium.WSTicket.Bill[] getClientBills(string code_client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSTicket/getClientBills", ReplyAction="http://tempuri.org/IWSTicket/getClientBillsResponse")]
        System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.Bill[]> getClientBillsAsync(string code_client);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSTicketChannel : Client_TicketPremium.WSTicket.IWSTicket, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSTicketClient : System.ServiceModel.ClientBase<Client_TicketPremium.WSTicket.IWSTicket>, Client_TicketPremium.WSTicket.IWSTicket {
        
        public WSTicketClient() {
        }
        
        public WSTicketClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSTicketClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTicketClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTicketClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_TicketPremium.WSTicket.SoccerGame[] getAvailableSoccerGames() {
            return base.Channel.getAvailableSoccerGames();
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame[]> getAvailableSoccerGamesAsync() {
            return base.Channel.getAvailableSoccerGamesAsync();
        }
        
        public Client_TicketPremium.WSTicket.SoccerGame[] getNotAvailableSoccerGames() {
            return base.Channel.getNotAvailableSoccerGames();
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame[]> getNotAvailableSoccerGamesAsync() {
            return base.Channel.getNotAvailableSoccerGamesAsync();
        }
        
        public Client_TicketPremium.WSTicket.SoccerGame getSoccerGame(string code_soccergame) {
            return base.Channel.getSoccerGame(code_soccergame);
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame> getSoccerGameAsync(string code_soccergame) {
            return base.Channel.getSoccerGameAsync(code_soccergame);
        }
        
        public Client_TicketPremium.WSTicket.Client[] getClients() {
            return base.Channel.getClients();
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.Client[]> getClientsAsync() {
            return base.Channel.getClientsAsync();
        }
        
        public Client_TicketPremium.WSTicket.Bill updateLocalitiesSoccerGame(string code_client, System.DateTime date_bill, string way_pay, Client_TicketPremium.WSTicket.Locality[] localities) {
            return base.Channel.updateLocalitiesSoccerGame(code_client, date_bill, way_pay, localities);
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.Bill> updateLocalitiesSoccerGameAsync(string code_client, System.DateTime date_bill, string way_pay, Client_TicketPremium.WSTicket.Locality[] localities) {
            return base.Channel.updateLocalitiesSoccerGameAsync(code_client, date_bill, way_pay, localities);
        }
        
        public Client_TicketPremium.WSTicket.SoccerGame getReportSoccerGame(string code_soccergame) {
            return base.Channel.getReportSoccerGame(code_soccergame);
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.SoccerGame> getReportSoccerGameAsync(string code_soccergame) {
            return base.Channel.getReportSoccerGameAsync(code_soccergame);
        }
        
        public Client_TicketPremium.WSTicket.Bill[] getClientBills(string code_client) {
            return base.Channel.getClientBills(code_client);
        }
        
        public System.Threading.Tasks.Task<Client_TicketPremium.WSTicket.Bill[]> getClientBillsAsync(string code_client) {
            return base.Channel.getClientBillsAsync(code_client);
        }
    }
}
