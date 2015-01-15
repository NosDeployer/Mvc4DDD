using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Mvc4DDD.Application.Interfaces;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.MVC.EndUserApp.ViewModels;
using Mvc4DDD.MVC.EndUserApp.Extensions;

namespace Mvc4DDD.MVC.EndUserApp.Controllers
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
        // GET: /Companies/Details/1/name

        public ActionResult Details(int id, String seoName)
        {
            var comp = Mapper.Map<Company, CompanyViewModel>(_companyApp.GetById(id));

            // Redirect to proper name
            if (!seoName.Equals(comp.Name.SeoString()))
                return RedirectToActionPermanent("Details", new {id = id, seoName = comp.Name.SeoString()});

            return View(comp);
        }

        /// <summary>
        /// It's receiving the original name because the database doesn't 
        /// have an ID for cities and find by SEO String on database does not
        /// have a good performance.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public ActionResult Where(String location)
        {
            var comp = Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(_companyApp.GetByLocation(location));

            return View(comp);
        }

        public ActionResult What(String categoryId, String categorySeo)
        {
            var comp = Mapper.Map<IEnumerable<Company>, IEnumerable<CompanyViewModel>>(_companyApp.GetByCategory(categoryId));

            // Redirect to proper name
            if (!categorySeo.Equals(comp.FirstOrDefault().CategoryName.SeoString()))
                return RedirectToActionPermanent("What", new
                {
                    categoryId = categoryId,
                    categorySeo = comp.FirstOrDefault().CategoryName.SeoString()
                });

            return View(comp);
        }

        [HttpPost]
        public JsonResult GetCoords(int id)
        {
            /* This method is not useful, because the data is already on the page,
             * but I would like to test the Ajax request.
             */
            var comp = Mapper.Map<Company, CompanyViewModel>(_companyApp.GetById(id));
            return Json(new { ok = true, xcoord = comp.XCoord, ycoord = comp.YCoord });
        }
        
    }
}
