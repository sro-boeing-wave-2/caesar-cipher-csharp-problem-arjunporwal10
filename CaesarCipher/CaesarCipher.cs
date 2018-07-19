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
                int asciiValueOfCharacter = (int)c;
                asciiValueOfCharacter += shiftKey;
                char intergerToCharacter;
                if (((int)c >= (int)'a' && (int)c <= (int)'z'))
                { 
                    if (asciiValueOfCharacter > (int)'z')
                        asciiValueOfCharacter -= 26;
                    intergerToCharacter = (char)asciiValueOfCharacter;
                    message += intergerToCharacter;
                }
                else if (((int)c >= (int)'A' && (int)c <= (int)'Z'))
                { 
                    if (asciiValueOfCharacter > (int)'Z')
                        asciiValueOfCharacter -= 26;
                  intergerToCharacter = (char)asciiValueOfCharacter;
                    message += intergerToCharacter;
                }
                else message += c;
            }
            return message;

        }
    }
}
