using System;

namespace CalculatorConsole
{
    public static class SignConverter
    {
        private static bool CheckIfSignIsNumber(char sign)
        {
            bool result = false;
            char[] digits = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char digit in digits)
            {
                if (sign == digit)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public static char FindOperationInText(string text)
        {
            char result = ' ';
            foreach (char sign in text)
            {
                bool isNumber = CheckIfSignIsNumber(sign);
                if (!isNumber)
                {
                    result = sign;
                    break;
                }
            }

            return result;
        }

        public static char FindOperationInTextParse(string text)
        {
            char result = ' ';
            foreach (char sign in text)
            {
                try
                {
                    int.Parse(sign.ToString());
                }
                catch (FormatException ex)
                {
                    result = sign;
                    break;
                }
            }

            return result;
        }

        public static char FindOperationInTextTryParse(string text)
        {
            char result = ' ';
            foreach (char sign in text)
            {
                int zmienna;
                bool isNumber = int.TryParse(sign.ToString(), out zmienna);
                if (!isNumber)
                {
                    result = sign;
                    break;
                }
            }

            return result;
        }
    }
}
