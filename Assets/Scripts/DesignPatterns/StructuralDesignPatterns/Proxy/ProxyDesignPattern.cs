using UnityEngine;

namespace StructuralDesignPatterns.Proxy
{
    public class ProxyDesignPattern : DesignPattern
    {
        protected override string name { get; set; } = "Proxy";
        
        private void Start()
        {
            ShowName();
            
            Client client = new Client();
            
            Debug.Log("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);
            

            Debug.Log("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);
        }
    }
    
    // The Subject interface declares common operations for both RealSubject and
    // the Proxy. As long as the client works with RealSubject using this
    // interface, you'll be able to pass it a proxy instead of a real subject.
    public interface ISubject
    {
        void Request();
    }
    
    // The RealSubject contains some core business logic. Usually, RealSubjects
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealSubject's code.
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Debug.Log("RealSubject: Handling Request.");
        }
    }
    
    // The Proxy has an interface identical to the RealSubject.
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        
        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }
        
        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealSubject object.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }
        
        public bool CheckAccess()
        {
            // Some real checks should go here.
            Debug.Log("Proxy: Checking access prior to firing a real request.");

            return true;
        }
        
        public void LogAccess()
        {
            Debug.Log("Proxy: Logging the time of request.");
        }
    }
    
    public class Client
    {
        // The client code is supposed to work with all objects (both subjects
        // and proxies) via the Subject interface in order to support both real
        // subjects and proxies. In real life, however, clients mostly work with
        // their real subjects directly. In this case, to implement the pattern
        // more easily, you can extend your proxy from the real subject's class.
        public void ClientCode(ISubject subject)
        {
            // ...
            
            subject.Request();
            
            // ...
        }
    }
}