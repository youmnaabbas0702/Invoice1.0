using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_v1._0.Models
{
    public class Party
    {
        public int PartyID { get; set; }
        public string Role { get; set; }          
        public char Type { get; set; }            
        public string RegID { get; set; }         
        public string Name { get; set; }

        public string Country { get; set; }
        public string Governate { get; set; }
        public string RegionCity { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }

        public string BranchId { get; set; }
    }

}
