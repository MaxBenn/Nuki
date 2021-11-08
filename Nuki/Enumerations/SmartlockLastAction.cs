using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuki.Enumerations
{
    public enum SmartlockLastAction
    {
        Unlock = 0,
        Lock = 1,
        Unlatch = 3,
        LockAndGo = 4,
        LockAndGoWithUnlatch = 5
    }
}
