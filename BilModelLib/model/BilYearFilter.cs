using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilModelLib.model
{
    public class BilYearFilter
    {
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
    }



    /*
     * Som record - glem det
     */

    public record BilYearFilterRecord ( int? StartYear, int? EndYear);
}
