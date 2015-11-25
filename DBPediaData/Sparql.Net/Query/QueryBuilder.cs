using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuosoQueryData.Sparql.Net.Query
{
    public class QueryBuilder
    {
        private int _Limit = int.MaxValue;
        public int Limit { get { return _Limit; } }

        private int _Offset = 0;
        public int Offset { get { return _Offset; } }

        private string _Query = string.Empty;
        public string Query { get { return _Query; } }

        public string QueryOriginal
        {
            get
            {
                string sQuery = _Query;
                if (_Limit < int.MaxValue) { sQuery = string.Format("{0} LIMIT {1}", sQuery, _Limit); }
                if (_Offset > 0) { sQuery = string.Format("{0} OFFSET {1}", sQuery, _Offset); }
                return sQuery;
            }
        }

        public QueryBuilder(string sQuery)
        {
            _Query = sQuery;

            var res = (new System.Text.RegularExpressions.Regex(@"(?<=limit\s)(\w+)",
                                                                System.Text.RegularExpressions.RegexOptions.IgnoreCase)).Matches(sQuery);
            if (res.Count > 0)
            {
                try
                {
                    _Limit = int.Parse(res[res.Count - 1].Value);
                    _Query = (new System.Text.RegularExpressions.Regex("limit " + _Limit.ToString(),
                                                                        System.Text.RegularExpressions.RegexOptions.IgnoreCase)).Replace(_Query, "");
                }
                catch { }
            }

            res = (new System.Text.RegularExpressions.Regex(@"(?<=offset\s)(\w+)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)).Matches(sQuery);
            if (res.Count > 0)
            {
                try
                {
                    _Offset = int.Parse(res[res.Count - 1].Value);
                    _Query = (new System.Text.RegularExpressions.Regex("offset " + _Offset.ToString(),
                                                                           System.Text.RegularExpressions.RegexOptions.IgnoreCase)).Replace(_Query, "");
                }
                catch { }
            }
        }

    }
}
