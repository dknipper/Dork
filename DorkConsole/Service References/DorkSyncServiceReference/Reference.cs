﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DorkConsole.DorkSyncServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GoogleDorkSyncProgress", Namespace="http://schemas.datacontract.org/2004/07/DorkServices.DataContracts")]
    [System.SerializableAttribute()]
    public partial class GoogleDorkSyncProgress : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GhdbUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GoogleDorkParentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PercentageCompleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProcessedNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GhdbUrl {
            get {
                return this.GhdbUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.GhdbUrlField, value) != true)) {
                    this.GhdbUrlField = value;
                    this.RaisePropertyChanged("GhdbUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GoogleDorkParentName {
            get {
                return this.GoogleDorkParentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GoogleDorkParentNameField, value) != true)) {
                    this.GoogleDorkParentNameField = value;
                    this.RaisePropertyChanged("GoogleDorkParentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PercentageComplete {
            get {
                return this.PercentageCompleteField;
            }
            set {
                if ((this.PercentageCompleteField.Equals(value) != true)) {
                    this.PercentageCompleteField = value;
                    this.RaisePropertyChanged("PercentageComplete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProcessedNumber {
            get {
                return this.ProcessedNumberField;
            }
            set {
                if ((this.ProcessedNumberField.Equals(value) != true)) {
                    this.ProcessedNumberField = value;
                    this.RaisePropertyChanged("ProcessedNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DorkSyncServiceReference.IDorkSyncService", CallbackContract=typeof(DorkConsole.DorkSyncServiceReference.IDorkSyncServiceCallback))]
    public interface IDorkSyncService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDorkSyncService/SyncGoogleDorks")]
        void SyncGoogleDorks();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDorkSyncService/SyncGoogleDorks")]
        System.Threading.Tasks.Task SyncGoogleDorksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDorkSyncServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDorkSyncService/GoogleDorksProcessed", ReplyAction="http://tempuri.org/IDorkSyncService/GoogleDorksProcessedResponse")]
        void GoogleDorksProcessed(DorkConsole.DorkSyncServiceReference.GoogleDorkSyncProgress processedItem);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDorkSyncServiceChannel : DorkConsole.DorkSyncServiceReference.IDorkSyncService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DorkSyncServiceClient : System.ServiceModel.DuplexClientBase<DorkConsole.DorkSyncServiceReference.IDorkSyncService>, DorkConsole.DorkSyncServiceReference.IDorkSyncService {
        
        public DorkSyncServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DorkSyncServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DorkSyncServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DorkSyncServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DorkSyncServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SyncGoogleDorks() {
            base.Channel.SyncGoogleDorks();
        }
        
        public System.Threading.Tasks.Task SyncGoogleDorksAsync() {
            return base.Channel.SyncGoogleDorksAsync();
        }
    }
}
