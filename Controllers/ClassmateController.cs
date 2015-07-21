using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using W4D1mvc.Models;

namespace W4D1mvc.Controllers
{
    public class ClassmateController
        : Controller
    {
   

        // GET: People
        public ActionResult ListClassMates()
        {
            return View(W4D1mvc.App_Start.MyStartup.Classmates);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View(W4D1mvc.App_Start.MyStartup.Classmates[id]);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var x = collection;
            classmate newPerson = new classmate(collection["Name"], collection["HairColor"], int.Parse(collection["Height"]));
            W4D1mvc.App_Start.MyStartup.Classmates.Add(newPerson);
           Data.SaveClassMates();

            // TODO: Add insert logic here

            return RedirectToAction("ListClassMates");

            //catch
            //{
            //    return View();
            //}
        }

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("ListClassMates");
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("ListClassMates");
            }
            catch
            {
                return View();
            }
        }
    }
}
