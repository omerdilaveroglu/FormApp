using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class WorkStationValidator : AbstractValidator<WorkStation>
    {
        public WorkStationValidator()
        {
            RuleFor(p => p.HammaddeAmbarı).NotEmpty().WithMessage("Hammadde ambarı boş olamaz.");
            RuleFor(p => p.IsIstasyonKodu).NotEmpty().WithMessage("İş istasyonu boş olmaz.");
            RuleFor(p => p.IstasyonAcıklama).NotEmpty().WithMessage("Açıklama boş olmaz.");
            RuleFor(p => p.IstasyonMaliyeti).GreaterThan(0).WithMessage("Maliyet sıfırdan büyük olmalı");
        }
    }
}
