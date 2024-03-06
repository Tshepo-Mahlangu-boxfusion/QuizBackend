using QuizT.Debugging;

namespace QuizT
{
    public class QuizTConsts
    {
        public const string LocalizationSourceName = "QuizT";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "063dd4d67ab64685b6fe4936a73d4ae5";
    }
}
