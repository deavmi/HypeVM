/*
 * RegisterManager
 *
 * This module manages the registers of the VM on the master node's side.
 *
 */

namespace HypeVM.Master.Registers
{

    using HypeVM.Master.Clients.Register;

    //Manager for the virtual machine's registers
    public sealed class RegisterManager
    {

        //The RegisterClient
        private RegisterClient registerClient;

        //Construct a new RegisterManager with th given RegisterClient
        public RegisterManager(RegisterClient registerClient)
        {
            //Set this RegisterManager's registerClient
            this.registerClient = registerClient;
        }

        //We will use properties to make accessing this way nicer and easier

        //The `codeFirst` register
        public short codeFirst
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

        //The `codeLast` register
        public short codeLast
        {

            //Get the value from the RegisterServer
            get
            {
                return getRegister(1);
            }

            //Send this to the RegisterServer
            set
            {
                setRegister(value, 1);
            }
        }

        //The `instructionPointer` register
        public short instructionPointer
        {

            //Get the value from the RegisterServer
            get
            {
                return getRegister(2);
            }

            //Send this to the RegisterServer
            set
            {
                setRegister(value, 2);
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