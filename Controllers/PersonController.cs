using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W4D1mvc.Models;

namespace W4D1mvc.Controllers
{
    public class PersonController : Controller
    {
        public List<Person> PersonList = Data.GetClassMates();
        // GET: People
        public ActionResult Index()
        {
            return View(PersonList);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            Person newPerson = new Person(collection["Name"], collection["HairColor"], int.Parse(collection["Height"]));
            PersonList.Add(newPerson);
            Data.AddClassMate(newPerson, "");

            // TODO: Add insert logic here

            return RedirectToAction("Index");

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

                return RedirectToAction("Index");
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

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
