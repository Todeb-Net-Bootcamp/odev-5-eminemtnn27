using DataAccessLayer.Abstract;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Dapper
{
    class DapperReaderRepository : IReaderRepository
    {
        public void Delete(Reader reader)
        {
            throw new NotImplementedException();
        }

        public Reader Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reader> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Reader reader)
        {
            throw new NotImplementedException();
        }

        public void Update(Reader reader)
        {
            throw new NotImplementedException();
        }
    }
}
