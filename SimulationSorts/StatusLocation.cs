using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationSorts
{
    public enum MovingTypes
    {
        UP_DOWN,    //di len, di xuong
        RIGHT_LEFT, //qua phai, qua trai
        DOWN_UP, //di xuong di len
        STOP    //dung lai
    }
    // vi tri luc di chuyen
    class StatusLocation
    {
        public MovingTypes movingTypes { get; set; }
        
        public int location1 { get; set; }
        public int location2 { get; set; }
    }
}
