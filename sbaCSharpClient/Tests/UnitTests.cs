using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using sbaCSharpClient.domain;
using Assert = NUnit.Framework.Assert;

namespace sbaCSharpClient.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly sbaCSharpClientTest cSharpClientTest;

        public UnitTests()
        {
            cSharpClientTest = new sbaCSharpClientTest();
        }

        [Test]
        public async Task getDocumentTypesAsync()
        {
            SbaPPPLoanDocumentTypeResponse response = await cSharpClientTest.getDocumentTypes();
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.IsoDateFormat});
            Assert.IsNotNull(serialized);
        }

        [Test]
        public async Task createForgivenessRequest()
        {
            #region build request

            Race race = new Race
            {
                race = "1"
            };

            Demographics demographics = new Demographics
            {
                name = "abc",
                position = "xyz",
                veteran_status = "1",
                gender = "X",
                ethnicity = "X",
                races = new List<Race>(1)
                {
                    race
                }
             };

            SbaPPPLoanForgiveness pppLoanForgiveness = new SbaPPPLoanForgiveness
            {
                etran_loan = new EtranLoan()
                {
                    demographics = new List<Demographics>(1)
                    {
                        demographics
                    },
                    bank_notional_amount = 21250,
                    sba_number = "2504010007",
                    loan_number = "7777777",
                    entity_name = "Abc Inc",
                    ein = "260320007",
                    funding_date = "2020-04-20",
                    forgive_eidl_amount = 10000.00,
                    forgive_eidl_application_number = 123456789,
                    forgive_payroll = 1000.00,
                    forgive_rent = 1000.00,
                    forgive_utilities = 1000.00,
                    forgive_mortgage = 1000.00,
                    address1 = "5050 Ritter Road – Suite B",
                    address2 = "Mechanicsburg PA",
                    dba_name = "Abc Inc",
                    phone_number = "6102342123",
                    forgive_fte_at_loan_application = 10,
                    forgive_line_6_3508_or_line_5_3508ez = 3999.00,
                    forgive_modified_total = 3999.00,
                    forgive_payroll_cost_60_percent_requirement = 1666.66,
                    forgive_amount = 1666.66,
                    forgive_fte_at_forgiveness_application = 10,
                    forgive_schedule_a_line_1 = 100.00,
                    forgive_schedule_a_line_2 = 5,
                    forgive_schedule_a_line_3_checkbox = false,
                    forgive_schedule_a_line_3 = 1.00,
                    forgive_schedule_a_line_4 = 100.00,
                    forgive_schedule_a_line_5 = 5,
                    forgive_schedule_a_line_6 = 100.00,
                    forgive_schedule_a_line_7 = 100.00,
                    forgive_schedule_a_line_8 = 100.00,
                    forgive_schedule_a_line_9 = 500.00,
                    forgive_schedule_a_line_10 = 1000.00,
                    forgive_schedule_a_line_10_checkbox = false,
                    forgive_schedule_a_line_11 = 10,
                    forgive_schedule_a_line_12 = 10,
                    forgive_schedule_a_line_13 = 1,
                    forgive_covered_period_from = "2020-04-20",
                    forgive_covered_period_to = "2020-06-19",
                    forgive_alternate_covered_period_from = "2020-04-20",
                    forgive_alternate_covered_period_to = "2020-06-19",
                    forgive_2_million = false,
                    forgive_payroll_schedule = "WEEKLY",
                    primary_email = "user@example.com",
                    primary_name = "Jason",
                    ez_form = false,
                    no_reduction_in_employees = false,
                    no_reduction_in_employees_and_covid_impact = false,
                    forgive_lender_confirmation = true,
                    forgive_lender_decision = 1
                },
            };

            #endregion

            var response = await cSharpClientTest.createForgivenessRequest(pppLoanForgiveness);
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.IsoDateFormat });
            Assert.IsNotNull(serialized);
        }

        [Test]
        public async Task createForgivenessRequest3508S()
        {
            #region build request

            SbaPPPLoanForgiveness pppLoanForgiveness = new SbaPPPLoanForgiveness
            {
                etran_loan = new EtranLoan()
                {
                    bank_notional_amount = 20000,
                    sba_number = "2504010000",
                    loan_number = "123456789",
                    entity_name = "Test Entity",
                    ein = "260320000",
                    funding_date = "2020-05-07",
                    forgive_eidl_amount = 100.00,
                    forgive_eidl_application_number = 123456789,
                    demographics = new List<Demographics>(),
                    address1 = "5050 Ritter Road – Suite B",
                    address2 = "Mechanicsburg, PA",
                    dba_name = "Abc Inc",
                    phone_number = "1234567890",
                    forgive_fte_at_loan_application = 10,
                    forgive_amount = 1666.66,
                    forgive_fte_at_forgiveness_application = 10,
                    forgive_2_million = false,
                    primary_email = "user@example.com",
                    primary_name = "Jason",
                    ez_form = false,
                    forgive_lender_confirmation = true,
                    forgive_lender_decision = 1,
                    s_form = true,
                },
            };

            #endregion

            var response = await cSharpClientTest.createForgivenessRequest(pppLoanForgiveness);
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.IsoDateFormat });
            Assert.IsNotNull(serialized);
        }

        [Test]
        public async Task uploadForgivenessDocument()
        {
            LoanDocumentResponse response = await cSharpClientTest.uploadForgivenessDocument("<file name>", "1",
                "<slug>",
                @"<path to file>");

            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.IsoDateFormat });
            Assert.IsNotNull(serialized);
        }

        [Test]
        public async Task getAllForgivenessRequests()
        {
            SbaPPPLoanForgivenessStatusResponse response = await cSharpClientTest.getAllForgivenessRequests();
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.IsoDateFormat});
            Assert.IsNotNull(serialized);
        }
        
        [Test]
        public async Task getForgivenessRequestBySbaNumber()
        {
            SbaPPPLoanForgivenessStatusResponse response = await cSharpClientTest.getForgivenessRequestBySbaNumber("<sba number>");
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.IsoDateFormat});
            Assert.IsNotNull(serialized);
        } 
        
       [Test]
        public async Task getSbaLoanForgivenessBySlug()
        {
            SbaPPPLoanForgiveness response = await cSharpClientTest.getSbaLoanForgivenessBySlug("<slug>");
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.IsoDateFormat});
            Assert.IsNotNull(serialized);
        } 
        
        [Test]
        public async Task deleteSbaLoanForgiveness()
        {
            bool response = await cSharpClientTest.deleteSbaLoanForgiveness("<slug>");
            Assert.IsTrue(response);
        }
        
        [Test]
        public async Task replyToSbaMessage()
        {
            MessageReply message = new MessageReply
            {
                document = @"<path to file>",
                document_name = "<document name>",
                document_type = 4,
                content = "<content>"
            };

            string response = await cSharpClientTest.replyToSbaMessage(message, "<slug>");
            Assert.IsNotNull(response);
        }

        [Test]
        public async Task replyToSbaMessageWithMultipleDocs()
        {
            MessageReplyMultipleFiles message = new MessageReplyMultipleFiles
            {
                // enter path to files you want to upload
                documents = new List<string>() { @"<path to file>", @"<path to file>" },

                // enter name of documents
                document_names = new List<string>() { "<document name>", "<document name>" },

                // enter document type of each document
                document_types = new List<int?>() { Int32.Parse("<document type>"), Int32.Parse("<document type>") },

                // enter comment for the upload
                content = "content"
            };

            string slug = "<slug>";

            string response = await cSharpClientTest.replyToSbaMessageWithMultipleDocs(message, slug);
            Assert.IsNotNull(response);
        }

        [Test]
        public async Task getForgivenessMessagesBySbaNumber()
        {
            SbaPPPLoanMessagesResponse response = await cSharpClientTest.getForgivenessMessagesBySbaNumber(1, "<sba number>", true);
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.IsoDateFormat});
            Assert.IsNotNull(serialized);
        } 

        [Test]
        public async Task getForgivenessMessagesBySlug()
        {
            SbaPPPLoanMessagesResponse response = await cSharpClientTest.getForgivenessMessagesBySlug("<slug>");
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings {DateFormatHandling = DateFormatHandling.IsoDateFormat});
            Assert.IsNotNull(serialized);
        }

        #region PPP3LoanOriginationTests

        [Test]
        public async Task submitPPP3LoanOriginationRequest()
        {
            BusinessOwner owner = new BusinessOwner()
            {
                owner_type = 1,
                first_name = "first",
                last_name = "last",
                business_name = "",
                title = "",
                duns_number = 0,
                business_type = 4,
                ownership_percentage = 100,
                tin = "252751625",
                tin_type = 1,
                address_line_1 = "123 Second St",
                address_line_2 = "",
                city = "Manhattan",
                state = "NY",
                zip_code = "10004",
                zip_code_plus4 = "1234",
                position = "string",
                veteran_status = "",
                gender = "",
                ethnicity = "",
                race = new List<string> { "1" }
            };
            PPP3LoanOrigination request = new PPP3LoanOrigination()
            {
                business = new Business
                {
                    owners = new List<BusinessOwner> { owner },
                    first_name = "First",
                    last_name = "Last",
                    date_of_establishment = "2020-01-01",
                    naics_code = "339992",
                    business_type = 1,
                    dba_tradename = "DBA",
                    duns_number = 0,
                    legal_name = "Legal Name",
                    address_line_1 = "123 Second St",
                    address_line_2 = "",
                    city = "City",
                    state = "AL",
                    zip_code = "17002",
                    zip_code_plus4 = "1234",
                    tin = "435881070",
                    tin_type = 0,
                    phone_number = "5482562187",
                    primary_contact = "primary",
                    primary_contact_email = "user@example.com",
                    is_franchise = true,
                    is_sba_listed_franchise = true,
                    franchise_code = "S3493"
                },
                average_monthly_payroll = 100.75,
                loan_amount = 251.88,
                number_of_employees = 15,
                purpose_of_loan_payroll = true,
                purpose_of_loan_mortgage = false,
                purpose_of_loan_utilities = false,
                purpose_of_loan_covered_operations_expenditures = false,
                purpose_of_loan_covered_property_damage = false,
                purpose_of_loan_covered_supplier_costs = false,
                purpose_of_loan_covered_worker_protection_expenditure = false,
                purpose_of_loan_other = false,
                purpose_of_loan_other_info = "",
                ineligible_general = true,
                ineligible_bad_loan = true,
                ineligible_criminal_charges = true,
                ineligible_felony = true,
                applicant_is_eligible = true,
                applicant_meets_revenue_test_and_size_standard = true,
                applicant_no_shuttered_venue_grant = true,
                applicant_meets_size_standard = 1,
                lender_contracted_third_party = true,
                loan_request_is_necessary = true,
                has_other_businesses = true,
                all_employees_residency = true,
                second_draw_ppp_loan = false,
                lender_application_number = "12345",
                schedule_c_2483_form = true,
                schedule_c_tax_year = "2019",
                schedule_c_gross_income = 20000.00
            };

            var response = await cSharpClientTest.submitPPP3LoanOriginationRequest(request);
            Assert.IsNotNull(response);

            string serialized = JsonConvert.SerializeObject(response,
                new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.IsoDateFormat });
            Assert.IsNotNull(serialized);
        }
        
        
        #endregion

    }
}
