using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuki.Enumerations
{
    public enum ServerState
    {
        Ok = 0,
        Unregistered = 1,
        AuthUuidInvalid = 2,
        AuthInvalid = 3,
        Offline = 4
    }
}
