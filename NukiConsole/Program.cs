using Nuki;
using Nuki.Enumeration;
using Nuki.Endpoint;

Authorization.ApiToken = "4c9f06a8fec13b54f8e40a1221f90de9057c29fdff59ac58c6f25c85ed08fc3d47d543a7631d4b92";

var smartlockTasks = Smartlock.GetSmartlocksAsync();
var smartlocks = smartlockTasks.Result;

var statusCode =
    await Smartlock.PostSmartlockActionAsync(smartlocks.First(),SmartlockAction.Lock,SmartlockOption.None);

Console.WriteLine(smartlocks.ToString());
