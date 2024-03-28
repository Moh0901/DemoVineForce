using DemoVineForce.Debugging;

namespace DemoVineForce
{
    public class DemoVineForceConsts
    {
        public const string LocalizationSourceName = "DemoVineForce";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "658ee0631bfa4aa89bcafb973a04d0e1";
    }
}
