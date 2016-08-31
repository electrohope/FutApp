using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Back.Models
{
    class SoccerCenter
    {
        public int SoccerCenterId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string phone { get; set; }
        
        public ICollection<SoccerField> SoccerFields { get; set; }
    }
}
