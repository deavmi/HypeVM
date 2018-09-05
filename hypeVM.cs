namespace HypeVM
{

    public class HypeVM
    {
        public static void Main(string[] args)
        {
            //Testing
            //Create a new VM
            VM.VM vm = new VM.VM(null, new VM.Memory.Memory(32767));

            VM.Utils.Utils.memTest(vm);
            // while(true)
            // {

            // }
        }
    }
}