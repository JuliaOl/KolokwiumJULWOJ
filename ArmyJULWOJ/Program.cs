
using ArmyJULWOJ.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyJULWOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            string name = client.CreateTank(new Tank() { Id = 1, Power = 2, Shield = 3, ModelName = "superTank" });
            Tank tank = client.GetTank(name);
            Console.WriteLine(tank.ModelName);
            Console.ReadKey();

            client.Close();
        }
    }
}
