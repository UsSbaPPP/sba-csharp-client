using System;
using System.Collections.Generic;
using System.Text;

namespace sbaCSharpClient.domain
{
    public class BusinessOwner
    {
        public int owner_type { get; set; }
        public int borrower_type { get; set; }
        public Business business { get; set; }
        public string business_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string title { get; set; }
        public int duns_number { get; set; }
        public int business_type { get; set; }
        public float ownership_percentage { get; set; }
        public string tin { get; set; }
        public int tin_type { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string zip_code_plus4 { get; set; }
        public string position { get; set; }
        public string veteran_status { get; set; }
        public string gender { get; set; }
        public string ethnicity { get; set; }
        public List<string> race { get; set; }

    }
}
