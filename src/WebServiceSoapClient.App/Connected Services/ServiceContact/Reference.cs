﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceSoapClient.App.ServiceContact {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebServiceSoapClient.App.ServiceContact.Address AddressField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public WebServiceSoapClient.App.ServiceContact.Address Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        private int NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseModelOfString", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ResponseModelOfString : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataField;
        
        private int ResultCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ResultCode {
            get {
                return this.ResultCodeField;
            }
            set {
                if ((this.ResultCodeField.Equals(value) != true)) {
                    this.ResultCodeField = value;
                    this.RaisePropertyChanged("ResultCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceContact.WebServiceContactSoap")]
    public interface WebServiceContactSoap {
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento HelloWorldResult no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebServiceSoapClient.App.ServiceContact.HelloWorldResponse HelloWorld(WebServiceSoapClient.App.ServiceContact.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.HelloWorldResponse> HelloWorldAsync(WebServiceSoapClient.App.ServiceContact.HelloWorldRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento GetAllContactsResult no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllContacts", ReplyAction="*")]
        WebServiceSoapClient.App.ServiceContact.GetAllContactsResponse GetAllContacts(WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllContacts", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.GetAllContactsResponse> GetAllContactsAsync(WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento contact no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddContact", ReplyAction="*")]
        WebServiceSoapClient.App.ServiceContact.AddContactResponse AddContact(WebServiceSoapClient.App.ServiceContact.AddContactRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddContact", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.AddContactResponse> AddContactAsync(WebServiceSoapClient.App.ServiceContact.AddContactRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceSoapClient.App.ServiceContact.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebServiceSoapClient.App.ServiceContact.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceSoapClient.App.ServiceContact.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebServiceSoapClient.App.ServiceContact.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllContactsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllContacts", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceSoapClient.App.ServiceContact.GetAllContactsRequestBody Body;
        
        public GetAllContactsRequest() {
        }
        
        public GetAllContactsRequest(WebServiceSoapClient.App.ServiceContact.GetAllContactsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllContactsRequestBody {
        
        public GetAllContactsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllContactsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllContactsResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceSoapClient.App.ServiceContact.GetAllContactsResponseBody Body;
        
        public GetAllContactsResponse() {
        }
        
        public GetAllContactsResponse(WebServiceSoapClient.App.ServiceContact.GetAllContactsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllContactsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceSoapClient.App.ServiceContact.Contact[] GetAllContactsResult;
        
        public GetAllContactsResponseBody() {
        }
        
        public GetAllContactsResponseBody(WebServiceSoapClient.App.ServiceContact.Contact[] GetAllContactsResult) {
            this.GetAllContactsResult = GetAllContactsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddContactRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddContact", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceSoapClient.App.ServiceContact.AddContactRequestBody Body;
        
        public AddContactRequest() {
        }
        
        public AddContactRequest(WebServiceSoapClient.App.ServiceContact.AddContactRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddContactRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceSoapClient.App.ServiceContact.Contact contact;
        
        public AddContactRequestBody() {
        }
        
        public AddContactRequestBody(WebServiceSoapClient.App.ServiceContact.Contact contact) {
            this.contact = contact;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddContactResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddContactResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceSoapClient.App.ServiceContact.AddContactResponseBody Body;
        
        public AddContactResponse() {
        }
        
        public AddContactResponse(WebServiceSoapClient.App.ServiceContact.AddContactResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddContactResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceSoapClient.App.ServiceContact.ResponseModelOfString AddContactResult;
        
        public AddContactResponseBody() {
        }
        
        public AddContactResponseBody(WebServiceSoapClient.App.ServiceContact.ResponseModelOfString AddContactResult) {
            this.AddContactResult = AddContactResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceContactSoapChannel : WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceContactSoapClient : System.ServiceModel.ClientBase<WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap>, WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap {
        
        public WebServiceContactSoapClient() {
        }
        
        public WebServiceContactSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceContactSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceContactSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceContactSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceSoapClient.App.ServiceContact.HelloWorldResponse WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap.HelloWorld(WebServiceSoapClient.App.ServiceContact.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebServiceSoapClient.App.ServiceContact.HelloWorldRequest inValue = new WebServiceSoapClient.App.ServiceContact.HelloWorldRequest();
            inValue.Body = new WebServiceSoapClient.App.ServiceContact.HelloWorldRequestBody();
            WebServiceSoapClient.App.ServiceContact.HelloWorldResponse retVal = ((WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.HelloWorldResponse> WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap.HelloWorldAsync(WebServiceSoapClient.App.ServiceContact.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.HelloWorldResponse> HelloWorldAsync() {
            WebServiceSoapClient.App.ServiceContact.HelloWorldRequest inValue = new WebServiceSoapClient.App.ServiceContact.HelloWorldRequest();
            inValue.Body = new WebServiceSoapClient.App.ServiceContact.HelloWorldRequestBody();
            return ((WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceSoapClient.App.ServiceContact.GetAllContactsResponse WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap.GetAllContacts(WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest request) {
            return base.Channel.GetAllContacts(request);
        }
        
        public WebServiceSoapClient.App.ServiceContact.Contact[] GetAllContacts() {
            WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest inValue = new WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest();
            inValue.Body = new WebServiceSoapClient.App.ServiceContact.GetAllContactsRequestBody();
            WebServiceSoapClient.App.ServiceContact.GetAllContactsResponse retVal = ((WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap)(this)).GetAllContacts(inValue);
            return retVal.Body.GetAllContactsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.GetAllContactsResponse> WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap.GetAllContactsAsync(WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest request) {
            return base.Channel.GetAllContactsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.GetAllContactsResponse> GetAllContactsAsync() {
            WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest inValue = new WebServiceSoapClient.App.ServiceContact.GetAllContactsRequest();
            inValue.Body = new WebServiceSoapClient.App.ServiceContact.GetAllContactsRequestBody();
            return ((WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap)(this)).GetAllContactsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceSoapClient.App.ServiceContact.AddContactResponse WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap.AddContact(WebServiceSoapClient.App.ServiceContact.AddContactRequest request) {
            return base.Channel.AddContact(request);
        }
        
        public WebServiceSoapClient.App.ServiceContact.ResponseModelOfString AddContact(WebServiceSoapClient.App.ServiceContact.Contact contact) {
            WebServiceSoapClient.App.ServiceContact.AddContactRequest inValue = new WebServiceSoapClient.App.ServiceContact.AddContactRequest();
            inValue.Body = new WebServiceSoapClient.App.ServiceContact.AddContactRequestBody();
            inValue.Body.contact = contact;
            WebServiceSoapClient.App.ServiceContact.AddContactResponse retVal = ((WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap)(this)).AddContact(inValue);
            return retVal.Body.AddContactResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.AddContactResponse> WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap.AddContactAsync(WebServiceSoapClient.App.ServiceContact.AddContactRequest request) {
            return base.Channel.AddContactAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceSoapClient.App.ServiceContact.AddContactResponse> AddContactAsync(WebServiceSoapClient.App.ServiceContact.Contact contact) {
            WebServiceSoapClient.App.ServiceContact.AddContactRequest inValue = new WebServiceSoapClient.App.ServiceContact.AddContactRequest();
            inValue.Body = new WebServiceSoapClient.App.ServiceContact.AddContactRequestBody();
            inValue.Body.contact = contact;
            return ((WebServiceSoapClient.App.ServiceContact.WebServiceContactSoap)(this)).AddContactAsync(inValue);
        }
    }
}
