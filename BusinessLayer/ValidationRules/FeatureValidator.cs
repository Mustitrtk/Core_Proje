using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator() 
        {
            RuleFor(x=>x.Title).NotEmpty().MinimumLength(5).WithMessage("Başlık alanı boş olamaz ve minimum 5 karakter olmalı !");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(5).WithMessage("Başlık alanı boş olamaz ve minimum 5 karakter olmalı !");
            RuleFor(x => x.Header).NotEmpty().WithMessage("Header alano boş olamaz !");
        }
    }
}
