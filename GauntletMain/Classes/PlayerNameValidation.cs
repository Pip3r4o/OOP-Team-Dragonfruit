namespace GauntletMain.Classes
{
    using System.Text.RegularExpressions;

    class PlayerNameValidation
    {
        private static readonly Regex ValidHostnameRegex =
            new Regex(@"^(([a-z]|[a-z][a-z0-9\-]*[a-z0-9])\.)*([a-z]|[a-z][a-z0-9\-]*[a-z0-9])$",
                RegexOptions.IgnoreCase);

        public static bool IsHostnameValid(string hostname)
        {
            if (!string.IsNullOrWhiteSpace(hostname))
            {
                return ValidHostnameRegex.IsMatch(hostname.Trim());
            }

            return false;
        }
    }
}
