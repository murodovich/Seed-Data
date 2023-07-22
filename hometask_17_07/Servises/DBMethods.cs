using hometask_17_07.Data;
using hometask_17_07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_17_07.Servises
{
    public class DBMethods<Tkey> where Tkey : BaseEntity
    {
        GMDBcontext _dbContext = new GMDBcontext();

        public void Add(Tkey val)
        {
            _dbContext.Set<Tkey>().Add(val);
            _dbContext.SaveChanges();
        }

        public void Delete(int val)
        {
            _dbContext.Remove(val);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Tkey> GetAll()
        {
            return _dbContext.Set<Tkey>().ToList();
        }

        public void Update(Tkey val)
        {
            _dbContext.Set<Tkey>().Update(val);
            _dbContext.SaveChanges();
        }
    }
}
