using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nuki.Models
{
   public abstract class WebConfig
    {
        [JsonProperty("batteryWarningPerMailEnabled")]
        public bool BatteryWarningPerMailEnabled { get; set; }
        [JsonProperty("dismissedLiftUpHandleWarning")]
        public IList<int> DismissedLiftUpHandleWarnings { get; set; }
    }
}
