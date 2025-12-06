using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class UnitTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("desc_en")]
        public string DescEn { get; set; }

        [JsonProperty("desc_ar")]
        public string DescAr { get; set; }
    }
}
