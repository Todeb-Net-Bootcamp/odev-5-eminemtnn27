using DTO.Reader;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class CreateReaderRequestValidator:AbstractValidator<CreateReaderRequest>
    {
        public CreateReaderRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.Gender).NotEmpty();
        }
    }
}
