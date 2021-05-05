using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PrescriptionValidator : AbstractValidator<Prescription>
    {
        public PrescriptionValidator()
        {
            RuleFor(p => p.Acıklama).NotEmpty().WithMessage("Açıklama boş olamaz.");
            RuleFor(p => p.AnaUrunKodu).NotEmpty().WithMessage("Ana ürün kodu boş olamaz");
            RuleFor(p => p.MiktarSayısı).GreaterThan(0).WithMessage("Miktar sayısı boş olamaz.");
            RuleFor(p => p.SatırSayısı).GreaterThan(0).WithMessage("Satır sayısı sıfırdan büyük olmalıdır.");
        }
    }
}
