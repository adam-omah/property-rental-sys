using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PropertyRentalSystem
{
    public class validationFunctions
    {

        public static bool validPropertyName(string text)
        {
            bool result = true;
            Char[] nameChars = text.ToCharArray();


            for (int i = 0; i < nameChars.Length; i++)
            {
                // Allowed chars in property name are normal english letters &
                // spaces, numbers and 's.
                if (nameChars[i] == '\'' || nameChars[i] == ' '
                    || (nameChars[i] >= 'a' && nameChars[i] <= 'z') || (nameChars[i] >= 'A' && nameChars[i] <= 'Z')
                    || (nameChars[i] >= '0' && nameChars[i] <= '9'))
                {

                }
                else
                    result = false;
            }
            return result;
        }

        public static bool validPositiveNumber(string number)
        {
            bool result = true;
            char[] numberChars = number.ToCharArray();
            int dots = 0;

            // valid numbers must be numeric and only contain one '.' symbol - is not allowed.

            for (int i = 0; i < numberChars.Length; i++)
            {
                if (numberChars[i] == '.' || (numberChars[i] >= '0' && numberChars[i] <= '9'))
                {
                    if (numberChars[i] == '.')
                    {
                        if (dots == 1)
                        {
                            result = false;
                        }
                        else
                            dots++;

                    }
                }
                else
                    result = false;
            }

            return result;
        }

        public static bool validPositiveInt(string number)
        {
            bool result = true;
            char[] numberChars = number.ToCharArray();

            // valid numbers must be numeric and only contain one '.' symbol - is not allowed.

            for (int i = 0; i < numberChars.Length; i++)
            {
                if (numberChars[i] >= '0' && numberChars[i] <= '9')
                {

                }
                else
                    result = false;
            }

            return result;
        }


        public static bool validEircode(string eircode)
        {
            Boolean result = true;
            char[] eircodeChars = eircode.ToCharArray();

            if (eircode.Length != 7)
            {
                result = false;
                return result;
            }


            // checks if first value is a letter
            if ((eircodeChars[0] >= 'a' && eircodeChars[0] <= 'z') || (eircodeChars[0] >= 'A' && eircodeChars[0] <= 'Z'))
            {

            }
            else
            {
                result = false;
                return result;
            }


            // checks if following two are numbers:
            if ((eircodeChars[1] >= '0' && eircodeChars[1] <= '9') && (eircodeChars[2] >= '0' && eircodeChars[2] <= '9'))
            {

            }
            else
            {
                result = false;
                return result;
            }

            // check if last 4 chars are letters or numbers
            for (int i = 3; i < eircodeChars.Length; i++)
            {
                if ((eircodeChars[i] >= 'a' && eircodeChars[i] <= 'z') || (eircodeChars[i] >= 'A' && eircodeChars[i] <= 'Z') ||
                    (eircodeChars[i] >= '0' && eircodeChars[i] <= '9'))
                {

                }
                else
                {
                    result = false;
                    return result;
                }
            }

            // if result makes it to here and is still true will return true eircode is valid.
            return result;
        }

        public static bool validIban(string iban)
        {
            Boolean result = true;
            char[] ibanChars = iban.ToCharArray();

            // Iban's can vary between 22 and 34 characthers.
            // in Ireland the standard IBAN is 22 characthers in length.
            // there is other patterns involved but in the interest of simplicity
            // I am only adding simple validation. testing length and components.

            if (ibanChars.Length < 22 || ibanChars.Length > 34)
            {
                result = false;
            }


            // Iban must be composed of only numbers or letters:

            for (int i = 0; i < ibanChars.Length; i++)
            {
                if ((ibanChars[i] >= 'a' && ibanChars[i] <= 'z') || (ibanChars[i] >= 'A' && ibanChars[i] <= 'Z') ||
                    (ibanChars[i] >= '0' && ibanChars[i] <= '9'))
                {

                }
                else
                    result = false;
            }

            return result;
        }

        public static bool validPhoneNumber(string phone)
        {
            Boolean result = true;
            char[] phoneChars = phone.ToCharArray();

            if (phoneChars.Length > 6 && phoneChars.Length < 11)
            {
                for (int i = 0; i < phoneChars.Length; i++)
                {
                    if (phoneChars[i] >= '0' && phoneChars[i] <= '9')
                    {

                    }
                    else
                    {

                        result = false;
                        return result;
                    }
                }
            }
            else
                result = false;
            


            return result;
        }

        
        public static bool validEmailAddres(String email)
        {
            // Old email validation (slef made).
            Boolean result = true;
            int indexAt = email.IndexOf('@');
            int indexDot = email.IndexOf('.');
            int indexSpace = email.IndexOf(' ');
            char[] emailChars = email.ToCharArray();

            if (email.Equals("") || indexAt == -1 || indexDot == -1 || indexSpace != -1)
            {
                result = false;
            }

            // tests that the email char is valid allowed chars for email.
            // there is more but i am using a simple validation assuming standard emails.
            for (int i = 0; i < emailChars.Length; i++)
            {
                if ((emailChars[i] >= 'a' && emailChars[i] <= 'z') || (emailChars[i] >= 'A' && emailChars[i] <= 'Z')
                    || (emailChars[i] >= '0' && emailChars[i] <= '9') || emailChars[i] == '@' || emailChars[i] == '.' ||
                    emailChars[i] == '_' || emailChars[i] == '-')
                {

                }
                else
                    result = false;
            }




            return result;
        }

        public static String SQLApostrophe(String text)
        {

            String temp = text.Replace("\'","\'\'");
            return temp;
        }

        public static bool validEmail(String email)
        {
            bool result = true;

            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";


            Regex emailTest = new Regex(strRegex);
            if (emailTest.IsMatch(email)) 
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;

        }

        public static bool validStartDate(DateTime Date)
        {
            bool result = true;

            // checks if start date is date in future.
            if (!(Date >= DateTime.Now.Date))
            {
                result = false;
            }
            // Checks if start date is greater than 3 months from current date. 
            else if (Date > DateTime.Now.AddMonths(3))
            {
                result = false;
            }

            return result;

        }

        public static bool validEndDate(DateTime end,DateTime start)
        {
            bool result = true;
            // in case the add months function changes the values.
            DateTime start10 = start;
            DateTime start1 = start.AddMonths(1);

            // checks if date is more than 1 month from start date.
            // since start date is checked first and must be future date,
            // this also checks if end date is future.
            if (!(end >= start1))
            {
                result = false;
            }

            // checks if rent duration is greater than 10 years.
            if(end.Year >= start10.AddYears(10).Year)
            {
                result = false;
            }
       

            return result;

        }
    }
}

