using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosoQueryData.Sparql.Net.Query.Data
{
    public class RowDetail
    {
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("type")]
        public string DataType { get; set; }

        public object Data
        {
            get
            {
                switch (this.DataType.ToLower())
                {
                    case "literal":
                        return this.Value;

                    default:
                        return this.Value;

                }
            }
        }
    }
}
