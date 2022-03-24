using AutoMapper;
using PCP.Domain.Entities;
using PCP.Infra.Repositories;
using PCP.Site.AutoMapper;
using PCP.Site.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCP.Site.Controllers
{
    public class TrocasController : Controller
    {
        private readonly TrocasxSurgimentoVigenteRepository _trocas = new TrocasxSurgimentoVigenteRepository();
        private readonly IMapper _mapper;

        // GET: Trocas

        public TrocasController()
        {
            _mapper = AutoMapperConfig.Mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var trocas = _mapper.Map<List<TrocasxSurgimentoVigente>>(_trocas.GetTrocas());

            return View(trocas);
        }

        // GET: Trocas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trocas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trocas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trocas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trocas/Edit/5
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

        // GET: Trocas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trocas/Delete/5
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
