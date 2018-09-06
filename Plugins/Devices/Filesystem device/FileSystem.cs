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
     public sealed class FileSystemDevice : Device
     {

        //TODO: Try static kak maybe for DeviceInfo object we are passing? :) YES!

        //TODO: CHeck null plus string implemntation of operator and other kak (test3.txt)
         public FileSystemDevice() : base(new DeviceInfo("FileSystemDevice " + null,"A device that does nothing"), null)
         {

         }
         

         //Execute the null device (and do nothing)
         public override void poll()
         {
            //TODO: Implement me
         }
     }

     //Device information for the NullDevice
     //TODO: Add this

}