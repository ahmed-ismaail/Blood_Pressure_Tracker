﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace New.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DietPlanClass", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DietPlanClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vegesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fruitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string meatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string drinksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string milkField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string veges {
            get {
                return this.vegesField;
            }
            set {
                if ((object.ReferenceEquals(this.vegesField, value) != true)) {
                    this.vegesField = value;
                    this.RaisePropertyChanged("veges");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string fruit {
            get {
                return this.fruitField;
            }
            set {
                if ((object.ReferenceEquals(this.fruitField, value) != true)) {
                    this.fruitField = value;
                    this.RaisePropertyChanged("fruit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string meat {
            get {
                return this.meatField;
            }
            set {
                if ((object.ReferenceEquals(this.meatField, value) != true)) {
                    this.meatField = value;
                    this.RaisePropertyChanged("meat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string drinks {
            get {
                return this.drinksField;
            }
            set {
                if ((object.ReferenceEquals(this.drinksField, value) != true)) {
                    this.drinksField = value;
                    this.RaisePropertyChanged("drinks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string milk {
            get {
                return this.milkField;
            }
            set {
                if ((object.ReferenceEquals(this.milkField, value) != true)) {
                    this.milkField = value;
                    this.RaisePropertyChanged("milk");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginFunc", ReplyAction="*")]
        New.ServiceReference1.LoginFuncResponse LoginFunc(New.ServiceReference1.LoginFuncRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginFunc", ReplyAction="*")]
        System.Threading.Tasks.Task<New.ServiceReference1.LoginFuncResponse> LoginFuncAsync(New.ServiceReference1.LoginFuncRequest request);
        
        // CODEGEN: Generating message contract since element name type from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ViewDietPlan", ReplyAction="*")]
        New.ServiceReference1.ViewDietPlanResponse ViewDietPlan(New.ServiceReference1.ViewDietPlanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ViewDietPlan", ReplyAction="*")]
        System.Threading.Tasks.Task<New.ServiceReference1.ViewDietPlanResponse> ViewDietPlanAsync(New.ServiceReference1.ViewDietPlanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendEmail", ReplyAction="*")]
        void SendEmail();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendEmail", ReplyAction="*")]
        System.Threading.Tasks.Task SendEmailAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginFuncRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginFunc", Namespace="http://tempuri.org/", Order=0)]
        public New.ServiceReference1.LoginFuncRequestBody Body;
        
        public LoginFuncRequest() {
        }
        
        public LoginFuncRequest(New.ServiceReference1.LoginFuncRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginFuncRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginFuncRequestBody() {
        }
        
        public LoginFuncRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginFuncResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginFuncResponse", Namespace="http://tempuri.org/", Order=0)]
        public New.ServiceReference1.LoginFuncResponseBody Body;
        
        public LoginFuncResponse() {
        }
        
        public LoginFuncResponse(New.ServiceReference1.LoginFuncResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginFuncResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoginFuncResult;
        
        public LoginFuncResponseBody() {
        }
        
        public LoginFuncResponseBody(bool LoginFuncResult) {
            this.LoginFuncResult = LoginFuncResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ViewDietPlanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ViewDietPlan", Namespace="http://tempuri.org/", Order=0)]
        public New.ServiceReference1.ViewDietPlanRequestBody Body;
        
        public ViewDietPlanRequest() {
        }
        
        public ViewDietPlanRequest(New.ServiceReference1.ViewDietPlanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ViewDietPlanRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string type;
        
        public ViewDietPlanRequestBody() {
        }
        
        public ViewDietPlanRequestBody(string type) {
            this.type = type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ViewDietPlanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ViewDietPlanResponse", Namespace="http://tempuri.org/", Order=0)]
        public New.ServiceReference1.ViewDietPlanResponseBody Body;
        
        public ViewDietPlanResponse() {
        }
        
        public ViewDietPlanResponse(New.ServiceReference1.ViewDietPlanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ViewDietPlanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public New.ServiceReference1.DietPlanClass ViewDietPlanResult;
        
        public ViewDietPlanResponseBody() {
        }
        
        public ViewDietPlanResponseBody(New.ServiceReference1.DietPlanClass ViewDietPlanResult) {
            this.ViewDietPlanResult = ViewDietPlanResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : New.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<New.ServiceReference1.WebService1Soap>, New.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        New.ServiceReference1.LoginFuncResponse New.ServiceReference1.WebService1Soap.LoginFunc(New.ServiceReference1.LoginFuncRequest request) {
            return base.Channel.LoginFunc(request);
        }
        
        public bool LoginFunc(string email, string password) {
            New.ServiceReference1.LoginFuncRequest inValue = new New.ServiceReference1.LoginFuncRequest();
            inValue.Body = new New.ServiceReference1.LoginFuncRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            New.ServiceReference1.LoginFuncResponse retVal = ((New.ServiceReference1.WebService1Soap)(this)).LoginFunc(inValue);
            return retVal.Body.LoginFuncResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<New.ServiceReference1.LoginFuncResponse> New.ServiceReference1.WebService1Soap.LoginFuncAsync(New.ServiceReference1.LoginFuncRequest request) {
            return base.Channel.LoginFuncAsync(request);
        }
        
        public System.Threading.Tasks.Task<New.ServiceReference1.LoginFuncResponse> LoginFuncAsync(string email, string password) {
            New.ServiceReference1.LoginFuncRequest inValue = new New.ServiceReference1.LoginFuncRequest();
            inValue.Body = new New.ServiceReference1.LoginFuncRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((New.ServiceReference1.WebService1Soap)(this)).LoginFuncAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        New.ServiceReference1.ViewDietPlanResponse New.ServiceReference1.WebService1Soap.ViewDietPlan(New.ServiceReference1.ViewDietPlanRequest request) {
            return base.Channel.ViewDietPlan(request);
        }
        
        public New.ServiceReference1.DietPlanClass ViewDietPlan(string type) {
            New.ServiceReference1.ViewDietPlanRequest inValue = new New.ServiceReference1.ViewDietPlanRequest();
            inValue.Body = new New.ServiceReference1.ViewDietPlanRequestBody();
            inValue.Body.type = type;
            New.ServiceReference1.ViewDietPlanResponse retVal = ((New.ServiceReference1.WebService1Soap)(this)).ViewDietPlan(inValue);
            return retVal.Body.ViewDietPlanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<New.ServiceReference1.ViewDietPlanResponse> New.ServiceReference1.WebService1Soap.ViewDietPlanAsync(New.ServiceReference1.ViewDietPlanRequest request) {
            return base.Channel.ViewDietPlanAsync(request);
        }
        
        public System.Threading.Tasks.Task<New.ServiceReference1.ViewDietPlanResponse> ViewDietPlanAsync(string type) {
            New.ServiceReference1.ViewDietPlanRequest inValue = new New.ServiceReference1.ViewDietPlanRequest();
            inValue.Body = new New.ServiceReference1.ViewDietPlanRequestBody();
            inValue.Body.type = type;
            return ((New.ServiceReference1.WebService1Soap)(this)).ViewDietPlanAsync(inValue);
        }
        
        public void SendEmail() {
            base.Channel.SendEmail();
        }
        
        public System.Threading.Tasks.Task SendEmailAsync() {
            return base.Channel.SendEmailAsync();
        }
    }
}
