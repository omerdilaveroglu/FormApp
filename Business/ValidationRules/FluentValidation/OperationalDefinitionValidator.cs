using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OperationalDefinitionValidator :AbstractValidator<OperationalDefinition>
    {
        public OperationalDefinitionValidator()
        {
            RuleFor(p => p.BeklemeSuresi).GreaterThan(0).WithMessage("Bekleme süresi boş olamaz.");
            RuleFor(p => p.IslemSuresi).GreaterThan(0).WithMessage("İşlem süresi boş olamaz");
            RuleFor(p => p.OperasyonAcıklama).NotEmpty().WithMessage("Lütfen bir açıklama giriniz.");
            RuleFor(p => p.OperasyonKodu).NotEmpty().WithMessage("Operasyon kodu boş olamaz");
            RuleFor(p => p.TasımaSuresi).GreaterThan(0).WithMessage("Taşıma süresi boş olamaz");
            RuleFor(p => p.ToplamOperasyonSuresi).GreaterThan(0).WithMessage("Toplam operasyon süresi boş olamaz");

        }
    }
}
