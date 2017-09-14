﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace COMP4976TextFilesLab.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        // The index view displays only the file names (without the path) in the /TextFiles directory in the form of links.
        // When you click on any of the files, it displays the content of a file in the content view.
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            string[] fileNames = new string[files.Length];
            int i = 0;
            foreach (string file in files) {
                fileNames[i++] = Path.GetFileName(file); // store name
            }
            return View(fileNames);
        }

        public ActionResult Display()
        {
            return View();
        }
    }
}