using static PhoneKeyPad.Program;

namespace PhoneKeyPad
{
    class PhoneNumber2
    {
        public static int PhoneNum2(char inputChar)
        {
            var phoneLetters = new PhoneCode();

            switch (inputChar)
            {
                case 'a':
                case 'b':
                case 'c':
                    return 2;
                    break;
                case 'd':
                case 'e':
                case 'f':
                    return 3;
                    break;
                case 'g':
                case 'h':
                case 'i':
                    return 4;
                    break;
                case 'j':
                case 'k':
                case 'l':
                    return 5;
                    break;
                case 'm':
                case 'n':
                case 'o':
                    return 6;
                    break;
                case 'p':
                case 'q':
                case 'r':
                case 's':
                    return 7;
                    break;
                case 't':
                case 'u':
                case 'v':
                    return 8;
                    break;
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    return 9;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
