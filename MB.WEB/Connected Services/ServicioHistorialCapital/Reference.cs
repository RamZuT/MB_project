﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MB.WEB.ServicioHistorialCapital {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioHistorialCapital.IServicioHistorialCapital")]
    public interface IServicioHistorialCapital {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/registroHistCapital", ReplyAction="http://tempuri.org/IServicioHistorialCapital/registroHistCapitalResponse")]
        void registroHistCapital(System.DateTime fechaCorte, bool estado, int ingresoGasto, decimal monto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/registroHistCapital", ReplyAction="http://tempuri.org/IServicioHistorialCapital/registroHistCapitalResponse")]
        System.Threading.Tasks.Task registroHistCapitalAsync(System.DateTime fechaCorte, bool estado, int ingresoGasto, decimal monto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioHistorialCapitalChannel : MB.WEB.ServicioHistorialCapital.IServicioHistorialCapital, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioHistorialCapitalClient : System.ServiceModel.ClientBase<MB.WEB.ServicioHistorialCapital.IServicioHistorialCapital>, MB.WEB.ServicioHistorialCapital.IServicioHistorialCapital {
        
        public ServicioHistorialCapitalClient() {
        }
        
        public ServicioHistorialCapitalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioHistorialCapitalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioHistorialCapitalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioHistorialCapitalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void registroHistCapital(System.DateTime fechaCorte, bool estado, int ingresoGasto, decimal monto) {
            base.Channel.registroHistCapital(fechaCorte, estado, ingresoGasto, monto);
        }
        
        public System.Threading.Tasks.Task registroHistCapitalAsync(System.DateTime fechaCorte, bool estado, int ingresoGasto, decimal monto) {
            return base.Channel.registroHistCapitalAsync(fechaCorte, estado, ingresoGasto, monto);
        }
    }
}