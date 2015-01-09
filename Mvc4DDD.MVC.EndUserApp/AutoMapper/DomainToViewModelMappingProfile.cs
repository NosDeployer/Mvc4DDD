using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.MVC.EndUserApp.ViewModels;

namespace Mvc4DDD.MVC.EndUserApp.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Company, CompanyViewModel>();
        }
    }
}