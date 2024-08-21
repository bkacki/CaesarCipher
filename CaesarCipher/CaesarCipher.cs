using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public static class CaesarCipher
    {
        public static string Message { get; set; }
        public static string EncodedMessage { get; private set; }

        private static int shift;
        public static int Shift
        {
            get => shift;
            set => shift = value>26 ? value%26 : value;
        }

        private const int lowerCaseConst = 97;
        private const int capitalLetterConst = 65;

        public static string Encode(string message, int shiftInput)
        {
            Message = message; Shift = shiftInput;
            char[] charArray = Message.ToCharArray();
            char[] encodedCharArray = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if ((byte)charArray[i] >= 97 && (byte)charArray[i] <= 122)
                    encodedCharArray[i] = (char)(lowerCaseConst + ((byte)charArray[i] - lowerCaseConst + shift) % 26);
                else if ((byte)charArray[i] >= 65 && (byte)charArray[i] <= 90)
                    encodedCharArray[i] = (char)(capitalLetterConst + ((byte)charArray[i] - capitalLetterConst + shift) % 26);
                else if ((byte)charArray[i] >= 32 && (byte)charArray[i] <= 64)
                    encodedCharArray[i] = charArray[i];
                else if ((byte)charArray[i] >= 91 && (byte)charArray[i] <= 96)
                    encodedCharArray[i] = charArray[i];
                else if ((byte)charArray[i] >= 123 && (byte)charArray[i] <= 126)
                    encodedCharArray[i] = charArray[i];
                else
                    encodedCharArray[i] = '?';
            }
            EncodedMessage = new string(encodedCharArray);
            return EncodedMessage;
        }

        public static string Decode(string message, int shiftInput)
        {
            Message = message; Shift = shiftInput;
            char[] charArray = Message.ToCharArray();
            char[] encodedCharArray = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if ((byte)charArray[i] >= 97 && (byte)charArray[i] <= 122)
                    encodedCharArray[i] = (char)(lowerCaseConst + ((byte)charArray[i] - lowerCaseConst - shift + 26) % 26);
                else if ((byte)charArray[i] >= 65 && (byte)charArray[i] <= 90)
                    encodedCharArray[i] = (char)(capitalLetterConst + ((byte)charArray[i] - capitalLetterConst - shift + 26) % 26);
                else if ((byte)charArray[i] >= 32 && (byte)charArray[i] <= 64)
                    encodedCharArray[i] = charArray[i];
                else if ((byte)charArray[i] >= 91 && (byte)charArray[i] <= 96)
                    encodedCharArray[i] = charArray[i];
                else if ((byte)charArray[i] >= 123 && (byte)charArray[i] <= 126)
                    encodedCharArray[i] = charArray[i];
                else
                    encodedCharArray[i] = '?';
            }
            EncodedMessage = new string(encodedCharArray);
            return EncodedMessage;
        }
    }
}
