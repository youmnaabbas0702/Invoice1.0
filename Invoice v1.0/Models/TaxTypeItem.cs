using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class TaxTypeItem
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Desc_en")]
        public string DescEn { get; set; }

        [JsonProperty("Desc_ar")]
        public string DescAr { get; set; }

        public string DisplayText => $"{Code} - {DescEn}";
    }
}
