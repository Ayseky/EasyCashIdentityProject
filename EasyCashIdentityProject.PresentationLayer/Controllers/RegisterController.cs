﻿using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
		{
			if(ModelState.IsValid)
			{
				AppUser appUser = new AppUser
				{
					UserName = appUserRegisterDto.UserName,
					Email = appUserRegisterDto.Email,
					Name = appUserRegisterDto.Name,
					Surname = appUserRegisterDto.Surname,
					City = "İstanbul",
				};
				
				var result =await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "ConfirmMail");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}

				}
			}

			return View();
		}
	}
}
