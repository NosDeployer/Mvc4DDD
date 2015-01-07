using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Mvc4DDD.Administration.ViewModels;
using Mvc4DDD.Application.Interfaces;
using Mvc4DDD.Domain.Entities;

namespace Mvc4DDD.Administration.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyAppService _companyApp;

        public CompaniesController(ICompanyAppService companyApp)
        {
            _companyApp = companyApp;
        }

        //
        // GET: /Companies/

        public ActionResult Index()
        {
            var comp = Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(_companyApp.GetAll());
            return View(comp);
        }

        //
        // GET: /Companies/Details/5

        public ActionResult Details(int id)
        {
            var company = _companyApp.GetById(id);
            var companyViewModel = Mapper.Map<Company, CompanyViewModel>(company);
            return View(companyViewModel);
        }

        //
        // GET: /Companies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Companies/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CompanyViewModel companyViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var company = Mapper.Map<CompanyViewModel, Company>(companyViewModel);
                    _companyApp.Add(company);

                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View(companyViewModel);
            }
            return View(companyViewModel);
        }

        //
        // GET: /Companies/Edit/5

        public ActionResult Edit(int id)
        {
            var company = _companyApp.GetById(id);
            var companyViewModel = Mapper.Map<Company, CompanyViewModel>(company);
            return View(companyViewModel);
        }

        //
        // POST: /Companies/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CompanyViewModel companyViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var company = Mapper.Map<CompanyViewModel, Company>(companyViewModel);
                    _companyApp.Update(company);

                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View(companyViewModel);
            }
            return View(companyViewModel);
        }

        //
        // GET: /Companies/Delete/5

        public ActionResult Delete(int id)
        {
            var company = _companyApp.GetById(id);
            var companyViewModel = Mapper.Map<Company, CompanyViewModel>(company);
            return View(companyViewModel);
        }

        //
        // POST: /Companies/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var company = _companyApp.GetById(id);
                _companyApp.Remove(company);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
