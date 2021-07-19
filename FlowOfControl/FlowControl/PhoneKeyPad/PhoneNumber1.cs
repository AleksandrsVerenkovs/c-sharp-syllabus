using System;
using System.Collections.Generic;
using System.Linq;
using static PhoneKeyPad.Program;

namespace PhoneKeyPad
{
    class PhoneNumber1
    {
        public static int PhoneNum(char inputChar)
        {
            var phoneLetters = new PhoneCode();
            if (phoneLetters.ABC.Contains(inputChar)) return 2;
            else if (phoneLetters.DEF.Contains(inputChar)) return 3;
            else if (phoneLetters.GHI.Contains(inputChar)) return 4;
            else if (phoneLetters.JKL.Contains(inputChar)) return 5;
            else if (phoneLetters.MNO.Contains(inputChar)) return 6;
            else if (phoneLetters.PQRS.Contains(inputChar)) return 7;
            else if (phoneLetters.TUV.Contains(inputChar)) return 8;
            else if (phoneLetters.WXYZ.Contains(inputChar)) return 9;
            else return 0;
        }
    }
}
