using System;
using System.Collections.Generic;
using System.Text;

namespace sbaCSharpClient.domain
{
    public class Business
    {
        public List<BusinessOwner> owners { get; set; }
        public int business_type { get; set; }
        public string dba_tradename { get; set; }
        public int duns_number { get; set; }
        public string legal_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string zip_code_plus4 { get; set; }
        public string tin { get; set; }
        public int tin_type { get; set; }
        public string phone_number { get; set; }
        public string primary_contact { get; set; }
        public string primary_contact_email { get; set; }
        public string naics_code { get; set; }
        public bool is_franchise { get; set; }
        public bool is_sba_listed_franchise { get; set; }
        public string franchise_code { get; set; }
        public string date_of_establishment { get; set; }
    }
}
