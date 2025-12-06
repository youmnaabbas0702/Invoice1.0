using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class CountryItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("Desc_en")]
        public string NameEn { get; set; }

        [JsonProperty("Desc_ar")]
        public string NameAr { get; set; }
    }

}
