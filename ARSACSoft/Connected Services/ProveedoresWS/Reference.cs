﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARSACSoft.ProveedoresWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.arsacsoft.pucp.edu.pe/", ConfigurationName="ProveedoresWS.ProveedoresWS")]
    public interface ProveedoresWS {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/ProveedoresWS/helloRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/ProveedoresWS/helloResponse")]
        ARSACSoft.ProveedoresWS.helloResponse hello(ARSACSoft.ProveedoresWS.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.arsacsoft.pucp.edu.pe/ProveedoresWS/helloRequest", ReplyAction="http://services.arsacsoft.pucp.edu.pe/ProveedoresWS/helloResponse")]
        System.Threading.Tasks.Task<ARSACSoft.ProveedoresWS.helloResponse> helloAsync(ARSACSoft.ProveedoresWS.helloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        public ARSACSoft.ProveedoresWS.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(ARSACSoft.ProveedoresWS.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://services.arsacsoft.pucp.edu.pe/", Order=0)]
        public ARSACSoft.ProveedoresWS.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(ARSACSoft.ProveedoresWS.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProveedoresWSChannel : ARSACSoft.ProveedoresWS.ProveedoresWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProveedoresWSClient : System.ServiceModel.ClientBase<ARSACSoft.ProveedoresWS.ProveedoresWS>, ARSACSoft.ProveedoresWS.ProveedoresWS {
        
        public ProveedoresWSClient() {
        }
        
        public ProveedoresWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProveedoresWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProveedoresWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProveedoresWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ARSACSoft.ProveedoresWS.helloResponse ARSACSoft.ProveedoresWS.ProveedoresWS.hello(ARSACSoft.ProveedoresWS.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            ARSACSoft.ProveedoresWS.helloRequest inValue = new ARSACSoft.ProveedoresWS.helloRequest();
            inValue.Body = new ARSACSoft.ProveedoresWS.helloRequestBody();
            inValue.Body.name = name;
            ARSACSoft.ProveedoresWS.helloResponse retVal = ((ARSACSoft.ProveedoresWS.ProveedoresWS)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ARSACSoft.ProveedoresWS.helloResponse> ARSACSoft.ProveedoresWS.ProveedoresWS.helloAsync(ARSACSoft.ProveedoresWS.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ARSACSoft.ProveedoresWS.helloResponse> helloAsync(string name) {
            ARSACSoft.ProveedoresWS.helloRequest inValue = new ARSACSoft.ProveedoresWS.helloRequest();
            inValue.Body = new ARSACSoft.ProveedoresWS.helloRequestBody();
            inValue.Body.name = name;
            return ((ARSACSoft.ProveedoresWS.ProveedoresWS)(this)).helloAsync(inValue);
        }
    }
}