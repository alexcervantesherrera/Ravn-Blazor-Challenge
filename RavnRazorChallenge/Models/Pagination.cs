using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavnRazorChallenge.Models
{
    public class Pagination
    {
        public int pagina { get; set; } = 1;
        public int registros { get; set; } = 3;
        public int totalPaginas { get; set; }

    }
}
