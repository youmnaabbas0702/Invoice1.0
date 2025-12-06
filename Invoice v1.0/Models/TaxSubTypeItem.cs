using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class TaxSubTypeItem
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Desc_en")]
        public string DescEn { get; set; }

        [JsonProperty("Desc_ar")]
        public string DescAr { get; set; }

        [JsonProperty("TaxtypeReference")]
        public string TaxTypeReference { get; set; }

        // Optional: property to display code + description
        public string DisplayText => $"{Code} - {DescEn}";
    }
}
