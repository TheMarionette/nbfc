﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NbfcCli.NbfcService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FanControlInfo", Namespace="http://schemas.datacontract.org/2004/07/StagWare.FanControl.Service")]
    [System.SerializableAttribute()]
    public partial class FanControlInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EnabledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NbfcCli.NbfcService.FanStatus[] FanStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SelectedConfigField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemperatureSourceDisplayNameField;
        
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
        public bool Enabled {
            get {
                return this.EnabledField;
            }
            set {
                if ((this.EnabledField.Equals(value) != true)) {
                    this.EnabledField = value;
                    this.RaisePropertyChanged("Enabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NbfcCli.NbfcService.FanStatus[] FanStatus {
            get {
                return this.FanStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.FanStatusField, value) != true)) {
                    this.FanStatusField = value;
                    this.RaisePropertyChanged("FanStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SelectedConfig {
            get {
                return this.SelectedConfigField;
            }
            set {
                if ((object.ReferenceEquals(this.SelectedConfigField, value) != true)) {
                    this.SelectedConfigField = value;
                    this.RaisePropertyChanged("SelectedConfig");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((this.TemperatureField.Equals(value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TemperatureSourceDisplayName {
            get {
                return this.TemperatureSourceDisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TemperatureSourceDisplayNameField, value) != true)) {
                    this.TemperatureSourceDisplayNameField = value;
                    this.RaisePropertyChanged("TemperatureSourceDisplayName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FanStatus", Namespace="http://schemas.datacontract.org/2004/07/StagWare.FanControl.Service")]
    [System.SerializableAttribute()]
    public partial class FanStatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AutoControlEnabledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CriticalModeEnabledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float CurrentFanSpeedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FanDisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FanSpeedStepsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TargetFanSpeedField;
        
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
        public bool AutoControlEnabled {
            get {
                return this.AutoControlEnabledField;
            }
            set {
                if ((this.AutoControlEnabledField.Equals(value) != true)) {
                    this.AutoControlEnabledField = value;
                    this.RaisePropertyChanged("AutoControlEnabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CriticalModeEnabled {
            get {
                return this.CriticalModeEnabledField;
            }
            set {
                if ((this.CriticalModeEnabledField.Equals(value) != true)) {
                    this.CriticalModeEnabledField = value;
                    this.RaisePropertyChanged("CriticalModeEnabled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float CurrentFanSpeed {
            get {
                return this.CurrentFanSpeedField;
            }
            set {
                if ((this.CurrentFanSpeedField.Equals(value) != true)) {
                    this.CurrentFanSpeedField = value;
                    this.RaisePropertyChanged("CurrentFanSpeed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FanDisplayName {
            get {
                return this.FanDisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FanDisplayNameField, value) != true)) {
                    this.FanDisplayNameField = value;
                    this.RaisePropertyChanged("FanDisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FanSpeedSteps {
            get {
                return this.FanSpeedStepsField;
            }
            set {
                if ((this.FanSpeedStepsField.Equals(value) != true)) {
                    this.FanSpeedStepsField = value;
                    this.RaisePropertyChanged("FanSpeedSteps");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float TargetFanSpeed {
            get {
                return this.TargetFanSpeedField;
            }
            set {
                if ((this.TargetFanSpeedField.Equals(value) != true)) {
                    this.TargetFanSpeedField = value;
                    this.RaisePropertyChanged("TargetFanSpeed");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NbfcService.IFanControlService")]
    public interface IFanControlService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFanControlService/SetTargetFanSpeed")]
        void SetTargetFanSpeed(float value, int fanIndex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFanControlService/GetFanControlInfo", ReplyAction="http://tempuri.org/IFanControlService/GetFanControlInfoResponse")]
        NbfcCli.NbfcService.FanControlInfo GetFanControlInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFanControlService/Start", ReplyAction="http://tempuri.org/IFanControlService/StartResponse")]
        bool Start();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFanControlService/Stop")]
        void Stop();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFanControlService/SetConfig")]
        void SetConfig(string uniqueConfigId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFanControlServiceChannel : NbfcCli.NbfcService.IFanControlService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FanControlServiceClient : System.ServiceModel.ClientBase<NbfcCli.NbfcService.IFanControlService>, NbfcCli.NbfcService.IFanControlService {
        
        public FanControlServiceClient() {
        }
        
        public FanControlServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FanControlServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FanControlServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FanControlServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetTargetFanSpeed(float value, int fanIndex) {
            base.Channel.SetTargetFanSpeed(value, fanIndex);
        }
        
        public NbfcCli.NbfcService.FanControlInfo GetFanControlInfo() {
            return base.Channel.GetFanControlInfo();
        }
        
        public bool Start() {
            return base.Channel.Start();
        }
        
        public void Stop() {
            base.Channel.Stop();
        }
        
        public void SetConfig(string uniqueConfigId) {
            base.Channel.SetConfig(uniqueConfigId);
        }
    }
}
