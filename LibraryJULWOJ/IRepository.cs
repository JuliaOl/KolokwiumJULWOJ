using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryJULWOJ
{
    public interface IRepository
    {
        Tank GetTank(string name);
        String CreateTank(Tank tank);

        List<Tank> GetAllTanks();

        int Add(Tank tank);
        Tank Get(int id);
        Tank Update(Tank tank);
        bool Delete(int id);

    }
}
