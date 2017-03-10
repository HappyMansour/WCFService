﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Client_Emp_Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Client_Emp_Service.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Data.DataSet GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByID", ReplyAction="http://tempuri.org/IService/GetByIDResponse")]
        System.Data.DataSet GetByID(int EMP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByID", ReplyAction="http://tempuri.org/IService/GetByIDResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetByIDAsync(int EMP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert", ReplyAction="http://tempuri.org/IService/InsertResponse")]
        int Insert(int EMP_ID, string Name, int DP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert", ReplyAction="http://tempuri.org/IService/InsertResponse")]
        System.Threading.Tasks.Task<int> InsertAsync(int EMP_ID, string Name, int DP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        int Update(int EMP_ID, string Name, int DP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        System.Threading.Tasks.Task<int> UpdateAsync(int EMP_ID, string Name, int DP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        int Delete(int EMP_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        System.Threading.Tasks.Task<int> DeleteAsync(int EMP_ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.Client_Emp_Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.Client_Emp_Service.IService>, Client.Client_Emp_Service.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public System.Data.DataSet GetByID(int EMP_ID) {
            return base.Channel.GetByID(EMP_ID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetByIDAsync(int EMP_ID) {
            return base.Channel.GetByIDAsync(EMP_ID);
        }
        
        public int Insert(int EMP_ID, string Name, int DP_ID) {
            return base.Channel.Insert(EMP_ID, Name, DP_ID);
        }
        
        public System.Threading.Tasks.Task<int> InsertAsync(int EMP_ID, string Name, int DP_ID) {
            return base.Channel.InsertAsync(EMP_ID, Name, DP_ID);
        }
        
        public int Update(int EMP_ID, string Name, int DP_ID) {
            return base.Channel.Update(EMP_ID, Name, DP_ID);
        }
        
        public System.Threading.Tasks.Task<int> UpdateAsync(int EMP_ID, string Name, int DP_ID) {
            return base.Channel.UpdateAsync(EMP_ID, Name, DP_ID);
        }
        
        public int Delete(int EMP_ID) {
            return base.Channel.Delete(EMP_ID);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(int EMP_ID) {
            return base.Channel.DeleteAsync(EMP_ID);
        }
    }
}
