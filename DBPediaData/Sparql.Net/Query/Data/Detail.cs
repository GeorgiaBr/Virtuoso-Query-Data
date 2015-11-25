using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosoQueryData.Sparql.Net.Query.Data
{
    public class Detail
    {
        [Newtonsoft.Json.JsonProperty("distinct")]
        public bool IsDistinct { get; set; }

        [Newtonsoft.Json.JsonProperty("ordered")]
        public bool IsOrdered { get; set; }

        [Newtonsoft.Json.JsonProperty("bindings")]
        public IList<Dictionary<string, VirtuosoQueryData.Sparql.Net.Query.Data.RowDetail>> Rows { get; set; }

        IList<dynamic> _Data = null;
        public IList<dynamic> Data
        {
            get
            {
                if (_Data != null) return _Data;
                _Data = new List<dynamic>();

                foreach (Dictionary<string, VirtuosoQueryData.Sparql.Net.Query.Data.RowDetail> row in this.Rows)
                {
                    var item = new System.Dynamic.ExpandoObject() as IDictionary<string, Object>;
                    foreach (KeyValuePair<string, VirtuosoQueryData.Sparql.Net.Query.Data.RowDetail> pair in row)
                    {
                        item.Add(pair.Key, pair.Value.Data);
                    }
                    _Data.Add(item);

                }

                return _Data;
            }
        }

    }
}
