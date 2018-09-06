namespace HypeVM.Plugins.Devices.FileSystem
{

    using System;

    using VM.Devices;

    /*
     * FileSystem device
     *
     * This device allows you to access the host's file system.
     *
     */
     public sealed class NullDevice : Device
     {

        //TODO: Try static kak maybe for DeviceInfo object we are passing? :) YES!

        //TODO: CHeck null plus string implemntation of operator and other kak (test3.txt)
         public NullDevice() : base(new DeviceInfo("NullDevice " + null,"A device that does nothing"), null)
         {

         }
         

         //Execute the null device (and do nothing)
         public override void poll()
         {
            //Do nothing but say hey!
            Console.Out.WriteLine("Hey I am a null device and I do fokol");
         }
     }

     //Device information for the NullDevice
     //TODO: Add this

}