using sbaCSharpClient.domain;
using sbaCSharpClient.restclient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sbaCSharpClient.service
{
    public class PPP3LoanOriginationService
    {
        private readonly SbaRestApiClient sbaRestApiClient;

        public PPP3LoanOriginationService(SbaRestApiClient sbaRestApiClient)
        {
            this.sbaRestApiClient = sbaRestApiClient;
        }
        public async Task<string> submitPPP3LoanOriginationRequest(PPP3LoanOrigination request, string originationUrl)
        {
            Console.WriteLine("Processing PPP3 Loan Origination request");
            return await sbaRestApiClient.sbmitPPP3LoanOriginationRequest(request, originationUrl);
        }
    }
}
