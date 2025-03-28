﻿using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
	{
		public AppUserRegisterValidator()
		{
			RuleFor(x =>x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilmez.");
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı ad alanı boş geçilemez.");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
			RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");

			RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Parolanız eşleşmiyor.");
			RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz.");
		}
	}
}
