/*
 * Executor
 *
 * Runs the actual execution cycle of the machine.
 *
 */

namespace HypeVM.Master.VM
{

    using System;

    public sealed class Executor
    {

        //Execute a machine cycle on the given machine
        public static bool cycle(VM vm)
        {
            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Executor]: Machine cycle begin.");

            //Check the value of the `machineStatus` register
            byte machineStatus = vm.getRegisters().machineStatus;
            Console.Out.WriteLine("Machine status register is \"" + machineStatus);

            if (machineStatus == 0)
            {
                //Do nothing
            }
            else
            {
                //So far the implementation for this is to halt the machine if a non-zero value is placed in the `machineStatus` register
                return false;
            }

            //TODO: Implement me
            //1. Add exeuction and management of code
            Console.Out.WriteLine("[Executor]: Code execution cycle begin.");


            //TODO: Implement me (The execution of the machine code)
            short instructionPointerAddress = vm.getRegisters().instructionPointer;
            Console.Out.WriteLine("Current instruction pointer value (an address): " + instructionPointerAddress);

            //TODO: Continue here

            //TODO: Fetch the op code, fetch the operands per each instruction

            //The OPCode of the instruction
            byte opCode = fetchInstruction(instructionPointerAddress);
            Console.Out.WriteLine("OPCode is: \"" + opCode + "\"");

            //Check what instruction it is

            //Halt instructuction
            if (opCode == 0)
            {
                //Halt the machine when this instruction is encountered
                Console.Out.WriteLine("Instruction to halt machine, setting `machineStatus` register to 1");

                //Set the `machineStatus` register to a non-zero value so that when the next machine cycle begins the check for it to be
                //non-zero will result in the machine halting
                vm.getRegisters().machineStatus = 1;
            }
            //Machine reset
            else if (opCode == 1)
            {
                //TODO: Add abilty to reset the machine
            }
            //Invalid op code
            else
            {
                //Invalid opcode
                //TODO: Add handling for this
            }


            Console.Out.WriteLine("[Executor]: Code execution cycle end.");
            //2. poll all devices via devicemanager
            Console.Out.WriteLine("[Executor]: Poll devices begin.");
            //TODO: Implement me
            //vm.getDeviceManager().pollDevices(); Disabled for now
            Console.Out.WriteLine("[Executor]: Poll devices end.");

            //Output information (TODO: Finish me)
            Console.Out.WriteLine("[Executor]: Machine cycle end.");

            //Return true as there was no halting requested
            return true;
        }

        //Fetch the instruction (op code) at the given address
        private byte fetchInstruction(short instructionAddress)
        {
            //TODO: Implement me
        }
    }
}