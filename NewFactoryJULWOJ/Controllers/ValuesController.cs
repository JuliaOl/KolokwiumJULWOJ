using LibraryJULWOJ;
using NewFactoryJULWOJ.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewFactoryJULWOJ.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ILogger logger;
        IRepository rep;
        public ValuesController(IRepository rep, ILogger logger)
        {
            this.rep = rep;
            this.logger = logger;
        }

        public Tank Get(int id)
        {
            logger.Write("[GET] (id)", LogLevel.INFO);
            return rep.Get(id);
        }

        public List<Tank> Get()
        {
            logger.Write("[GET] ()", LogLevel.INFO);
            return rep.GetAllTanks().ToList();
        }

        public int Post([FromBody]Tank tank)
        {
            logger.Write("[POST] (tank)", LogLevel.INFO);
            return rep.Add(tank);
        }

        public Tank Put(int id, [FromBody]Tank tank)
        {
            logger.Write("[PUT] (id, tank)", LogLevel.INFO);
            return rep.Update(tank);
        }

        public Tank Put([FromUri]Tank tank)
        {
            logger.Write("[PUT] from url", LogLevel.INFO);
            return rep.Update(tank);
        }

        public bool Delete(int id)
        {
            logger.Write("[DELETE] (id)", LogLevel.INFO);
            return rep.Delete(id);
        }

    }
}
