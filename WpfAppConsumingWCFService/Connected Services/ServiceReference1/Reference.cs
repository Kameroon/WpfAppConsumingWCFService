﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppConsumingWCFService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdresseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Adresse {
            get {
                return this.AdresseField;
            }
            set {
                if ((object.ReferenceEquals(this.AdresseField, value) != true)) {
                    this.AdresseField = value;
                    this.RaisePropertyChanged("Adresse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersons", ReplyAction="http://tempuri.org/IService1/GetPersonsResponse")]
        WpfAppConsumingWCFService.ServiceReference1.Person[] GetPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersons", ReplyAction="http://tempuri.org/IService1/GetPersonsResponse")]
        System.Threading.Tasks.Task<WpfAppConsumingWCFService.ServiceReference1.Person[]> GetPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        bool InsertPerson(WpfAppConsumingWCFService.ServiceReference1.Person pObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        System.Threading.Tasks.Task<bool> InsertPersonAsync(WpfAppConsumingWCFService.ServiceReference1.Person pObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        bool UpdatePerson(WpfAppConsumingWCFService.ServiceReference1.Person pObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        System.Threading.Tasks.Task<bool> UpdatePersonAsync(WpfAppConsumingWCFService.ServiceReference1.Person pObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        bool DeletePerson(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        System.Threading.Tasks.Task<bool> DeletePersonAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonById", ReplyAction="http://tempuri.org/IService1/GetPersonByIdResponse")]
        WpfAppConsumingWCFService.ServiceReference1.Person GetPersonById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonById", ReplyAction="http://tempuri.org/IService1/GetPersonByIdResponse")]
        System.Threading.Tasks.Task<WpfAppConsumingWCFService.ServiceReference1.Person> GetPersonByIdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfAppConsumingWCFService.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfAppConsumingWCFService.ServiceReference1.IService1>, WpfAppConsumingWCFService.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfAppConsumingWCFService.ServiceReference1.Person[] GetPersons() {
            return base.Channel.GetPersons();
        }
        
        public System.Threading.Tasks.Task<WpfAppConsumingWCFService.ServiceReference1.Person[]> GetPersonsAsync() {
            return base.Channel.GetPersonsAsync();
        }
        
        public bool InsertPerson(WpfAppConsumingWCFService.ServiceReference1.Person pObj) {
            return base.Channel.InsertPerson(pObj);
        }
        
        public System.Threading.Tasks.Task<bool> InsertPersonAsync(WpfAppConsumingWCFService.ServiceReference1.Person pObj) {
            return base.Channel.InsertPersonAsync(pObj);
        }
        
        public bool UpdatePerson(WpfAppConsumingWCFService.ServiceReference1.Person pObj) {
            return base.Channel.UpdatePerson(pObj);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePersonAsync(WpfAppConsumingWCFService.ServiceReference1.Person pObj) {
            return base.Channel.UpdatePersonAsync(pObj);
        }
        
        public bool DeletePerson(string id) {
            return base.Channel.DeletePerson(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeletePersonAsync(string id) {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public WpfAppConsumingWCFService.ServiceReference1.Person GetPersonById(string id) {
            return base.Channel.GetPersonById(id);
        }
        
        public System.Threading.Tasks.Task<WpfAppConsumingWCFService.ServiceReference1.Person> GetPersonByIdAsync(string id) {
            return base.Channel.GetPersonByIdAsync(id);
        }
    }
}
