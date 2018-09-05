/*
 * Plugins
 *
 * An assortment of things that can be attached to the machine in some
 * interface or another to add funcitonality to the machine.
 */

 namespace HypeVM.Plugins
 {

     using VM.Devices;

     //A PC speaker device
     public sealed class PCSpeaker : Devices
     {
         public override void poll()
         {
             //TODO: Check whether or not we should beep the speaker
             //and if so how many times
         }
     }
 }