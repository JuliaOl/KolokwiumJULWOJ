using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryJULWOJ
{
    public class Repository : IRepository
    {
        private readonly string _connection = @"C:\tmp\repo";

        public int Add(Tank tank)
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                if (repository.FindById(tank.Id) != null)
                    repository.Update(tank);
                else
                    repository.Insert(tank);

                return tank.Id;
            }
        }

        public string CreateTank(Tank tank)
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                if (repository.FindById(tank.Id) != null)
                    repository.Update(tank);
                else
                    repository.Insert(tank);

                return tank.ModelName;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                return repository.Delete(id);
            }
        }

        public Tank Get(int id)
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                return repository.FindById(id);
            }
        }

        public List<Tank> GetAllTanks()
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                var results = repository.FindAll();

                return results.ToList();
            }
        }

        public Tank GetTank(string name)
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                var result = repository.FindOne(x => x.ModelName.Equals(name));
                return result;
            }
        }

        public Tank Update(Tank tank)
        {
            using (var db = new LiteDatabase(this._connection))
            {

                var repository = db.GetCollection<Tank>("tanks");
                if (repository.Update(tank))
                    return tank;
                else
                    return null;
            }
        }
    }
}
