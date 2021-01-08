using sbaCSharpClient.domain;
using sbaCSharpClient.service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sbaCSharpClient.controller
{
    public class PPP3LoanOriginationController
    {
        private readonly PPP3LoanOriginationService ppp3LoanOriginationService;

        public PPP3LoanOriginationController(PPP3LoanOriginationService ppp3LoanOriginationService)
        {
            this.ppp3LoanOriginationService = ppp3LoanOriginationService;
        }
        public Task<string> submitPPP3LoanOriginationRequest(PPP3LoanOrigination request, string originationUrl)
        {
            Console.WriteLine("PPP3 loan origination request received");
            Task<string> response = ppp3LoanOriginationService.submitPPP3LoanOriginationRequest(request, originationUrl);
            return response;
        }
    }
}
