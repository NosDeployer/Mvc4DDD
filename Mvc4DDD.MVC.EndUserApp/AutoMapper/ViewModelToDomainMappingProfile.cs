using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Mvc4DDD.Domain.Entities;
using Mvc4DDD.MVC.EndUserApp.ViewModels;

namespace Mvc4DDD.MVC.EndUserApp.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CompanyViewModel, Company>();
        }
    }
}