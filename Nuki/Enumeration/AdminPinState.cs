namespace Nuki.Enumeration
{
    public enum AdminPinState
    {
        Ok = 0,
        Missing = 1, //no Admin PIN set; recommended to add one for security reasons
        Invalid = 2 //new Admin PIN needs to be set in Nuki Web
    }
}
