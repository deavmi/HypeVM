namespace HypeVM.Master.VM
{

    using System.IO;
    using System;
    using System.Collections.Generic;

    public sealed class ByteReader
    {

        //The file input stream
        private FileStream fileStream;
        

        //Construct a new byte reader
        public ByteReader(string filePath)
        {
            //Open the file stream
            fileStream = new FileStream(filePath, FileMode.Open);
        }

        //read all the bytes
        public byte[] readBytes()
        {
            List<byte> readBytes = new List<byte>();

            while(true)
            {
                int signal = fileStream.ReadByte();

                //If an EOF signal is sent
                if(signal == -1)
                {
                    //Then we end the loop
                    break;
                }
                //However if not then we have a byte
                else
                {
                    //Read the byte
                    byte readByte = (byte)signal;

                    //Add it to the List of bytes
                    readBytes.Add(readByte);
                }
            }

            //Return an array of bytes
            return readBytes.ToArray();
        }
    }
}