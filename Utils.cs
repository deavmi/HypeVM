namespace HypeVM.Utils
{

    using System.Collections.Generic;

    //Utilities commonly used
    public sealed class Utils
    {

        //Encode a string of ASCII characters into an array of bytes)
        public static byte[] encodeASCII(string text)
        {
            //The bytes of the encoded ASCII characters
            List<byte> encodedASCII = new List<byte>();

            //The array of characters making up the string `text`
            char[] characterArray = text.ToCharArray();

            //Loop through each character and encode it as a byte
            for(int charIndex = 0; charIndex < characterArray.Length; charIndex++)
            {
                //The current character
                char currentCharacter = characterArray[charIndex];

                //Cast it to a byte (We have UTF 16 which is 1 word or 2 word encoding but because
                //all Unicode's are ascii compatible we only care about the lowest byte and hence we take this)
                //Note: We do not support anything but ASCII in HypeVM
                byte asciiByteCode = (byte)currentCharacter;

                //Add the byte to the array
                encodedASCII.Add(asciiByteCode);
            }

            return encodedASCII.ToArray();
        }

        //Decode an array of bytes into a string og ASCII characters
        public string decodeASCI(byte[] asciiBytes)
        {
            //The newly created string from the decoded ASCII bytes
            string decodedString = "";

            //Loop through the array of bytes and create ASCII character mapping per each byte
            for(int byteIndex = 0; byteIndex < asciiBytes.Length; byteIndex++)
            {
                //The current byte
                byte currentByte = asciiBytes[byteIndex];

                //The decoded character
                char decodedASCIICharacter = (char)currentByte;

                //Append it to the string
                decodedString = decodedString + decodedASCIICharacter;
            }

            return decodedString;
        }
    }

}