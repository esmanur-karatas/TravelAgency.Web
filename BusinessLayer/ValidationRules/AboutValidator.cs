using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() {
            RuleFor(x => x.AboutImageUrl).NotEmpty().WithMessage("Lütfen Görsel Kısmına Url Olarak Giriniz!");
            
       }
        
    }
}
