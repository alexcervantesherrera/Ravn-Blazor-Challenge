using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RavnRazorChallenge.Models
{
    public class Root
    {

        [JsonProperty( PropertyName = "people" )]
        public string people { get; set; }
        [JsonProperty( PropertyName = "planets" )]
        public string planets { get; set; }
        [JsonProperty( PropertyName = "films" )]
        public string films { get; set; }
        [JsonProperty( PropertyName = "species" )]
        public string species { get; set; }
        [JsonProperty( PropertyName = "vehicles" )]
        public string vehicles { get; set; }
        [JsonProperty( PropertyName = "starships" )]
        public string starships { get; set; }


    }
    public class RootObject
    {
        public List<Root> root { get; set; }
    }
}
