using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Back.Models
{
    class SoccerField
    {
        public int SoccerFieldId { get; set; }
        public int SoccerCenterId { get; set; }
        public int SizeField { get; set; }
        public SoccerCenter SoccerCenter { get; set; }
    }
}
