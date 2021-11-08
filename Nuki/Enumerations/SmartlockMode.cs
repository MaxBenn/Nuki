using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuki.Enumerations
{
    public enum SmartlockMode
    {
        Uninitialized = 0,
        Pairing = 1,
        Door = 2,
        Maintenance = 4
    }
}
