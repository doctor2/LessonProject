﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace LessonProject.Models
{
    public class BirthDateDay
    {
        public int BirthdateDay { get; set; }
        public int BirthdateMonth { get; set; }
        public int BirthdateYear { get; set; }
        public IEnumerable<SelectListItem> BirthdateDaySelectList
        {
            get
            {
                for (int i = 1; i < 32; i++)
                {
                    yield return new SelectListItem { Value = i.ToString(), Text = i.ToString(), Selected = BirthdateDay == i };
                }
            }
        }
        public IEnumerable<SelectListItem> BirthdateMonthSelectList { get { for (int i = 1; i < 13; i++) { yield return new SelectListItem { Value = i.ToString(), Text = new DateTime(2000, i, 1).ToString("MMMM"), Selected = BirthdateMonth == i }; } } }
        public IEnumerable<SelectListItem> BirthdateYearSelectList { get { for (int i = 1910; i < DateTime.Now.Year; i++) { yield return new SelectListItem { Value = i.ToString(), Text = i.ToString(), Selected = BirthdateYear == i }; } } }
    }
}