using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidation : AbstractValidator<Experience>
    {
        public ExperienceValidation() 
        { 
            RuleFor(x =>x.Name).NotEmpty().MinimumLength(5).WithMessage("Ad/Başlık alanı boş olamaz ve minimum 5 karakterli olmalı!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş olamaz!");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih alanı boş olamaz!");
        }
    }
}
