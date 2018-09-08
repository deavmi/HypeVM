/*
 * TextReader
 *
 * A simple linefeed text reader.
 *
 */

using System;
using System.IO;
using System.Collections.Generic;

namespace HypeVM.Main
{
    public sealed class TextReader
    {

        //The file stream
        private FileStream fileStream;

        //Create a new TextReader
        public TextReader(string filePath)
        {
            fileStream = new FileStream(filePath, FileMode.Open);
        }

        //Returns either a reference to a string object or null
        public string getNextLine()
        {
            string nextLine = "";

            //Read each byte of the file till EOF is reached
            while(true)
            {
                //Current signal
                int signal = fileStream.ReadByte();

                //If the signal is -1 then it is EOF
                if(signal == -1)
                {
                    //TODO: Implement EOF handling
                }
                //Otehrwise it is the actual byte between 0 and 255
                else
                {
                    //TODO: Implement byte handling
                }
            }

            return nextLine;
        }
    }
}