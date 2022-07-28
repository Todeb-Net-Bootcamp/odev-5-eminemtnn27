using Business.Configuration.Response;
using DTO.Reader;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReaderService
    {
        public IEnumerable<Reader> GetAll(); //liste biçiminde Reader ların hepsini getirir
        public CommandResponse Insert(CreateReaderRequest reader);
        public CommandResponse Update(UpdateReaderRequest reader);
        public CommandResponse Delete(Reader reader);

    }
}
