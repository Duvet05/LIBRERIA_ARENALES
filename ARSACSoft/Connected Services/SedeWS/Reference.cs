﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARSACSoft.SedeWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", ConfigurationName="SedeWS.SedeWS")]
    public interface SedeWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/insertarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/insertarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.insertarSedeResponse insertarSede(ARSACSoft.SedeWS.insertarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/insertarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/insertarSedeResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.insertarSedeResponse> insertarSedeAsync(ARSACSoft.SedeWS.insertarSedeRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/listarSedesRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/listarSedesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.listarSedesResponse listarSedes(ARSACSoft.SedeWS.listarSedesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/listarSedesRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/listarSedesResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.listarSedesResponse> listarSedesAsync(ARSACSoft.SedeWS.listarSedesRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/eliminarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/eliminarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.eliminarSedeResponse eliminarSede(ARSACSoft.SedeWS.eliminarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/eliminarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/eliminarSedeResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.eliminarSedeResponse> eliminarSedeAsync(ARSACSoft.SedeWS.eliminarSedeRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/actualizarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/actualizarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.actualizarSedeResponse actualizarSede(ARSACSoft.SedeWS.actualizarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedeWS/actualizarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedeWS/actualizarSedeResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.actualizarSedeResponse> actualizarSedeAsync(ARSACSoft.SedeWS.actualizarSedeRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/")]
    public partial class sede : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string direccionField;
        
        private bool esAlmacenField;
        
        private int idSedeField;
        
        private string telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool esAlmacen {
            get {
                return this.esAlmacenField;
            }
            set {
                this.esAlmacenField = value;
                this.RaisePropertyChanged("esAlmacen");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idSede {
            get {
                return this.idSedeField;
            }
            set {
                this.idSedeField = value;
                this.RaisePropertyChanged("idSede");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarSede", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ARSACSoft.SedeWS.sede arg0;
        
        public insertarSedeRequest() {
        }
        
        public insertarSedeRequest(ARSACSoft.SedeWS.sede arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarSedeResponse", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarSedeResponse() {
        }
        
        public insertarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarSedes", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarSedesRequest {
        
        public listarSedesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarSedesResponse", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarSedesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ARSACSoft.SedeWS.sede[] @return;
        
        public listarSedesResponse() {
        }
        
        public listarSedesResponse(ARSACSoft.SedeWS.sede[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSede", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public eliminarSedeRequest() {
        }
        
        public eliminarSedeRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSedeResponse", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarSedeResponse() {
        }
        
        public eliminarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarSede", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class actualizarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ARSACSoft.SedeWS.sede arg0;
        
        public actualizarSedeRequest() {
        }
        
        public actualizarSedeRequest(ARSACSoft.SedeWS.sede arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarSedeResponse", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class actualizarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarSedeResponse() {
        }
        
        public actualizarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SedeWSChannel : ARSACSoft.SedeWS.SedeWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SedeWSClient : System.ServiceModel.ClientBase<ARSACSoft.SedeWS.SedeWS>, ARSACSoft.SedeWS.SedeWS {
        
        public SedeWSClient() {
        }
        
        public SedeWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SedeWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SedeWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SedeWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.insertarSedeResponse ARSACSoft.SedeWS.SedeWS.insertarSede(ARSACSoft.SedeWS.insertarSedeRequest request) {
            return base.Channel.insertarSede(request);
        }
        
        public int insertarSede(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.insertarSedeRequest inValue = new ARSACSoft.SedeWS.insertarSedeRequest();
            inValue.arg0 = arg0;
            ARSACSoft.SedeWS.insertarSedeResponse retVal = ((ARSACSoft.SedeWS.SedeWS)(this)).insertarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.insertarSedeResponse> ARSACSoft.SedeWS.SedeWS.insertarSedeAsync(ARSACSoft.SedeWS.insertarSedeRequest request) {
            return base.Channel.insertarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.insertarSedeResponse> insertarSedeAsync(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.insertarSedeRequest inValue = new ARSACSoft.SedeWS.insertarSedeRequest();
            inValue.arg0 = arg0;
            return ((ARSACSoft.SedeWS.SedeWS)(this)).insertarSedeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.listarSedesResponse ARSACSoft.SedeWS.SedeWS.listarSedes(ARSACSoft.SedeWS.listarSedesRequest request) {
            return base.Channel.listarSedes(request);
        }
        
        public ARSACSoft.SedeWS.sede[] listarSedes() {
            ARSACSoft.SedeWS.listarSedesRequest inValue = new ARSACSoft.SedeWS.listarSedesRequest();
            ARSACSoft.SedeWS.listarSedesResponse retVal = ((ARSACSoft.SedeWS.SedeWS)(this)).listarSedes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.listarSedesResponse> ARSACSoft.SedeWS.SedeWS.listarSedesAsync(ARSACSoft.SedeWS.listarSedesRequest request) {
            return base.Channel.listarSedesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.listarSedesResponse> listarSedesAsync() {
            ARSACSoft.SedeWS.listarSedesRequest inValue = new ARSACSoft.SedeWS.listarSedesRequest();
            return ((ARSACSoft.SedeWS.SedeWS)(this)).listarSedesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.eliminarSedeResponse ARSACSoft.SedeWS.SedeWS.eliminarSede(ARSACSoft.SedeWS.eliminarSedeRequest request) {
            return base.Channel.eliminarSede(request);
        }
        
        public int eliminarSede(int arg0) {
            ARSACSoft.SedeWS.eliminarSedeRequest inValue = new ARSACSoft.SedeWS.eliminarSedeRequest();
            inValue.arg0 = arg0;
            ARSACSoft.SedeWS.eliminarSedeResponse retVal = ((ARSACSoft.SedeWS.SedeWS)(this)).eliminarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.eliminarSedeResponse> ARSACSoft.SedeWS.SedeWS.eliminarSedeAsync(ARSACSoft.SedeWS.eliminarSedeRequest request) {
            return base.Channel.eliminarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.eliminarSedeResponse> eliminarSedeAsync(int arg0) {
            ARSACSoft.SedeWS.eliminarSedeRequest inValue = new ARSACSoft.SedeWS.eliminarSedeRequest();
            inValue.arg0 = arg0;
            return ((ARSACSoft.SedeWS.SedeWS)(this)).eliminarSedeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.actualizarSedeResponse ARSACSoft.SedeWS.SedeWS.actualizarSede(ARSACSoft.SedeWS.actualizarSedeRequest request) {
            return base.Channel.actualizarSede(request);
        }
        
        public int actualizarSede(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.actualizarSedeRequest inValue = new ARSACSoft.SedeWS.actualizarSedeRequest();
            inValue.arg0 = arg0;
            ARSACSoft.SedeWS.actualizarSedeResponse retVal = ((ARSACSoft.SedeWS.SedeWS)(this)).actualizarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.actualizarSedeResponse> ARSACSoft.SedeWS.SedeWS.actualizarSedeAsync(ARSACSoft.SedeWS.actualizarSedeRequest request) {
            return base.Channel.actualizarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.actualizarSedeResponse> actualizarSedeAsync(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.actualizarSedeRequest inValue = new ARSACSoft.SedeWS.actualizarSedeRequest();
            inValue.arg0 = arg0;
            return ((ARSACSoft.SedeWS.SedeWS)(this)).actualizarSedeAsync(inValue);
        }
    }
}