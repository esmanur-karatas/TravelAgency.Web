using Microsoft.AspNetCore.Identity;

namespace TravelAgency.Web.Models
{
	public class CustomeIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int lenght)
		{
			return new IdentityError
			{
				Code = "PasswordTooShort",
				Description = $"Parola Minimum {lenght} karakter olmalıdır!"
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Parola en az 1 büyük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Parola en az 1 küçük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Parola en az 1 sembol içermelidir."
			};
		}
	}
}
