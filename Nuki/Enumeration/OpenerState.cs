using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuki.Enumeration
{
    public enum OpenerState
    {
        Untrained = 0,
        Online = 1,
        RingToOpenActive = 3,
        Open = 5,
        Opening = 7,
        BootRun = 253,
        Undefined = 255
    }
}
