using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Mvc4DDD.Administration.ViewModels;
using Mvc4DDD.Application.Interfaces;
using Mvc4DDD.Domain.Entities;

namespace Mvc4DDD.Administration.Controllers
{
    public class ApiCompaniesController : ApiController
    {
        private readonly ICompanyAppService _companyApp;

        /*
         * 
         * 
         * It is not being called yet.
         * 
         * 
         * 
         * 
         */

        public ApiCompaniesController(ICompanyAppService companyApp)
        {
            _companyApp = companyApp;
        }

        // GET api/apicompanies
        public IEnumerable<CompanyViewModel> Get()
        {
            var comp = Mapper.Map < IEnumerable<Company>, IEnumerable<CompanyViewModel>>(_companyApp.GetAll());
            return comp;
        }
        /*
        // GET api/apicompanies/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/apicompanies
        public void Post([FromBody]string value)
        {
        }

        // PUT api/apicompanies/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/apicompanies/5
        public void Delete(int id)
        {
        }*/
    }
}
