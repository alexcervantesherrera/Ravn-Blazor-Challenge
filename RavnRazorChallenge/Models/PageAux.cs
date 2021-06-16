using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavnRazorChallenge.Shared
{
    public class PageAux
    {
        public string literal { get; set; }
        public int pagina { get; set; }
        public bool enable { get; set; } = true;
        public bool active { get; set; } = false;

        public PageAux( int page, bool enable , string literal )
        {

        }
    }
}
