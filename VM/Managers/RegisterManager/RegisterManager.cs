/*
 * RegisterManager
 *
 * This module manages the registers of the VM on the master node's side.
 *
 */

namespace HypeVM.Master.Registers
{


    //Manager for the virtual machine's registers
    public sealed class RegisterManager
    {
        //Construct a new RegisterManager with th given RegisterClient
        public RegisterManager()
        {

        }

        //We will use properties to make accessing this way nicer and easier

        //The `codeBegin` register
        public short codeBegin
        {

            //Get the value from the RegisterServer
            get
            {
                return getRegister(0);
            }

            //Send this to the RegisterServer
            set
            {
                setRegister(value, 0);
            }
        }

        //TODO: Implement me
        //Set the given register to the given value
        public void setRegister(short value, short registerID)
        {
            //TODO: Implement me
        }

        //TODO: Implement me
        //Get the given register's value
        public short getRegister(short registerID)
        {
            //TODO: Implement me

            //Remove this below
            return 0;
        }

        
    }

}