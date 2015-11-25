using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosoQueryData.Sparql.Net.Query.Data
{
    public class Header
    {
        [Newtonsoft.Json.JsonProperty("link")]
        public List<string> Link { get; set; }

        [Newtonsoft.Json.JsonProperty("vars")]
        public List<string> Columns { get; set; }
    }
}
