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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", ConfigurationName="SedeWS.SedesWS")]
    public interface SedesWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/listarSedesRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/listarSedesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.listarSedesResponse listarSedes(ARSACSoft.SedeWS.listarSedesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/listarSedesRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/listarSedesResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.listarSedesResponse> listarSedesAsync(ARSACSoft.SedeWS.listarSedesRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/eliminarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/eliminarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.eliminarSedeResponse eliminarSede(ARSACSoft.SedeWS.eliminarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/eliminarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/eliminarSedeResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.eliminarSedeResponse> eliminarSedeAsync(ARSACSoft.SedeWS.eliminarSedeRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/insertarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/insertarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.insertarSedeResponse insertarSede(ARSACSoft.SedeWS.insertarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/insertarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/insertarSedeResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.insertarSedeResponse> insertarSedeAsync(ARSACSoft.SedeWS.insertarSedeRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/modificarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/modificarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ARSACSoft.SedeWS.modificarSedeResponse modificarSede(ARSACSoft.SedeWS.modificarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/SedesWS/modificarSedeRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/SedesWS/modificarSedeResponse")]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.modificarSedeResponse> modificarSedeAsync(ARSACSoft.SedeWS.modificarSedeRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/")]
    public partial class sede : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string direccionField;
        
        private bool esPrincipalField;
        
        private int idSedeField;
        
        private producto[] productosField;
        
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
        public bool esPrincipal {
            get {
                return this.esPrincipalField;
            }
            set {
                this.esPrincipalField = value;
                this.RaisePropertyChanged("esPrincipal");
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
        [System.Xml.Serialization.XmlElementAttribute("productos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=4)]
        public producto[] productos {
            get {
                return this.productosField;
            }
            set {
                this.productosField = value;
                this.RaisePropertyChanged("productos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/")]
    public partial class producto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private categoria categoriaField;
        
        private byte[] fotoField;
        
        private int idProductoField;
        
        private marca marcaField;
        
        private string nombreField;
        
        private double precioPorMayorField;
        
        private double precioPorMenorField;
        
        private promocion promocionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public categoria categoria {
            get {
                return this.categoriaField;
            }
            set {
                this.categoriaField = value;
                this.RaisePropertyChanged("categoria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=2)]
        public byte[] foto {
            get {
                return this.fotoField;
            }
            set {
                this.fotoField = value;
                this.RaisePropertyChanged("foto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
                this.RaisePropertyChanged("idProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public marca marca {
            get {
                return this.marcaField;
            }
            set {
                this.marcaField = value;
                this.RaisePropertyChanged("marca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double precioPorMayor {
            get {
                return this.precioPorMayorField;
            }
            set {
                this.precioPorMayorField = value;
                this.RaisePropertyChanged("precioPorMayor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double precioPorMenor {
            get {
                return this.precioPorMenorField;
            }
            set {
                this.precioPorMenorField = value;
                this.RaisePropertyChanged("precioPorMenor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public promocion promocion {
            get {
                return this.promocionField;
            }
            set {
                this.promocionField = value;
                this.RaisePropertyChanged("promocion");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/")]
    public partial class categoria : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string descripcionField;
        
        private int idCategoriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idCategoria {
            get {
                return this.idCategoriaField;
            }
            set {
                this.idCategoriaField = value;
                this.RaisePropertyChanged("idCategoria");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/")]
    public partial class promocion : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int cantidadminimaField;
        
        private System.DateTime fechaFinField;
        
        private bool fechaFinFieldSpecified;
        
        private System.DateTime fechaInicioField;
        
        private bool fechaInicioFieldSpecified;
        
        private int idPromocionField;
        
        private double porcentajeField;
        
        private producto productoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int cantidadminima {
            get {
                return this.cantidadminimaField;
            }
            set {
                this.cantidadminimaField = value;
                this.RaisePropertyChanged("cantidadminima");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime fechaFin {
            get {
                return this.fechaFinField;
            }
            set {
                this.fechaFinField = value;
                this.RaisePropertyChanged("fechaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaFinSpecified {
            get {
                return this.fechaFinFieldSpecified;
            }
            set {
                this.fechaFinFieldSpecified = value;
                this.RaisePropertyChanged("fechaFinSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime fechaInicio {
            get {
                return this.fechaInicioField;
            }
            set {
                this.fechaInicioField = value;
                this.RaisePropertyChanged("fechaInicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaInicioSpecified {
            get {
                return this.fechaInicioFieldSpecified;
            }
            set {
                this.fechaInicioFieldSpecified = value;
                this.RaisePropertyChanged("fechaInicioSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idPromocion {
            get {
                return this.idPromocionField;
            }
            set {
                this.idPromocionField = value;
                this.RaisePropertyChanged("idPromocion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double porcentaje {
            get {
                return this.porcentajeField;
            }
            set {
                this.porcentajeField = value;
                this.RaisePropertyChanged("porcentaje");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public producto producto {
            get {
                return this.productoField;
            }
            set {
                this.productoField = value;
                this.RaisePropertyChanged("producto");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/")]
    public partial class marca : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string descripcionField;
        
        private int idMarcaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idMarca {
            get {
                return this.idMarcaField;
            }
            set {
                this.idMarcaField = value;
                this.RaisePropertyChanged("idMarca");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarSede", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ARSACSoft.SedeWS.sede arg0;
        
        public modificarSedeRequest() {
        }
        
        public modificarSedeRequest(ARSACSoft.SedeWS.sede arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarSedeResponse", WrapperNamespace="http://services.arsacsoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarSedeResponse() {
        }
        
        public modificarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SedesWSChannel : ARSACSoft.SedeWS.SedesWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SedesWSClient : System.ServiceModel.ClientBase<ARSACSoft.SedeWS.SedesWS>, ARSACSoft.SedeWS.SedesWS {
        
        public SedesWSClient() {
        }
        
        public SedesWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SedesWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SedesWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SedesWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.listarSedesResponse ARSACSoft.SedeWS.SedesWS.listarSedes(ARSACSoft.SedeWS.listarSedesRequest request) {
            return base.Channel.listarSedes(request);
        }
        
        public ARSACSoft.SedeWS.sede[] listarSedes() {
            ARSACSoft.SedeWS.listarSedesRequest inValue = new ARSACSoft.SedeWS.listarSedesRequest();
            ARSACSoft.SedeWS.listarSedesResponse retVal = ((ARSACSoft.SedeWS.SedesWS)(this)).listarSedes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.listarSedesResponse> ARSACSoft.SedeWS.SedesWS.listarSedesAsync(ARSACSoft.SedeWS.listarSedesRequest request) {
            return base.Channel.listarSedesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.listarSedesResponse> listarSedesAsync() {
            ARSACSoft.SedeWS.listarSedesRequest inValue = new ARSACSoft.SedeWS.listarSedesRequest();
            return ((ARSACSoft.SedeWS.SedesWS)(this)).listarSedesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.eliminarSedeResponse ARSACSoft.SedeWS.SedesWS.eliminarSede(ARSACSoft.SedeWS.eliminarSedeRequest request) {
            return base.Channel.eliminarSede(request);
        }
        
        public int eliminarSede(int arg0) {
            ARSACSoft.SedeWS.eliminarSedeRequest inValue = new ARSACSoft.SedeWS.eliminarSedeRequest();
            inValue.arg0 = arg0;
            ARSACSoft.SedeWS.eliminarSedeResponse retVal = ((ARSACSoft.SedeWS.SedesWS)(this)).eliminarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.eliminarSedeResponse> ARSACSoft.SedeWS.SedesWS.eliminarSedeAsync(ARSACSoft.SedeWS.eliminarSedeRequest request) {
            return base.Channel.eliminarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.eliminarSedeResponse> eliminarSedeAsync(int arg0) {
            ARSACSoft.SedeWS.eliminarSedeRequest inValue = new ARSACSoft.SedeWS.eliminarSedeRequest();
            inValue.arg0 = arg0;
            return ((ARSACSoft.SedeWS.SedesWS)(this)).eliminarSedeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.insertarSedeResponse ARSACSoft.SedeWS.SedesWS.insertarSede(ARSACSoft.SedeWS.insertarSedeRequest request) {
            return base.Channel.insertarSede(request);
        }
        
        public int insertarSede(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.insertarSedeRequest inValue = new ARSACSoft.SedeWS.insertarSedeRequest();
            inValue.arg0 = arg0;
            ARSACSoft.SedeWS.insertarSedeResponse retVal = ((ARSACSoft.SedeWS.SedesWS)(this)).insertarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.insertarSedeResponse> ARSACSoft.SedeWS.SedesWS.insertarSedeAsync(ARSACSoft.SedeWS.insertarSedeRequest request) {
            return base.Channel.insertarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.insertarSedeResponse> insertarSedeAsync(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.insertarSedeRequest inValue = new ARSACSoft.SedeWS.insertarSedeRequest();
            inValue.arg0 = arg0;
            return ((ARSACSoft.SedeWS.SedesWS)(this)).insertarSedeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.SedeWS.modificarSedeResponse ARSACSoft.SedeWS.SedesWS.modificarSede(ARSACSoft.SedeWS.modificarSedeRequest request) {
            return base.Channel.modificarSede(request);
        }
        
        public int modificarSede(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.modificarSedeRequest inValue = new ARSACSoft.SedeWS.modificarSedeRequest();
            inValue.arg0 = arg0;
            ARSACSoft.SedeWS.modificarSedeResponse retVal = ((ARSACSoft.SedeWS.SedesWS)(this)).modificarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.SedeWS.modificarSedeResponse> ARSACSoft.SedeWS.SedesWS.modificarSedeAsync(ARSACSoft.SedeWS.modificarSedeRequest request) {
            return base.Channel.modificarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.SedeWS.modificarSedeResponse> modificarSedeAsync(ARSACSoft.SedeWS.sede arg0) {
            ARSACSoft.SedeWS.modificarSedeRequest inValue = new ARSACSoft.SedeWS.modificarSedeRequest();
            inValue.arg0 = arg0;
            return ((ARSACSoft.SedeWS.SedesWS)(this)).modificarSedeAsync(inValue);
        }
    }
}
