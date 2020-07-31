using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SadafStore.Core.CodeGenerator;
using SadafStore.Core.Convertors;
using SadafStore.Core.DTOs;
using SadafStore.Core.Security;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Entities.User;
using SendEmail;

namespace SadafStore.web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewRender;

        public AccountController(IUserService userService, IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;
        }

        #region Register User

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.IsExistEmail(FixedTexts.FixEmails(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده معتبر نیست و وجود دارد!!!");
                return View(register);
            }
            if (_userService.IsExistUserName(FixedTexts.FixUserNames(register.UserName)))
            {
                ModelState.AddModelError("UserName", "نام کاربری وارد شده معتبر نیست و وجود دارد!!!");
                return View(register);
            }

            DataLayer.Entities.User.User user = new User()
            {
                ActiveCode = GeneratorCode.GenerateGuidCode(),
                UserName = register.UserName,
                Email = FixedTexts.FixEmails(register.Email),
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                IsActive = false,
                RegisterDate = DateTime.Now,
                AvatarImg = "null.jpg"
            };
            _userService.AddUser(user);

            #region Send Email ActiveCode To User

            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            Core.Senders.SendEmail.Send(user.Email, "فعال سازی کاربر", body);

            #endregion

            return View("SuccessRegister",user);
        }

        #endregion

        #region Login User

        [Route("Login")]
        public IActionResult Login(bool EditProfile = false,bool SuccessChangePass = false)
        {
            ViewBag.EditProfile = EditProfile;
            ViewBag.SuccessChangePass = SuccessChangePass;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _userService.LoginUser(login);
            // Exist and Active User
            if (user != null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "کاربر گرامی شما همچنان فعال نشده‌اید به صندق پستی ایمیل خود سربزنید!!!");
                }
            }
            ModelState.AddModelError("Email","کاربری با این مشخصات در سیستم یافت نشده!");

            return View(login);
        }

        #endregion

        #region Active User

        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }

        #endregion

        #region Logout User

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }

        #endregion

        #region Forgot User Account Password

        [Route("ForgotPassword")]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [Route("ForgotPassword")]
        public ActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
                return View(forgot);

            string fixEmail = FixedTexts.FixEmails(forgot.Email);
            DataLayer.Entities.User.User user = _userService.GetUserByEmail(fixEmail);

            if (user == null)
            {
                ModelState.AddModelError("Email", "کاربری با این مشخصات وجود ندارد.");
                return View(forgot);
            }

            #region Send Email

            string bodyForgotPasswordEmail = _viewRender.RenderToStringAsync("_ForgotPassword", user);
            Core.Senders.SendEmail.Send(user.Email, "بازیابی کلمه عبور", bodyForgotPasswordEmail);

            #endregion

            ViewBag.IsSuccess = true;
            return View();
        }

        #endregion

        #region Reset User Account Password

        public ActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordModelView()
            {
                ActiveCode = id
            });
        }
        [HttpPost]
        public ActionResult ResetPassword(ResetPasswordModelView reset)
        {
            if (!ModelState.IsValid)
                return View(reset);

            DataLayer.Entities.User.User user = _userService.GetUserByActiveCode(reset.ActiveCode);
            if (user == null)
                return NotFound();

            string hashNewPassword = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hashNewPassword;
            _userService.UpdateUser(user);

            return Redirect("/Login");
        }

        #endregion
    }
}
