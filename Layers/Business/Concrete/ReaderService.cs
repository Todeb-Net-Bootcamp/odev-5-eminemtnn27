using AutoMapper;
using Business.Abstract;
using Business.Configuration.Extension;
using Business.Configuration.Response;
using Business.Configuration.Validator.FluentValidation;
using DataAccessLayer.Abstract;
using DTO.Reader;
using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReaderService : IReaderService
    {
        //iş katmanı gidecek,datalayer katmanına erişerek veritabanına gidecek ilgili operasyonları yapıp geri dönecek
        //business katmanından data layer katmanına interface ile geçecek

        private readonly IReaderService _reader ;
        private readonly IReaderRepository _readerRepository ;
        private IMapper _mapper;
        //private IValidator<CreateReaderRequest> _validator ;
        public ReaderService(IReaderService reader, IMapper mapper/*, IValidator<CreateReaderRequest> validator*/)
        {
            _reader  = reader ;
            _mapper = mapper ;
            //this._validator = validator ;
        }

        public IEnumerable<Reader> GetAll()
        {
           return _reader.GetAll();
        }

        public CommandResponse Insert(CreateReaderRequest request)
        {

            //validation
            //_validator.Validate(request);

            var validator = new CreateReaderRequestValidator();
            validator.Validate(request).ThrowIfException();

            
            var entity=_mapper.Map<Reader>(request);
            
            //aşağıdaki map leme işini Automapper ile yukarıda yaptık

            //var entity=new Reader();
            //entity.Name = request.Name;
            //entity.Surname = request.Surname;
            //entity.Gender = request.Gender;
            _readerRepository.Insert(entity);
            //bu metodu extension içine aldık
            //if(val.IsValid==false)
            //{
            //    var asd = new String[] { "deneme-1", "deneme-2" };
            //    var asdstr=string.Join(',', asd);

            //    var message = string.Join(',',val.Errors.Select(x=>x.ErrorMessage));
            //    throw new ValidationException(message);
            //}

            //business logic (var mı ? yok mu?)
            // _readerService.Insert(reader);
            return new CommandResponse
            {
                Status = true,
                Message = $"Okuyucu eklendi. "
            };
        }

        public CommandResponse Update(UpdateReaderRequest request)
        {
            var validator = new UpdateReaderRequestValidator();
            validator.Validate(request).ThrowIfException();

            var entity = _readerRepository.Get(request.ReaderId);
            if(entity == null)
            {
                return new CommandResponse
                {
                    Status = false,
                    Message ="Veritabanında kayıt bulunamadı"
                }; 
            }

            var mapped= _mapper.Map(request,entity);
            _readerRepository.Update(mapped);
            
            return new CommandResponse
            {
                Status = true,
                Message = $"Okuyucu güncellendi"
            };
        }
        public CommandResponse Delete(Reader reader)
        {
            _reader.Delete(reader);
            return new CommandResponse
            {
                Status = true,
                Message = $"Okuyucu silindi. Id={reader.ReaderId}"
            };
        }
         

        public CommandResponse Update(Reader reader)
        {
            throw new NotImplementedException();
        }

    }
}
