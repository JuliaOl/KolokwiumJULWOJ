using LibraryJULWOJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OldFactoryJULWOJ
{

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Tank GetTank(string name);

        [OperationContract]
        String CreateTank(Tank tank);

        [OperationContract]
        List<Tank> GetAllTanks();

    }


}