﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_MVC_StudentInfo.Controllers
{
    public class ManageStudentInfoController : Controller
    {
        // GET: ManageStudentInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNewStudent()
        {
            return PartialView("AddStudent");
        }

        public ActionResult ShowStudents()
        {
            return PartialView("ShowAllStudent");
        }

        public ActionResult EditStudent()
        {
            return PartialView("EditStudent");
        }

        public ActionResult DeleteStudent()
        {
            return PartialView("DeleteStudent");
        }
    }
}