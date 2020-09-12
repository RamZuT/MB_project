﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MB.WEB.ServicioPresupuesto {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioPresupuesto.IServicioPresupuesto")]
    public interface IServicioPresupuesto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPresupuesto/ObtenerPresupuestoPorFecha", ReplyAction="http://tempuri.org/IServicioPresupuesto/ObtenerPresupuestoPorFechaResponse")]
        MB.WCF.DataContract.DCPresupuesto ObtenerPresupuestoPorFecha(System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPresupuesto/ObtenerPresupuestoPorFecha", ReplyAction="http://tempuri.org/IServicioPresupuesto/ObtenerPresupuestoPorFechaResponse")]
        System.Threading.Tasks.Task<MB.WCF.DataContract.DCPresupuesto> ObtenerPresupuestoPorFechaAsync(System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPresupuesto/actualizaMontoRealPresupuesto", ReplyAction="http://tempuri.org/IServicioPresupuesto/actualizaMontoRealPresupuestoResponse")]
        bool actualizaMontoRealPresupuesto(System.DateTime fecha, System.Nullable<decimal> monto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPresupuesto/actualizaMontoRealPresupuesto", ReplyAction="http://tempuri.org/IServicioPresupuesto/actualizaMontoRealPresupuestoResponse")]
        System.Threading.Tasks.Task<bool> actualizaMontoRealPresupuestoAsync(System.DateTime fecha, System.Nullable<decimal> monto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPresupuestoChannel : MB.WEB.ServicioPresupuesto.IServicioPresupuesto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPresupuestoClient : System.ServiceModel.ClientBase<MB.WEB.ServicioPresupuesto.IServicioPresupuesto>, MB.WEB.ServicioPresupuesto.IServicioPresupuesto {
        
        public ServicioPresupuestoClient() {
        }
        
        public ServicioPresupuestoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPresupuestoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPresupuestoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPresupuestoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MB.WCF.DataContract.DCPresupuesto ObtenerPresupuestoPorFecha(System.DateTime fecha) {
            return base.Channel.ObtenerPresupuestoPorFecha(fecha);
        }
        
        public System.Threading.Tasks.Task<MB.WCF.DataContract.DCPresupuesto> ObtenerPresupuestoPorFechaAsync(System.DateTime fecha) {
            return base.Channel.ObtenerPresupuestoPorFechaAsync(fecha);
        }
        
        public bool actualizaMontoRealPresupuesto(System.DateTime fecha, System.Nullable<decimal> monto) {
            return base.Channel.actualizaMontoRealPresupuesto(fecha, monto);
        }
        
        public System.Threading.Tasks.Task<bool> actualizaMontoRealPresupuestoAsync(System.DateTime fecha, System.Nullable<decimal> monto) {
            return base.Channel.actualizaMontoRealPresupuestoAsync(fecha, monto);
        }
    }
}
