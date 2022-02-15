using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuki.Enumeration
{
    public enum AdminPinState
    {
        Ok = 0,
        Misisng = 1, //no Admin PIN set; recommended to add one for security reasons
        Invlaid = 2 //new Admin PIN needs to be set in Nuki Web
    }
}
