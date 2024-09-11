using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee  //Veznedar
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();  //çekilmek istenen tutar
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe";
                customerProcess.Description = "Para Çekme işlemi onaylandı. Müşteriye talep ettiği miktar ödendi.";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();


            }
        }
    }
}
