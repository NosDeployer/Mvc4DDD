using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Mvc4DDD.Administration.ViewModels;
using Mvc4DDD.Domain.Entities;

namespace Mvc4DDD.Administration.AutoMapper
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