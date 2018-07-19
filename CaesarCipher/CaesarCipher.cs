using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            //throw new NotImplementedException("You need to implement this function.");

            string message = "";
            foreach(char c in text)
            {
                if (((int)c >= (int)'a' && (int)c <= (int)'z'))
                {

                    int asciiValueOfCharacter = (int)c;
                    asciiValueOfCharacter += shiftKey;
                    if (asciiValueOfCharacter > (int)'z')
                        asciiValueOfCharacter -= 26;
                    char intergerToCharacter = (char)asciiValueOfCharacter;
                    message += intergerToCharacter;
                }
                else if (((int)c >= (int)'A' && (int)c <= (int)'Z'))
                {

                    int asciiValueOfCharacter = (int)c;
                    asciiValueOfCharacter += shiftKey;
                    if (asciiValueOfCharacter > (int)'Z')
                        asciiValueOfCharacter -= 26;
                    char intergerToCharacter = (char)asciiValueOfCharacter;
                    message += intergerToCharacter;
                }
                else message += c;
            }
            return message;

        }
    }
}
