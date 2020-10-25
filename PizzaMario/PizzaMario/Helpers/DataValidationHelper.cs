using System.Collections.Generic;

namespace PizzaMario.Helpers
{
    public static class DataValidationHelper
    {
        public static string BoolValidator(string validationString)
        {
            if (string.IsNullOrEmpty(validationString)) return string.Empty;
            var normalizedValidationString = validationString.ToLower().Trim();
            var value = BooleanLookupTable[normalizedValidationString];
            return value;
        }

        private static readonly IDictionary<string, string> BooleanLookupTable = new Dictionary<string, string>
        {
            {"ja", "true" },
            {"yes", "true" },
            {"nee", "false" },
            {"no", "false" }
        };
    }
}
