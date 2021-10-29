using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Migracion_.Models;
using Test_Migracion_.Services.Contracts;

namespace Test_Migracion_.Controllers
{
    public class PersonController : Controller
    {
        private readonly AplicationDbContext _aplicationDbContext;
        private readonly IPersonService _personService;

        public PersonController(AplicationDbContext aplicationDbContext, IPersonService personService)
        {
            this._aplicationDbContext = aplicationDbContext;
            _personService = personService;
        }
        // GET: PersonController
        public ActionResult Person()
        {
            var PersonModel = new PersonViewModel {
                Persons = _aplicationDbContext.Person.Include(x => x.Requests).ToList(),
                Person = new Person()
            };
            return View(PersonModel);
        }

        [HttpPost]
        public ActionResult AddRequest(PersonViewModel personViewModel)
        {
            if (personViewModel.Person == null)
            {
                personViewModel.Person = new Person();
            }
            personViewModel.Person.Requests.Add(personViewModel.Request);
            return View("Person", personViewModel);
        }

        [HttpPost]
        public ActionResult AddPerson(PersonViewModel personViewModel)
        {
            _personService.AddPerson(personViewModel.Person);
            return RedirectToAction("Person", "Person");
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
