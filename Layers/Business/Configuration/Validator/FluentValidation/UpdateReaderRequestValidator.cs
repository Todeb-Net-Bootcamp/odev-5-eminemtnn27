using DTO.Reader;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class UpdateReaderRequestValidator:AbstractValidator<UpdateReaderRequest>
    {
        public UpdateReaderRequestValidator()
        {
            RuleFor(x=>x.ReaderId).GreaterThan(0); //id 0'dan büyük olacak
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.Gender).NotEmpty();
        }
    }
}
