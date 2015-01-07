using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mvc4DDD.Domain.Entities
{

    /*public class AdditionalPhonesList
    {
        public List<String> AdditionalPhones { get; set; }

        public AdditionalPhonesList()
        {
            AdditionalPhones = new List<String>();
        }

        public AdditionalPhonesList(IEnumerable<String> list)
        {
            AdditionalPhones = new List<String>(list);
        }

        [JsonIgnore]
        public String Serialized
        {
            get
            {
                return JsonConvert.SerializeObject(this);
            }
            set
            {
                if (String.IsNullOrEmpty(value)) 
                    return;

                var aux = JsonConvert.DeserializeObject<AdditionalPhonesList>(value);

                this.AdditionalPhones.AddRange(aux.AdditionalPhones);
            }
        }
    }*/


    public class Company
    {
        public int CompanyId { get; set; }

        public String Name { get; set; }

        public String HouseNumber { get; set; }

        public String PostalCode { get; set; }

        public String City { get; set; }

        public String Country { get; set; }

        public String XCoord { get; set; }

        public String YCoord { get; set; }

        public String MainPhone { get; set; }

        public String Fax { get; set; }

        public String AdditionalPhones { get; set; }

        public String OpeningHours { get; set; }

        public String EmailAddress { get; set; }

        public String WWW { get; set; }
        
        public String CategoryCode { get; set; }
        
        public String CategoryName { get; set; }
        
        public String DescriptionEn { get; set; }

        public String KeywordsEn { get; set; }
        
        public String TrademarksEn { get; set; }
    }
}
