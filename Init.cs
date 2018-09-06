namespace HypeVM.VM.Utils
{

    using System;
    
    public sealed class Init
    {
        public static void bootMachine(VM vm, Bytecode.Bytecode bytecode)
        {
            RegisterState registers = vm.getRegisters();

            //Set the codePointer register to 0 (FIXME: Remove)
            registers.codePointer = 0;

            //Set the codeBasePointer register to the end of the code
            //TODO: Implement me

        }
    }

    public sealed class Utils
    {

        public static void memTest(VM vm)
        {
            //Run through the memory of the VM printing it all out
            Memory.Memory memory = vm.getMemory();

            for(short i = 0; i < memory.getSize(); i++)
            {
                Console.Out.WriteLine("MemTest[Address: "+i+"]: ByteVal<"+memory.getByte(i)+">");
            }

            //Memory size
            Console.Out.WriteLine("Memory size (bytes): " + memory.getSize());
        }
    }
}