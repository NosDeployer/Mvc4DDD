using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4DDD.Application.Interfaces;

namespace Mvc4DDD.MVC.EndUserApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly ICompanyAppService _companyApp;

        public MenuController(ICompanyAppService companyApp)
        {
            _companyApp = companyApp;
        }

        //
        // GET: /Menu/

        public ActionResult RenderMenu()
        {
            var countries = _companyApp.GetCountries();
            var categories = _companyApp.GetCategories();
            
            ViewBag.countries = countries;
            ViewBag.categories = categories;

            return PartialView("_Menu");
        }


    }
}
