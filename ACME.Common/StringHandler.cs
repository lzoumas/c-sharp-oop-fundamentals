using System;

namespace ACME.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source) // this makes it an extension method
        {
            var result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // Trim any spaces alrady there
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
                result = result.Trim();
            }

            return result;

        }
    }
}
