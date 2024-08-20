using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        public string Message { get; set; }
        public string EncodedMessage { get; private set; }

        private int shift;
        public int Shift
        {
            get => shift;
            set => shift = value>26 ? value%26 : value;
        }
        private bool isEncoded = false;

        public void Encode()
        {
            char[] charArray = Message.ToCharArray();
            char[] encodedCharArray = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if ((byte)charArray[i] >= 97 && (byte)charArray[i] <= 122)
                    encodedCharArray[i] = (char)((97) + (((byte)charArray[i] - 97 + shift) % 26));
                else if ((byte)charArray[i] >= 65 && (byte)charArray[i] <= 90)
                    encodedCharArray[i] = (char)((65) + (((byte)charArray[i] - 65 + shift) % 26));
                else if ((byte)charArray[i] == 32)
                    encodedCharArray[i] = charArray[i];
                else
                    encodedCharArray[i] = '?';
            }

            EncodedMessage = new string(encodedCharArray);

            isEncoded = isEncoded == false ? true : false;
        }
    }
}
