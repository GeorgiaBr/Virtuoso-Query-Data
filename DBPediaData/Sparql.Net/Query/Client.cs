using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtuosoQueryData.Sparql.Net.Query
{
    public class Client
    {
        private bool _useTls;
        private static RestClient _client = new RestClient();
        private RestRequest _request = null;

        public Client(string endpoint)
        {
            _client.BaseUrl = endpoint;
            _request = new RestRequest(Method.GET);
            _request.AddHeader("Accept", "text/html, application/xhtml+xml, */*");
            _request.AddParameter("output", "json");
        }

        private VirtuosoQueryData.Sparql.Net.Query.Result Query(string sQuery)
        {
            if (_request.Parameters.Where(x => x.Name == "query").Count() == 0)
                _request.AddParameter("query", sQuery);
            else
                _request.Parameters.Where(x => x.Name == "query").FirstOrDefault().Value = sQuery;

            IRestResponse response = (RestResponse)_client.Execute(_request);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VirtuosoQueryData.Sparql.Net.Query.Result>(response.Content);
        }

        public List<VirtuosoQueryData.Sparql.Net.Query.Result> Query(VirtuosoQueryData.Sparql.Net.Query.QueryBuilder query)
        {
            List<VirtuosoQueryData.Sparql.Net.Query.Result> Results = new List<VirtuosoQueryData.Sparql.Net.Query.Result>();

            if (query.Limit > 2000)
            {

                int curLimit = 2000;
                int curOffset = query.Offset;
                int i = 1;
                int remainlimit = 0;

                VirtuosoQueryData.Sparql.Net.Query.Result res = new VirtuosoQueryData.Sparql.Net.Query.Result();
                do
                {
                    remainlimit = 2000;
                    curLimit = (2000 * i);
                    if (curLimit > query.Limit)
                    {
                        remainlimit = query.Limit - (2000 * (i - 1));
                        res = this.Query(query.Query + " LIMIT " + remainlimit.ToString() + " OFFSET " + curOffset.ToString());
                    }
                    else
                    {
                        res = this.Query(query.Query + " LIMIT 2000" + " OFFSET " + curOffset.ToString());
                    }
                    i += 1;
                    curOffset += 2000;

                    if (res.Detail.Data.Count > 0) { Results.Add(res); }
                } while (res.Detail.Data.Count > 0 && remainlimit >= 2000);

            }
            else
            {
                Results.Add(this.Query(query.QueryOriginal));
            }
            return Results;
        }
    }

}

