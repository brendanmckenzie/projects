using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace Projects.Web.Api
{
    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            var ret = new StringBuilder();
            var l = propertyName.ToLower();
            for (var i = 0; i < propertyName.Length; i++)
            {
                var c = propertyName[i];
                var lc = l[i];

                if (c != l[i] && i > 0)
                {
                    ret.Append('_');
                }

                ret.Append(lc);
            }
            return ret.ToString();
        }
    }
}