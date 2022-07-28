using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReaderRepository
    {
        public IEnumerable<Reader> GetAll(); //liste biçiminde Reader ların hepsini getirir
        public void Insert(Reader reader);
        public void Update(Reader reader);
        public void Delete(Reader reader);
        public Reader Get(int id);
    }
}
