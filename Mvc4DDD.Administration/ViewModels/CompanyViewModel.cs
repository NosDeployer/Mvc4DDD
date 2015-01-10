using Mvc4DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc4DDD.Administration.ViewModels
{
    public class CompanyViewModel
    {
        /*public CompanyViewModel()
        {
            AdditionalPhones = new AdditionalPhonesList();
        }*/

        [Key]
        public int CompanyId { get; set; }

        [Required]
        [DisplayName("Company Name")]
        public String Name { get; set; }

        [Required]
        [DisplayName("House Number")]
        public String HouseNumber { get; set; }

        [Required]
        [DisplayName("Postal Code")]
        public String PostalCode { get; set; }

        [Required]
        public String City { get; set; }

        [Required]
        public String Country { get; set; }

        [Required]
        public String XCoord { get; set; }

        [Required]
        public String YCoord { get; set; }

        //[Required]
        [DisplayName("Main Phone")]
        public String MainPhone { get; set; }

        //[Required]
        public String Fax { get; set; }

        //[Required]
        [DisplayName("Additional Phones")]
        public String AdditionalPhones { get; set; }

        //[Required]
        [DisplayName("Opening Hours")]
        public String OpeningHours { get; set; }

        //[Required]
        [EmailAddress]
        [DisplayName("Email")]
        public String EmailAddress { get; set; }

        //[Required]
        [DisplayName("Website")]
        public String WWW { get; set; }

        [Required]
        [DisplayName("Category Code")]
        public String CategoryCode { get; set; }

        [Required]
        [DisplayName("Category")]
        public String CategoryName { get; set; }

        //[Required]
        [DisplayName("Description")]
        public String DescriptionEn { get; set; }

        //[Required]
        [DisplayName("Keywords")]
        public String KeywordsEn { get; set; }

        //[Required]
        [DisplayName("Trademarks")]
        public String TrademarksEn { get; set; }
    }
}