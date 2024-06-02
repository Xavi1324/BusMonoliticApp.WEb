﻿using BusMonoliticApp.Web.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XavierCasilla_2023_0995.Controllers
{
    public class ReservaController : Controller
    {
        private readonly BoletosBusContext context;
        public ReservaController(BoletosBusContext context)
        {
            this.context = context;
        }
        // GET: ReservaController
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: ReservaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaController/Create
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

        // GET: ReservaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservaController/Edit/5
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

        // GET: ReservaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservaController/Delete/5
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
