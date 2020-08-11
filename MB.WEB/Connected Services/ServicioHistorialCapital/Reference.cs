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
        bool registroHistCapital(decimal monto, System.DateTime fechaCorte, bool estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/registroHistCapital", ReplyAction="http://tempuri.org/IServicioHistorialCapital/registroHistCapitalResponse")]
        System.Threading.Tasks.Task<bool> registroHistCapitalAsync(decimal monto, System.DateTime fechaCorte, bool estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/capitalActual", ReplyAction="http://tempuri.org/IServicioHistorialCapital/capitalActualResponse")]
        MB.WCF.DataContract.DCHisCapitalFinanciero capitalActual();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/capitalActual", ReplyAction="http://tempuri.org/IServicioHistorialCapital/capitalActualResponse")]
        System.Threading.Tasks.Task<MB.WCF.DataContract.DCHisCapitalFinanciero> capitalActualAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/capitalInicial", ReplyAction="http://tempuri.org/IServicioHistorialCapital/capitalInicialResponse")]
        MB.WCF.DataContract.DCHisCapitalFinanciero capitalInicial();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/capitalInicial", ReplyAction="http://tempuri.org/IServicioHistorialCapital/capitalInicialResponse")]
        System.Threading.Tasks.Task<MB.WCF.DataContract.DCHisCapitalFinanciero> capitalInicialAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/calcularDiferenciaCapital", ReplyAction="http://tempuri.org/IServicioHistorialCapital/calcularDiferenciaCapitalResponse")]
        System.Nullable<decimal> calcularDiferenciaCapital();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/calcularDiferenciaCapital", ReplyAction="http://tempuri.org/IServicioHistorialCapital/calcularDiferenciaCapitalResponse")]
        System.Threading.Tasks.Task<System.Nullable<decimal>> calcularDiferenciaCapitalAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/eliminarHisCapitalPorId", ReplyAction="http://tempuri.org/IServicioHistorialCapital/eliminarHisCapitalPorIdResponse")]
        bool eliminarHisCapitalPorId(int idHistorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialCapital/eliminarHisCapitalPorId", ReplyAction="http://tempuri.org/IServicioHistorialCapital/eliminarHisCapitalPorIdResponse")]
        System.Threading.Tasks.Task<bool> eliminarHisCapitalPorIdAsync(int idHistorial);
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
        
        public bool registroHistCapital(decimal monto, System.DateTime fechaCorte, bool estado) {
            return base.Channel.registroHistCapital(monto, fechaCorte, estado);
        }
        
        public System.Threading.Tasks.Task<bool> registroHistCapitalAsync(decimal monto, System.DateTime fechaCorte, bool estado) {
            return base.Channel.registroHistCapitalAsync(monto, fechaCorte, estado);
        }
        
        public MB.WCF.DataContract.DCHisCapitalFinanciero capitalActual() {
            return base.Channel.capitalActual();
        }
        
        public System.Threading.Tasks.Task<MB.WCF.DataContract.DCHisCapitalFinanciero> capitalActualAsync() {
            return base.Channel.capitalActualAsync();
        }
        
        public MB.WCF.DataContract.DCHisCapitalFinanciero capitalInicial() {
            return base.Channel.capitalInicial();
        }
        
        public System.Threading.Tasks.Task<MB.WCF.DataContract.DCHisCapitalFinanciero> capitalInicialAsync() {
            return base.Channel.capitalInicialAsync();
        }
        
        public System.Nullable<decimal> calcularDiferenciaCapital() {
            return base.Channel.calcularDiferenciaCapital();
        }
        
        public System.Threading.Tasks.Task<System.Nullable<decimal>> calcularDiferenciaCapitalAsync() {
            return base.Channel.calcularDiferenciaCapitalAsync();
        }
        
        public bool eliminarHisCapitalPorId(int idHistorial) {
            return base.Channel.eliminarHisCapitalPorId(idHistorial);
        }
        
        public System.Threading.Tasks.Task<bool> eliminarHisCapitalPorIdAsync(int idHistorial) {
            return base.Channel.eliminarHisCapitalPorIdAsync(idHistorial);
        }
    }
}
