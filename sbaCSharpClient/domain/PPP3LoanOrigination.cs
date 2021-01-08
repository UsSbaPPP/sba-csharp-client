using System;
using System.Collections.Generic;
using System.Text;

namespace sbaCSharpClient.domain
{
    public class PPP3LoanOrigination
    {
        public Business business { get; set; }
        public float average_monthly_payroll { get; set; }
        public float loan_amount { get; set; }
        public int number_of_employees { get; set; }
        public float period_1_revenue { get; set; }
        public float period_2_revenue { get; set; }
        public bool purpose_of_loan_payroll { get; set; }
        public bool purpose_of_loan_mortgage { get; set; }
        public bool purpose_of_loan_utilities { get; set; }
        public bool purpose_of_loan_covered_operations_expenditures { get; set; }
        public bool purpose_of_loan_covered_property_damage { get; set; }
        public bool purpose_of_loan_covered_supplier_costs { get; set; }
        public bool purpose_of_loan_covered_worker_protection_expenditure { get; set; }
        public bool purpose_of_loan_other { get; set; }
        public string purpose_of_loan_other_info { get; set; }
        public bool ineligible_general { get; set; }
        public bool ineligible_bad_loan { get; set; }
        public bool ineligible_criminal_charges { get; set; }
        public bool ineligible_felony { get; set; }
        public bool has_other_businesses { get; set; }
        public bool? received_eidl { get; set; }
        public bool all_employees_residency { get; set; }
        public string validation_errors { get; set; }
        public bool second_draw_ppp_loan { get; set; }
        public int applicant_meets_size_standard { get; set; }
        public int number_of_employees_at_time_of_application { get; set; }
        public int anticipated_number_of_employees_retained { get; set; }

    }
}
