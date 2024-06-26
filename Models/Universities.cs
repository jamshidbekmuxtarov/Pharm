using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Models
{
    internal class University
    {
        public string Name { get; set; }

        public string AlphaTwoCode { get; set; }

        public string country { get; set; }

        [JsonProperty("web_pages")]
        public string[] WebPages { get; set; }

        public string StateProvince { get; set; }

        public List<string> domains { get; set; }
    }
}
