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

        public TextReader(string filePath)
        {
            fileStream = new FileStream(filePath, FileMode.Open);
        } 

        //Returns either a reference to a string object or null
        public string getNextLine()
        {
            string nextLine = "";

            //TODO: Implement me

            return nextLine;
        }
    }
}