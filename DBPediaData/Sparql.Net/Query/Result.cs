using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosoQueryData.Sparql.Net.Query
{
    public class Result
    {
        [Newtonsoft.Json.JsonProperty("head")]
        public VirtuosoQueryData.Sparql.Net.Query.Data.Header Header { get; set; }

        [Newtonsoft.Json.JsonProperty("results")]
        public VirtuosoQueryData.Sparql.Net.Query.Data.Detail Detail { get; set; }
    }
}
