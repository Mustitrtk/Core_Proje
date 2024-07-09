using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidation:AbstractValidator<Portfolio>
    {
        public PortfolioValidation() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Proje Adı Boş Geçilemez!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Proje Adı Minimum 5 Karakter Olmalıdır!");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Proje Adı Maximum 20 Karakter Olmalıdır!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim 1 Alanı Boş Bırakılamaz");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Resim 2 Alanı Boş Bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ücret Alanı Boş Bırakılamaz!");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform Alanı Boş Bırakılamaz!");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Alanı Boş Bırakılamaz!");
        }
    }
}
