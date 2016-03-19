using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonProject.Models
{
    public interface IWeapon { string Kill(); }
    public class Bazuka : IWeapon
    {
        public string Kill()
        { return "BIG BADABUM!"; }
    }
}