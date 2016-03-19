using LessonProject.Model;
using LessonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonProject.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {

            var users = Repository.Users.ToList();
            return View(users);
        }
        [HttpGet]
        public ActionResult Register()
        {
            var newUserView = new UserView();
            return View(newUserView);
            //var newUser = new User(); return View(newUser); 
        }
        [HttpPost]
        public ActionResult Register(UserView userView)
        {
            if (userView.Captcha != "1234")
            {
                ModelState.AddModelError("Captcha", "Текст с картинки введен неверно");
            }
            var anyUser = Repository.Users.Any(p => string.Compare(p.Email, userView.Email) == 0);
            if (anyUser) { ModelState.AddModelError("Email", "Пользователь с таким email уже зарегистрирован"); }
            if (ModelState.IsValid)
            {
                var user = (User)ModelMapper.Map(userView, typeof(UserView), typeof(User));
                //TODO: Сохранить 
            } return View(userView);

            //if (user.Captcha != "1234")
            //{ ModelState.AddModelError("Captcha", "Текст с картинки введен неверно"); }
            //var anyUser = Repository.Users.Any(p => string.Compare(p.Email, user.Email) == 0);
            //if (anyUser)
            //{
            //    ModelState.AddModelError("Email", "Пользователь с таким email уже зарегистрирован");
            //}
            //return View(user);
        }
    }
}