using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator :AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.Adı).NotEmpty().WithMessage("Lütfen İsim giriniz.");
            RuleFor(p => p.Soyadı).NotEmpty().WithMessage("Soyad boş olamaz.");
            RuleFor(p => p.TcNo).MinimumLength(11).MaximumLength(11).WithMessage("Tc Kimlik Numarası en az 11 sayıdan oluşmalıdır.");
            RuleFor(p => p.AylıkMaliyeti).GreaterThan(0).WithMessage("Maliyet Sıfırdan büyük olmalıdır");
            RuleFor(p => p.BirimSaatMaliyeti).GreaterThan(0).WithMessage("Maliyet sıfırdan bütük olamalıdır.");
            RuleFor(p => p.Gorevi).NotEmpty().WithMessage("Görev boş olamaz.");
        }
    }
}
