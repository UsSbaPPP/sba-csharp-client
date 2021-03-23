using System;
using System.Collections.Generic;
using System.Text;

namespace sbaCSharpClient.domain
{
    public class PPP3LoanOrigination
    {
		public string slug{get;set;}

		public Business business{get;set;}

		public string organization{get;set;}

		public string status{get;set;}

		public string refinance_of_eidl_amount{get;set;}

		public string refinance_of_eidl_loan_number{get;set;}

		public string period_1_quarter{get;set;}

		public string period_2_quarter{get;set;}

		public double average_monthly_payroll{get;set;}

		public double loan_amount{get;set;}

		public int number_of_employees{get;set;}

		public long period_1_revenue{get;set;}

		public long period_2_revenue{get;set;}

		public bool purpose_of_loan_payroll{get;set;}

		public bool purpose_of_loan_mortgage{get;set;}

		public bool purpose_of_loan_utilities{get;set;}

		public bool purpose_of_loan_covered_operations_expenditures{get;set;}

		public bool purpose_of_loan_covered_property_damage{get;set;}

		public bool purpose_of_loan_covered_supplier_costs{get;set;}

		public bool purpose_of_loan_covered_worker_protection_expenditure{get;set;}

		public bool purpose_of_loan_other{get;set;}

		public string purpose_of_loan_other_info{get;set;}

		public bool ineligible_general{get;set;}

		public bool ineligible_bad_loan{get;set;}

		public bool ineligible_criminal_charges{get;set;}

		public bool ineligible_felony{get;set;}

		public bool has_other_businesses{get;set;}

		public bool received_eidl{get;set;}

		public bool all_employees_residency{get;set;}

		public long sba_application_id{get;set;}

		public long ppp_first_draw_sba_loan_number{get;set;}

		public long ppp_first_draw_loan_amount{get;set;}

		public long sba_number{get;set;}

		public string validation_errors{get;set;}

		public bool second_draw_ppp_loan{get;set;}

		public int applicant_meets_size_standard{get;set;}

		public int number_of_employees_at_time_of_application{get;set;}

		public int anticipated_number_of_employees_retained{get;set;}
		public string submission_confirmation_id{get;set;}
		public bool applicant_is_eligible{get;set;}
		public bool loan_request_is_necessary{get;set;}
		public bool applicant_meets_revenue_test_and_size_standard{get;set;}
		public bool applicant_no_shuttered_venue_grant{get;set;}
		public bool lender_contracted_third_party{get;set;}
		public bool applicant_has_reduction_in_gross_receipts{get;set;}
		public bool applicant_wont_receive_another_second_draw{get;set;}
		public string lender_application_number{get;set;}
		public string sba_decision_date{get;set;}
		public bool schedule_c_2483_form{get;set;}
		public string schedule_c_tax_year{get;set;}
		public double schedule_c_gross_income{get;set;}

	}
}
