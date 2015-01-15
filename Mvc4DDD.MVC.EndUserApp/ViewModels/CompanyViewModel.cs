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
        public String County { get; set; }

        [Required]
        public String XCoord { get; set; }

        [Required]
        public String YCoord { get; set; }

        [DisplayName("Main Phone")]
        public String MainPhone { get; set; }

        [DisplayName("Fax")]
        public String Fax { get; set; }

        [DisplayName("Additional Phones")]
        public String AdditionalPhones { get; set; }

        [DisplayName("Opening Hours")]
        public String OpeningHours { get; set; }

        [EmailAddress]
        [DisplayName("Email")]
        public String EmailAddress { get; set; }

        [DisplayName("Website")]
        public String WWW { get; set; }

        [Required]
        [DisplayName("Category Code")]
        public String CategoryCode { get; set; }

        [Required]
        [DisplayName("Category")]
        public String CategoryName { get; set; }

        [DisplayName("Description")]
        public String DescriptionEn { get; set; }

        [DisplayName("Keywords")]
        public String KeywordsEn { get; set; }

        [DisplayName("Trademarks")]
        public String TrademarksEn { get; set; }
    }
}