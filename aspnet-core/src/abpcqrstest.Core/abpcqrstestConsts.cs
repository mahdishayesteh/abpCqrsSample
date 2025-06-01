using abpcqrstest.Debugging;

namespace abpcqrstest;

public class abpcqrstestConsts
{
    public const string LocalizationSourceName = "abpcqrstest";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9c964f9e333443ef8eacfab6d1f8f0d1";
}
