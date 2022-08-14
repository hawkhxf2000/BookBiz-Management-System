using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.Utils
{
    public class VerificationUtil
    {
        //Verify if all character is number
        public static bool VerifyNumber(string text)
        {
            return text.All(char.IsNumber);
        }

        public static bool VerifyLetter(string text)
        {
            return text.Trim(' ').All(char.IsLetter);
        }
    }
}
