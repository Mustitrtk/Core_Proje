using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidation : AbstractValidator<Skill>
    {
        public SkillValidation() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Kalamaz!");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Boş Kalamaz!");
            RuleFor(x => x.Value).MaximumLength(100).WithMessage("En yüksek değer 100 olmalı!");
            RuleFor(x => x.Value).MinimumLength(0).WithMessage("En düşül değer 0 olmalı!");
        }
    }
}
