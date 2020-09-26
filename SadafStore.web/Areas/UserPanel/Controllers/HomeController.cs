using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.DTOs;
using SadafStore.Core.Services.Interfaces;

namespace SadafStore.web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IOrderService _orderService;

        public HomeController(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }

        #region EditProfil

        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userService.GetDataForEditProfile(User.Identity.Name));
        }
        [HttpPost]
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile(UserPanelViewModel.EditProfileViewModel profile)
        {
            if (!ModelState.IsValid)
                return View(profile);

            _userService.EditProfile(User.Identity.Name,profile);

            //Logout User For Update Data
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login?EditProfile=true");

        }

        #endregion

        #region Change Password in UserPanel

        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword(UserPanelViewModel.ChangePasswordViewModel change)
        {
            if (!ModelState.IsValid)
                return View(change);
            //check old pass
            string currentUserName = User.Identity.Name;
            if (!_userService.CompareOldPasswordForChange(change.OldPassword,currentUserName))
            {
                ModelState.AddModelError("OldPassword"," => کلمه عبور فعلی شما به درستی وارد نشده است!!!");
                return View(change);
            }
            //Get and Save New Pass
            _userService.ChangeUserPassword(currentUserName,change.NewPassword);

            //Logout User For Update Pass
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login?SuccessChangePass=true");
        }

        #endregion
    }
}
