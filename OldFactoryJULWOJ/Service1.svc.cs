using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LibraryJULWOJ;

namespace OldFactoryJULWOJ
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private readonly IRepository _rep;

        public Service1()
        {
            this._rep = new Repository();
        }

        public string CreateTank(Tank tank)
        {
            return _rep.CreateTank(tank);
        }

        public List<Tank> GetAllTanks()
        {
            return _rep.GetAllTanks();
        }

        public Tank GetTank(string name)
        {
            return _rep.GetTank(name);
        }
    }
}
