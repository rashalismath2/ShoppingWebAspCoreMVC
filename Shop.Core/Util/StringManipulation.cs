using Shop.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Util
{
    public static class StringManipulation
    {
        public static string GetFullName(string firstName, string lastName)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return TrimFirstName(firstName) + " " + TrimLastName(lastName);
            }
            else if (!string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return TrimFirstName(firstName);
            }
            else if (string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return TrimLastName(lastName);
            }
            else
            {
                return "";
            }
        }

        private static string TrimFirstName(string firstName)
        {
            string trimmedFirstName = firstName.Trim();
            string firstLetterOfTheFirstName = trimmedFirstName[0].ToString().ToUpper();
            string remainingCharactersOfTheFirstName = trimmedFirstName.Substring(1, trimmedFirstName.Length - 1);
            return firstLetterOfTheFirstName + remainingCharactersOfTheFirstName;
        }
        private static string TrimLastName(string lastName)
        {
            string trimmedLastName = lastName.Trim();
            string firstLetterOfTheLastName = trimmedLastName[0].ToString().ToUpper();
            string remainingCharactersOfTheLastName = trimmedLastName.Substring(1, trimmedLastName.Length - 1);
            return firstLetterOfTheLastName + remainingCharactersOfTheLastName;
        }

        public static string GetPriceString(float price, Currencies currency) {
            return currency.ToString() +" "+ price;
        }
    }
}
