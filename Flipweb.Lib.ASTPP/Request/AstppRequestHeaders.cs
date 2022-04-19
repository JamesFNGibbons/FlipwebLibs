using System;
namespace Flipweb.Lib.ASTPP.Request
{
    public class AstppRequestHeaders
    {
        public string endpointBase
        {
            get
            {
                return endpointBase;
            }
            set
            {
                endpointBase = value;
            }
        }
        public string apiKey {
            get {
                return apiKey;
             }
            set
            {
                apiKey = value;
            }
        }
        public string apiSecret
        {
            get
            {
                return apiSecret;
            }
            set
            {
                apiSecret = value;
            }
        }

        public AstppRequestHeaders(string baseEndpoint, string apiKey, string apiSecret)
        {
            this.endpointBase = baseEndpoint;
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
        }
    }
}
