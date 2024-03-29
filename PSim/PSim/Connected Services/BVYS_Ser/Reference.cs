﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSim.BVYS_Ser {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckk/BvysIslemleri", ConfigurationName="BVYS_Ser.BvysIslemleriWSInt")]
    public interface BvysIslemleriWSInt {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PSim.BVYS_Ser.bvysOnayBildirResponse bvysOnayBildir(PSim.BVYS_Ser.bvysOnayBildir request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<PSim.BVYS_Ser.bvysOnayBildirResponse> bvysOnayBildirAsync(PSim.BVYS_Ser.bvysOnayBildir request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tckk/BvysIslemleri")]
    public partial class standartWSSonuc : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool basariliField;
        
        private string hataAciklamaField;
        
        private int hataKoduField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool basarili {
            get {
                return this.basariliField;
            }
            set {
                this.basariliField = value;
                this.RaisePropertyChanged("basarili");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string hataAciklama {
            get {
                return this.hataAciklamaField;
            }
            set {
                this.hataAciklamaField = value;
                this.RaisePropertyChanged("hataAciklama");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int hataKodu {
            get {
                return this.hataKoduField;
            }
            set {
                this.hataKoduField = value;
                this.RaisePropertyChanged("hataKodu");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="bvysOnayBildir", WrapperNamespace="http://tckk/BvysIslemleri", IsWrapped=true)]
    public partial class bvysOnayBildir {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tckk/BvysIslemleri", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mernisIslemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tckk/BvysIslemleri", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] efDg3;
        
        public bvysOnayBildir() {
        }
        
        public bvysOnayBildir(string mernisIslemId, byte[] efDg3) {
            this.mernisIslemId = mernisIslemId;
            this.efDg3 = efDg3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="bvysOnayBildirResponse", WrapperNamespace="http://tckk/BvysIslemleri", IsWrapped=true)]
    public partial class bvysOnayBildirResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tckk/BvysIslemleri", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PSim.BVYS_Ser.standartWSSonuc @return;
        
        public bvysOnayBildirResponse() {
        }
        
        public bvysOnayBildirResponse(PSim.BVYS_Ser.standartWSSonuc @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BvysIslemleriWSIntChannel : PSim.BVYS_Ser.BvysIslemleriWSInt, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BvysIslemleriWSIntClient : System.ServiceModel.ClientBase<PSim.BVYS_Ser.BvysIslemleriWSInt>, PSim.BVYS_Ser.BvysIslemleriWSInt {
        
        public BvysIslemleriWSIntClient() {
        }
        
        public BvysIslemleriWSIntClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BvysIslemleriWSIntClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BvysIslemleriWSIntClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BvysIslemleriWSIntClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PSim.BVYS_Ser.bvysOnayBildirResponse PSim.BVYS_Ser.BvysIslemleriWSInt.bvysOnayBildir(PSim.BVYS_Ser.bvysOnayBildir request) {
            return base.Channel.bvysOnayBildir(request);
        }
        
        public PSim.BVYS_Ser.standartWSSonuc bvysOnayBildir(string mernisIslemId, byte[] efDg3) {
            PSim.BVYS_Ser.bvysOnayBildir inValue = new PSim.BVYS_Ser.bvysOnayBildir();
            inValue.mernisIslemId = mernisIslemId;
            inValue.efDg3 = efDg3;
            PSim.BVYS_Ser.bvysOnayBildirResponse retVal = ((PSim.BVYS_Ser.BvysIslemleriWSInt)(this)).bvysOnayBildir(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PSim.BVYS_Ser.bvysOnayBildirResponse> PSim.BVYS_Ser.BvysIslemleriWSInt.bvysOnayBildirAsync(PSim.BVYS_Ser.bvysOnayBildir request) {
            return base.Channel.bvysOnayBildirAsync(request);
        }
        
        public System.Threading.Tasks.Task<PSim.BVYS_Ser.bvysOnayBildirResponse> bvysOnayBildirAsync(string mernisIslemId, byte[] efDg3) {
            PSim.BVYS_Ser.bvysOnayBildir inValue = new PSim.BVYS_Ser.bvysOnayBildir();
            inValue.mernisIslemId = mernisIslemId;
            inValue.efDg3 = efDg3;
            return ((PSim.BVYS_Ser.BvysIslemleriWSInt)(this)).bvysOnayBildirAsync(inValue);
        }
    }
}
