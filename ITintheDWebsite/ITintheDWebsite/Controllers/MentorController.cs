using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITintheDWebsite.Models;

namespace ITintheDWebsite.Controllers
{
    public class MentorController : Controller
    {
        private DBEntities db = new DBEntities();

        [AcceptVerbs("POST")]
        public string GetMentorInfo(string name)
        {
            Mentor mentor = db.Mentors.FirstOrDefault(m => m.Name == name);

            if (mentor == null) return "Mentor info not found...";

            return mentor.Info;
        }

    }
}