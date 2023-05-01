using FlexiCoudPay.Debugging;

namespace FlexiCoudPay
{
    public class FlexiCoudPayConsts
    {
        public const string LocalizationSourceName = "FlexiCoudPay";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "19f1000658e94b6a82bf126ada592b20";
    }
}
