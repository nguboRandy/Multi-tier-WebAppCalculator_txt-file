﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        double Add(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<double> AddAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        double Subtract(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SubtractAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        double Multiply(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        double Divide(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DivideAsync(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebService1Soap>, WindowsFormsApp1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double num1, double num2) {
            return base.Channel.Add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double num1, double num2) {
            return base.Channel.AddAsync(num1, num2);
        }
        
        public double Subtract(double num1, double num2) {
            return base.Channel.Subtract(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double num1, double num2) {
            return base.Channel.SubtractAsync(num1, num2);
        }
        
        public double Multiply(double num1, double num2) {
            return base.Channel.Multiply(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double num1, double num2) {
            return base.Channel.MultiplyAsync(num1, num2);
        }
        
        public double Divide(double num1, double num2) {
            return base.Channel.Divide(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double num1, double num2) {
            return base.Channel.DivideAsync(num1, num2);
        }
    }
}