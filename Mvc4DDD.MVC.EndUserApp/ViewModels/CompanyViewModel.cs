using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc4DDD.MVC.EndUserApp.ViewModels
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
        public String Name { get; set; }

        [Required]
        public String HouseNumber { get; set; }

        [Required]
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
        public String MainPhone { get; set; }

        //[Required]
        public String Fax { get; set; }

        //[Required]
        public String AdditionalPhones { get; set; }

        //[Required]
        public String OpeningHours { get; set; }

        //[Required]
        [EmailAddress]
        [DisplayName("Email")]
        public String EmailAddress { get; set; }

        //[Required]
        public String WWW { get; set; }

        [Required]
        public String CategoryCode { get; set; }

        [Required]
        public String CategoryName { get; set; }

        //[Required]
        public String DescriptionEn { get; set; }

        //[Required]
        public String KeywordsEn { get; set; }

        //[Required]
        public String TrademarksEn { get; set; }
    }
}