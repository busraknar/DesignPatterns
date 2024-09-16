using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee

    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            throw new NotImplementedException();
        }
    }
}
