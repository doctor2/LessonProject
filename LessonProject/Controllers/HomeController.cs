using LessonProject.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonProject.Controllers
{
    public class HomeController : BaseController
    {
       
        //public HomeController()
        //{
        //    weapon = DependencyResolver.Current.GetService<IWeapon>();
        //    Repository = DependencyResolver.Current.GetService<IRepository>();
        //}
        // GET: Home
        public ActionResult Index()
        {
            return View();
            //return View(weapon);
            //var roles = Repository.Roles.ToList();
            //return View(roles);
        }
       
        //public IWeapon weapon { get; set; }
    }
}