using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuki.Enumeration
{
    public enum DoorState
    {
        Unavailabel = 0,
        Deactivated = 1,
        DoorClosed = 2,
        DoorOpened = 3,
        DoorStateUnknown = 4,
        Calibrating = 5
    }
}
