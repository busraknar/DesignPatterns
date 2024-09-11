using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;  //Sonraki onaylayıcı çalışan türünde
        public void SetNextApprover(Employee superVisor)  //Sonraki Onaylayıcıyı Ayarla
        {
            this.NextApprover = superVisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req); //İşlem isteği
    }
}
