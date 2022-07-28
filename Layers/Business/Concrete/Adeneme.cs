using Business.Abstract;
using Business.Configuration.Response;
using DTO.Reader;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Adeneme : IReaderService
    { 
        public IEnumerable<Reader> GetAll()
        {
            throw new NotImplementedException();
        }

        public CommandResponse Insert(Reader customer)
        {
            throw new NotImplementedException();
        }

        public CommandResponse Update(Reader customer)
        {
            throw new NotImplementedException();
        }
        public CommandResponse Delete(Reader customer)
        {
            throw new NotImplementedException();
        }

        public CommandResponse Insert(CreateReaderRequest reader)
        {
            throw new NotImplementedException();
        }

        public CommandResponse Update(UpdateReaderRequest reader)
        {
            throw new NotImplementedException();
        }
    }
}
